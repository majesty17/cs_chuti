namespace 出题程序
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_output = new System.Windows.Forms.TextBox();
            this.button_make = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_openfilecount = new System.Windows.Forms.Label();
            this.button_help = new System.Windows.Forms.Button();
            this.label_openfilename = new System.Windows.Forms.Label();
            this.button_openfile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_allowsame = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_ifhasans = new System.Windows.Forms.CheckBox();
            this.openFileDialog_openfile = new System.Windows.Forms.OpenFileDialog();
            this.button_copy = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_split = new System.Windows.Forms.TextBox();
            this.button_gen_error = new System.Windows.Forms.Button();
            this.textBox_error = new System.Windows.Forms.TextBox();
            this.button_help_gen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_output
            // 
            this.textBox_output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_output.Location = new System.Drawing.Point(0, 329);
            this.textBox_output.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(1003, 324);
            this.textBox_output.TabIndex = 0;
            // 
            // button_make
            // 
            this.button_make.Location = new System.Drawing.Point(18, 261);
            this.button_make.Margin = new System.Windows.Forms.Padding(4);
            this.button_make.Name = "button_make";
            this.button_make.Size = new System.Drawing.Size(444, 60);
            this.button_make.TabIndex = 1;
            this.button_make.Text = "随机出题";
            this.button_make.UseVisualStyleBackColor = true;
            this.button_make.Click += new System.EventHandler(this.button_make_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_openfilecount);
            this.groupBox1.Controls.Add(this.button_help);
            this.groupBox1.Controls.Add(this.label_openfilename);
            this.groupBox1.Controls.Add(this.button_openfile);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(614, 96);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "载入题库文件";
            // 
            // label_openfilecount
            // 
            this.label_openfilecount.AutoSize = true;
            this.label_openfilecount.Location = new System.Drawing.Point(214, 38);
            this.label_openfilecount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_openfilecount.Name = "label_openfilecount";
            this.label_openfilecount.Size = new System.Drawing.Size(62, 18);
            this.label_openfilecount.TabIndex = 3;
            this.label_openfilecount.Text = "label1";
            // 
            // button_help
            // 
            this.button_help.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_help.Location = new System.Drawing.Point(160, 30);
            this.button_help.Margin = new System.Windows.Forms.Padding(4);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(34, 34);
            this.button_help.TabIndex = 2;
            this.button_help.Text = "?";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // label_openfilename
            // 
            this.label_openfilename.AutoSize = true;
            this.label_openfilename.Location = new System.Drawing.Point(9, 69);
            this.label_openfilename.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_openfilename.Name = "label_openfilename";
            this.label_openfilename.Size = new System.Drawing.Size(62, 18);
            this.label_openfilename.TabIndex = 1;
            this.label_openfilename.Text = "label1";
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(9, 30);
            this.button_openfile.Margin = new System.Windows.Forms.Padding(4);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(142, 34);
            this.button_openfile.TabIndex = 0;
            this.button_openfile.Text = "打开文件...";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox_split);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.checkBox_allowsame);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_ct);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox_ifhasans);
            this.groupBox2.Location = new System.Drawing.Point(18, 123);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(614, 112);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出题配置";
            // 
            // checkBox_allowsame
            // 
            this.checkBox_allowsame.AutoSize = true;
            this.checkBox_allowsame.Location = new System.Drawing.Point(147, 30);
            this.checkBox_allowsame.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_allowsame.Name = "checkBox_allowsame";
            this.checkBox_allowsame.Size = new System.Drawing.Size(106, 22);
            this.checkBox_allowsame.TabIndex = 4;
            this.checkBox_allowsame.Text = "允许重复";
            this.checkBox_allowsame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(464, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "[1~999]";
            // 
            // textBox_ct
            // 
            this.textBox_ct.Location = new System.Drawing.Point(402, 27);
            this.textBox_ct.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ct.MaxLength = 3;
            this.textBox_ct.Name = "textBox_ct";
            this.textBox_ct.Size = new System.Drawing.Size(50, 28);
            this.textBox_ct.TabIndex = 2;
            this.textBox_ct.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(332, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "题目数";
            // 
            // checkBox_ifhasans
            // 
            this.checkBox_ifhasans.AutoSize = true;
            this.checkBox_ifhasans.Checked = true;
            this.checkBox_ifhasans.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_ifhasans.Location = new System.Drawing.Point(12, 30);
            this.checkBox_ifhasans.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_ifhasans.Name = "checkBox_ifhasans";
            this.checkBox_ifhasans.Size = new System.Drawing.Size(106, 22);
            this.checkBox_ifhasans.TabIndex = 0;
            this.checkBox_ifhasans.Text = "包括答案";
            this.checkBox_ifhasans.UseVisualStyleBackColor = true;
            this.checkBox_ifhasans.CheckedChanged += new System.EventHandler(this.checkBox_ifhasans_CheckedChanged);
            // 
            // openFileDialog_openfile
            // 
            this.openFileDialog_openfile.Filter = "Excel表格文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(472, 261);
            this.button_copy.Margin = new System.Windows.Forms.Padding(4);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(160, 60);
            this.button_copy.TabIndex = 4;
            this.button_copy.Text = "复制";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(296, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "题目与答案的间隔符(不填为制表符)";
            // 
            // textBox_split
            // 
            this.textBox_split.Location = new System.Drawing.Point(315, 69);
            this.textBox_split.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_split.MaxLength = 3;
            this.textBox_split.Name = "textBox_split";
            this.textBox_split.Size = new System.Drawing.Size(50, 28);
            this.textBox_split.TabIndex = 6;
            // 
            // button_gen_error
            // 
            this.button_gen_error.Location = new System.Drawing.Point(640, 261);
            this.button_gen_error.Margin = new System.Windows.Forms.Padding(4);
            this.button_gen_error.Name = "button_gen_error";
            this.button_gen_error.Size = new System.Drawing.Size(313, 60);
            this.button_gen_error.TabIndex = 5;
            this.button_gen_error.Text = "生成错题";
            this.button_gen_error.UseVisualStyleBackColor = true;
            this.button_gen_error.Click += new System.EventHandler(this.button_gen_error_Click);
            // 
            // textBox_error
            // 
            this.textBox_error.Location = new System.Drawing.Point(640, 28);
            this.textBox_error.Multiline = true;
            this.textBox_error.Name = "textBox_error";
            this.textBox_error.Size = new System.Drawing.Size(350, 226);
            this.textBox_error.TabIndex = 6;
            this.textBox_error.Text = "张三\r\n1,2,3\r\n李四\r\n4,5,6\r\n王五\r\n7,8,9";
            // 
            // button_help_gen
            // 
            this.button_help_gen.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_help_gen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_help_gen.Location = new System.Drawing.Point(956, 261);
            this.button_help_gen.Margin = new System.Windows.Forms.Padding(4);
            this.button_help_gen.Name = "button_help_gen";
            this.button_help_gen.Size = new System.Drawing.Size(34, 60);
            this.button_help_gen.TabIndex = 7;
            this.button_help_gen.Text = "?";
            this.button_help_gen.UseVisualStyleBackColor = true;
            this.button_help_gen.Click += new System.EventHandler(this.button_help_gen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 653);
            this.Controls.Add(this.button_help_gen);
            this.Controls.Add(this.textBox_error);
            this.Controls.Add(this.button_gen_error);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_make);
            this.Controls.Add(this.textBox_output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_output;
        private System.Windows.Forms.Button button_make;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.Label label_openfilename;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog_openfile;
        private System.Windows.Forms.CheckBox checkBox_ifhasans;
        private System.Windows.Forms.TextBox textBox_ct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.CheckBox checkBox_allowsame;
        private System.Windows.Forms.Label label_openfilecount;
        private System.Windows.Forms.TextBox textBox_split;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_gen_error;
        private System.Windows.Forms.TextBox textBox_error;
        private System.Windows.Forms.Button button_help_gen;
    }
}

