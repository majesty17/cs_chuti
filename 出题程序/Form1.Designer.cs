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
            this.button_help = new System.Windows.Forms.Button();
            this.label_openfilestatus = new System.Windows.Forms.Label();
            this.button_openfile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBox_allowsame = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_ct = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox_ifhasans = new System.Windows.Forms.CheckBox();
            this.openFileDialog_openfile = new System.Windows.Forms.OpenFileDialog();
            this.button_copy = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_output
            // 
            this.textBox_output.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox_output.Location = new System.Drawing.Point(0, 183);
            this.textBox_output.Multiline = true;
            this.textBox_output.Name = "textBox_output";
            this.textBox_output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_output.Size = new System.Drawing.Size(434, 216);
            this.textBox_output.TabIndex = 0;
            // 
            // button_make
            // 
            this.button_make.Location = new System.Drawing.Point(12, 137);
            this.button_make.Name = "button_make";
            this.button_make.Size = new System.Drawing.Size(296, 40);
            this.button_make.TabIndex = 1;
            this.button_make.Text = "生成";
            this.button_make.UseVisualStyleBackColor = true;
            this.button_make.Click += new System.EventHandler(this.button_make_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_help);
            this.groupBox1.Controls.Add(this.label_openfilestatus);
            this.groupBox1.Controls.Add(this.button_openfile);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 64);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "载入题库文件";
            // 
            // button_help
            // 
            this.button_help.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button_help.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_help.Location = new System.Drawing.Point(107, 20);
            this.button_help.Name = "button_help";
            this.button_help.Size = new System.Drawing.Size(23, 23);
            this.button_help.TabIndex = 2;
            this.button_help.Text = "?";
            this.button_help.UseVisualStyleBackColor = true;
            this.button_help.Click += new System.EventHandler(this.button_help_Click);
            // 
            // label_openfilestatus
            // 
            this.label_openfilestatus.AutoSize = true;
            this.label_openfilestatus.Location = new System.Drawing.Point(6, 46);
            this.label_openfilestatus.Name = "label_openfilestatus";
            this.label_openfilestatus.Size = new System.Drawing.Size(41, 12);
            this.label_openfilestatus.TabIndex = 1;
            this.label_openfilestatus.Text = "label1";
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(6, 20);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(95, 23);
            this.button_openfile.TabIndex = 0;
            this.button_openfile.Text = "打开文件...";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBox_allowsame);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBox_ct);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.checkBox_ifhasans);
            this.groupBox2.Location = new System.Drawing.Point(12, 82);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(409, 49);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "出题配置";
            // 
            // checkBox_allowsame
            // 
            this.checkBox_allowsame.AutoSize = true;
            this.checkBox_allowsame.Location = new System.Drawing.Point(98, 20);
            this.checkBox_allowsame.Name = "checkBox_allowsame";
            this.checkBox_allowsame.Size = new System.Drawing.Size(72, 16);
            this.checkBox_allowsame.TabIndex = 4;
            this.checkBox_allowsame.Text = "允许重复";
            this.checkBox_allowsame.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "[1~999]";
            // 
            // textBox_ct
            // 
            this.textBox_ct.Location = new System.Drawing.Point(268, 18);
            this.textBox_ct.MaxLength = 3;
            this.textBox_ct.Name = "textBox_ct";
            this.textBox_ct.Size = new System.Drawing.Size(35, 21);
            this.textBox_ct.TabIndex = 2;
            this.textBox_ct.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "题目数";
            // 
            // checkBox_ifhasans
            // 
            this.checkBox_ifhasans.AutoSize = true;
            this.checkBox_ifhasans.Location = new System.Drawing.Point(8, 20);
            this.checkBox_ifhasans.Name = "checkBox_ifhasans";
            this.checkBox_ifhasans.Size = new System.Drawing.Size(72, 16);
            this.checkBox_ifhasans.TabIndex = 0;
            this.checkBox_ifhasans.Text = "包括答案";
            this.checkBox_ifhasans.UseVisualStyleBackColor = true;
            // 
            // openFileDialog_openfile
            // 
            this.openFileDialog_openfile.Filter = "Excel表格文件(*.xls,*.xlsx)|*.xls;*.xlsx";
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(314, 137);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(107, 40);
            this.button_copy.TabIndex = 4;
            this.button_copy.Text = "复制";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 399);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_make);
            this.Controls.Add(this.textBox_output);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label label_openfilestatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog_openfile;
        private System.Windows.Forms.CheckBox checkBox_ifhasans;
        private System.Windows.Forms.TextBox textBox_ct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_help;
        private System.Windows.Forms.CheckBox checkBox_allowsame;
    }
}

