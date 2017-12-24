using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using NPOI.SS.UserModel;
using System.IO;
using NPOI.HSSF.UserModel;
using NPOI.XSSF.UserModel;
namespace 出题程序
{
    public partial class Form1 : Form
    {
        private Boolean ifopenfileok = false;
        private string appname = "出题程序";
        private string appversion = "1.2";
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
            label_openfilecount.Text = "当前状态：未打开文件~";
            label_openfilename.Text = "...";
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
            string str_split = textBox_split.Text;
            if (str_split.Length == 0)
                str_split = "\t";

            Boolean allowsame = checkBox_allowsame.Checked;
            if (allowsame)   //允许重复
            {
                Random ran = new Random(System.DateTime.Now.Millisecond);
                for (int i = 0; i < count; i++)
                {
                    int choosed = ran.Next(all_count);
                    string appendstr = ifhasans ? arr_que[choosed] + str_split + arr_ans[choosed] : arr_que[choosed];
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
                    string appendstr = ifhasans ? arr_que[choosed] + str_split + arr_ans[choosed] : arr_que[choosed];
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
                IWorkbook workbook = null;  //新建IWorkbook对象  
                string fileName = openFileDialog_openfile.FileName;
                FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);

                try
                {

                    if (fileName.IndexOf(".xlsx") > 0) // 2007版本  
                    {
                        workbook = new XSSFWorkbook(fileStream);  //xlsx数据读入workbook  
                    }
                    else if (fileName.IndexOf(".xls") > 0) // 2003版本  
                    {
                        workbook = new HSSFWorkbook(fileStream);  //xls数据读入workbook  
                    }
                    ISheet sheet = workbook.GetSheetAt(0);  //获取第一个工作表  
                    //MessageBox.Show(sheet.SheetName+","+sheet.LastRowNum);
                    int rowCount = sheet.LastRowNum;
                    arr_ans = new string[rowCount];
                    arr_que = new string[rowCount];
                    IRow row;
                    for (int i = 0; i < rowCount; i++)  //对工作表每一行  
                    {
                        row = sheet.GetRow(i + 1);   //row读入第i行数据  
                        arr_que[i] = row.GetCell(0).ToString();
                        arr_ans[i] = row.GetCell(1).ToString();

                    }
                    label_openfilename.Text = "已载入文件:" + fileName;// +"；载入题目 " + rowCount + "道";
                    label_openfilecount.Text = "载入题目" + rowCount + "道";
                    ifopenfileok = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("打开文件失败！失败信息:\n" + ex.StackTrace);
                    return;
                }
                finally
                {
                    fileStream.Close();
                    workbook.Close();
                }
                
            }

        }

        //帮助
        private void button_help_Click(object sender, EventArgs e)
        {
            Help help = new Help(this);
            help.ShowDialog();
        }

        //是否enable 间隔符输入栏
        private void checkBox_ifhasans_CheckedChanged(object sender, EventArgs e)
        {
            textBox_split.Enabled = checkBox_ifhasans.Checked;
        }

        //错题help
        private void button_help_gen_Click(object sender, EventArgs e)
        {
            string msg = "在上面的框内输入错题情况，格式如下:\n"+
                "名字A\n1,4,5,6\n名字B\n3,4,5\n名字C\n4,5,6\n...\n"+
                "一行名字，一行错题题号，题号用逗号隔开";
            MessageBox.Show(msg);
        }


        //生成错题
        private void button_gen_error_Click(object sender, EventArgs e)
        {
            if (ifopenfileok == false)
            {
                MessageBox.Show("请先打开题库文件！");
                return;
            }
            if (arr_que == null || arr_ans == null)
            {
                MessageBox.Show("数据载入错误！");
                return;
            }

            textBox_output.Clear();

            try
            {
                StringBuilder sb=new StringBuilder();
                string[] errs = textBox_error.Lines;
                for (int i = 0; i < errs.Length / 2; i++)
                {
                    string name = errs[i*2];
                    if (name.Length == 0)
                        break;
                    string str_err = errs[i * 2 + 1];
                    sb.AppendLine(name);
                    string[] arr_err=str_err.Split(new char[]{','});
                    for (int j = 0; j < arr_err.Length; j++)
                    {
                        int num = Convert.ToInt32(arr_err[j]);
                        if (num < 1 || num > arr_ans.Length)
                            throw new Exception("题号超过了题目的范围！(1~" + arr_que.Length + ")");
                        sb.AppendLine(arr_que[num - 1] + "=" + arr_ans[num - 1]);
                    }
                }


                textBox_output.Text = sb.ToString();
            }
            catch (Exception ex) 
            {
                MessageBox.Show("错题格式错误！失败信息:\n" + ex.Message);
                return;
            }

        }

    }
}
