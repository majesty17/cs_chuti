using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace 出题程序
{
    public partial class Form1 : Form
    {
        private Boolean ifopenfileok = false;
        private string appname = "出题程序";
        private string appversion = "1.1";
        private string author = "Majesty";

        private string[] arr_que = null;
        private string[] arr_ans = null;

        public Form1()
        {
            InitializeComponent();
        }

        //初始化
        private void Form1_Load(object sender, EventArgs e)
        {
            label_openfilestatus.Text = "当前状态：未打开文件~";
            this.Text = appname + " v" + appversion + " by " + author;
        }

        //生成题目
        private void button_make_Click(object sender, EventArgs e)
        {
            if (ifopenfileok == false) {
                MessageBox.Show("请先打开题库文件！");
                return;
            }
            if (arr_que == null || arr_ans == null){
                MessageBox.Show("数据载入错误！");
                return;
            }
            //开始载入
            textBox_output.Clear();
            int count = Convert.ToInt32(textBox_ct.Text);
            int all_count = arr_que.Length;
            Boolean ifhasans = checkBox_ifhasans.Checked;
            if (count <= 0 || count > 999) {
                count = 10;
                textBox_ct.Text = "10";
            }

            Boolean allowsame = checkBox_allowsame.Checked;
            if (allowsame)   //允许重复
            {
                Random ran = new Random(System.DateTime.Now.Millisecond);
                for (int i = 0; i < count; i++)
                {
                    int choosed = ran.Next(all_count);
                    string appendstr = ifhasans ? arr_que[choosed] + "\t" + arr_ans[choosed] : arr_que[choosed];
                    textBox_output.AppendText(appendstr + "\r\n");
                }
            }
            else { 
                if(count>all_count){
                    MessageBox.Show("当不允许重复时，出题题目数不能超过题库中题目数！（抽屉原理）");
                    return;
                }
                //开辟一个内存，保存已经选出的；
                int[] arr_map = new int[all_count];

                Random ran = new Random(System.DateTime.Now.Millisecond);
                for (int i = 0; i < count; i++)
                {
                    int choosed = ran.Next(all_count);
                    while (arr_map[choosed] == 1) {
                        choosed = (choosed + 1) % all_count;
                    }
                    arr_map[choosed] = 1;
                    string appendstr = ifhasans ? arr_que[choosed] + "\t" + arr_ans[choosed] : arr_que[choosed];
                    textBox_output.AppendText(appendstr + "\r\n");
                }

            }
        }


        //复制到剪贴板
        private void button_copy_Click(object sender, EventArgs e)
        {
            if (textBox_output.Text.Length == 0) {
                return;
            }
            textBox_output.SelectAll();
            textBox_output.Copy();
            textBox_output.Select(0, 0);
            MessageBox.Show("复制成功");
        }

        //打开文件
        private void button_openfile_Click(object sender, EventArgs e)
        {
            if (openFileDialog_openfile.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(openFileDialog_openfile.FileName);
                string filepath = openFileDialog_openfile.FileName;
                string filename = openFileDialog_openfile.SafeFileName;

                string strConn = "Provider=Microsoft.Ace.OleDb.12.0;" + "data source=" + filepath + ";Extended Properties='Excel 12.0; HDR=Yes; IMEX=1'";
                OleDbConnection conn = new OleDbConnection(strConn);

                try
                {
                    conn.Open();
                    System.Data.DataTable schemaTable = conn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
                    string tableName = schemaTable.Rows[0][2].ToString().Trim();
                    string strExcel = "";
                    OleDbDataAdapter myCommand = null;
                    DataSet ds = null;
                    strExcel = "select * from [" + tableName + "]";
                    myCommand = new OleDbDataAdapter(strExcel, strConn);
                    ds = new DataSet();
                    myCommand.Fill(ds, tableName);
                    int iRowCount = ds.Tables[tableName].Rows.Count;
                    arr_ans = new string[iRowCount];
                    arr_que = new string[iRowCount];

                    //MessageBox.Show(tableName);
                    for (int i = 0; i < iRowCount; i++)
                    {
                        arr_que[i] = ds.Tables[tableName].Rows[i][0].ToString().Trim();
                        arr_ans[i] = ds.Tables[tableName].Rows[i][1].ToString().Trim();
                        //textBox_output.AppendText(arr_que[i] + "   " + arr_ans[i] + "\r\n");
                    }

                    label_openfilestatus.Text = "当前状态：已载入文件" + filename + "；载入题目" + iRowCount + "道";
                    ifopenfileok = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件失败！失败信息:\n" + ex.StackTrace);
                    return;
                }
                finally {
                    conn.Close();
                }
                
            }
            else { 
            }
        }

        //帮助
        private void button_help_Click(object sender, EventArgs e)
        {
            Help help = new Help(this);
            help.ShowDialog();
        }

    }
}
