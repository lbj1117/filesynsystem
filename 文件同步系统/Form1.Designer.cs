namespace 文件同步系统
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.addsrc_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.src_txt = new System.Windows.Forms.TextBox();
            this.tar_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addtar_button = new System.Windows.Forms.Button();
            this.syn_button = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.notifyMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.最小化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.reset_button = new System.Windows.Forms.Button();
            this.addsyn_button = new System.Windows.Forms.Button();
            this.timer_copy = new System.Windows.Forms.Timer(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_second = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_minute = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_hour = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.notifyMenu.SuspendLayout();
            this.groupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // addsrc_button
            // 
            this.addsrc_button.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addsrc_button.Location = new System.Drawing.Point(496, 43);
            this.addsrc_button.Margin = new System.Windows.Forms.Padding(4);
            this.addsrc_button.Name = "addsrc_button";
            this.addsrc_button.Size = new System.Drawing.Size(65, 27);
            this.addsrc_button.TabIndex = 0;
            this.addsrc_button.Text = "添加";
            this.toolTip1.SetToolTip(this.addsrc_button, "添加源文件夹路径");
            this.addsrc_button.UseVisualStyleBackColor = true;
            this.addsrc_button.Click += new System.EventHandler(this.addsrc_button_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(31, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "源文件夹";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // src_txt
            // 
            this.src_txt.BackColor = System.Drawing.SystemColors.Info;
            this.src_txt.Location = new System.Drawing.Point(129, 44);
            this.src_txt.Margin = new System.Windows.Forms.Padding(4);
            this.src_txt.Name = "src_txt";
            this.src_txt.ReadOnly = true;
            this.src_txt.Size = new System.Drawing.Size(355, 26);
            this.src_txt.TabIndex = 3;
            this.toolTip1.SetToolTip(this.src_txt, "源文件夹路径");
            // 
            // tar_txt
            // 
            this.tar_txt.BackColor = System.Drawing.SystemColors.Info;
            this.tar_txt.Location = new System.Drawing.Point(129, 88);
            this.tar_txt.Margin = new System.Windows.Forms.Padding(4);
            this.tar_txt.Name = "tar_txt";
            this.tar_txt.ReadOnly = true;
            this.tar_txt.Size = new System.Drawing.Size(355, 26);
            this.tar_txt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tar_txt, "目的文件夹路径");
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(20, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "目的文件夹";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addtar_button
            // 
            this.addtar_button.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addtar_button.Location = new System.Drawing.Point(496, 88);
            this.addtar_button.Margin = new System.Windows.Forms.Padding(4);
            this.addtar_button.Name = "addtar_button";
            this.addtar_button.Size = new System.Drawing.Size(65, 26);
            this.addtar_button.TabIndex = 1;
            this.addtar_button.Text = "添加";
            this.toolTip1.SetToolTip(this.addtar_button, "添加目的文件夹路径");
            this.addtar_button.UseVisualStyleBackColor = true;
            this.addtar_button.Click += new System.EventHandler(this.addtar_button_Click);
            // 
            // syn_button
            // 
            this.syn_button.Location = new System.Drawing.Point(17, 30);
            this.syn_button.Margin = new System.Windows.Forms.Padding(4);
            this.syn_button.Name = "syn_button";
            this.syn_button.Size = new System.Drawing.Size(106, 46);
            this.syn_button.TabIndex = 6;
            this.syn_button.Text = "同步";
            this.toolTip1.SetToolTip(this.syn_button, "开始同步，将源文件夹内容复制到目的文件夹");
            this.syn_button.UseVisualStyleBackColor = true;
            this.syn_button.Click += new System.EventHandler(this.syn_button_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tar_txt);
            this.groupBox1.Controls.Add(this.src_txt);
            this.groupBox1.Controls.Add(this.addtar_button);
            this.groupBox1.Controls.Add(this.addsrc_button);
            this.groupBox1.Location = new System.Drawing.Point(29, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "路径设置";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.notifyMenu;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "文件同步系统";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // notifyMenu
            // 
            this.notifyMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.最小化ToolStripMenuItem,
            this.toolStripMenuItem2});
            this.notifyMenu.Name = "notifyMenu";
            this.notifyMenu.Size = new System.Drawing.Size(137, 70);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem1.Text = "显示主程序";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 最小化ToolStripMenuItem
            // 
            this.最小化ToolStripMenuItem.Name = "最小化ToolStripMenuItem";
            this.最小化ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.最小化ToolStripMenuItem.Text = "最小化";
            this.最小化ToolStripMenuItem.Click += new System.EventHandler(this.最小化ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(136, 22);
            this.toolStripMenuItem2.Text = "退出";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(17, 84);
            this.reset_button.Margin = new System.Windows.Forms.Padding(4);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(106, 46);
            this.reset_button.TabIndex = 7;
            this.reset_button.Text = "重置";
            this.toolTip1.SetToolTip(this.reset_button, "取消本界面已设置的同步任务");
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // addsyn_button
            // 
            this.addsyn_button.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addsyn_button.Location = new System.Drawing.Point(140, 31);
            this.addsyn_button.Name = "addsyn_button";
            this.addsyn_button.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.addsyn_button.Size = new System.Drawing.Size(60, 99);
            this.addsyn_button.TabIndex = 8;
            this.addsyn_button.Text = "新建";
            this.toolTip1.SetToolTip(this.addsyn_button, "新建一个同步任务");
            this.addsyn_button.UseVisualStyleBackColor = true;
            this.addsyn_button.Click += new System.EventHandler(this.addsyn_button_Click);
            // 
            // timer_copy
            // 
            this.timer_copy.Interval = 300000;
            this.timer_copy.Tick += new System.EventHandler(this.timer_copy_Tick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.richTextBox1.Location = new System.Drawing.Point(14, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(571, 187);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "\n                        欢迎使用文件同步系统！ \n\n";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.label5);
            this.groupBox.Controls.Add(this.comboBox_second);
            this.groupBox.Controls.Add(this.label4);
            this.groupBox.Controls.Add(this.comboBox_minute);
            this.groupBox.Controls.Add(this.label3);
            this.groupBox.Controls.Add(this.comboBox_hour);
            this.groupBox.Location = new System.Drawing.Point(29, 187);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(374, 142);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "同步周期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "秒";
            // 
            // comboBox_second
            // 
            this.comboBox_second.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_second.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_second.FormattingEnabled = true;
            this.comboBox_second.IntegralHeight = false;
            this.comboBox_second.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_second.Location = new System.Drawing.Point(252, 57);
            this.comboBox_second.Name = "comboBox_second";
            this.comboBox_second.Size = new System.Drawing.Size(54, 24);
            this.comboBox_second.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(217, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "分";
            // 
            // comboBox_minute
            // 
            this.comboBox_minute.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_minute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_minute.FormattingEnabled = true;
            this.comboBox_minute.IntegralHeight = false;
            this.comboBox_minute.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.comboBox_minute.Location = new System.Drawing.Point(157, 57);
            this.comboBox_minute.Name = "comboBox_minute";
            this.comboBox_minute.Size = new System.Drawing.Size(54, 24);
            this.comboBox_minute.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "时";
            // 
            // comboBox_hour
            // 
            this.comboBox_hour.BackColor = System.Drawing.SystemColors.Control;
            this.comboBox_hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hour.FormattingEnabled = true;
            this.comboBox_hour.IntegralHeight = false;
            this.comboBox_hour.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.comboBox_hour.Location = new System.Drawing.Point(62, 57);
            this.comboBox_hour.Name = "comboBox_hour";
            this.comboBox_hour.Size = new System.Drawing.Size(54, 24);
            this.comboBox_hour.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addsyn_button);
            this.groupBox2.Controls.Add(this.reset_button);
            this.groupBox2.Controls.Add(this.syn_button);
            this.groupBox2.Location = new System.Drawing.Point(414, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(217, 142);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "功能设置";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(29, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(602, 231);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "系统日志";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(666, 610);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "文件同步系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.notifyMenu.ResumeLayout(false);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addsrc_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox src_txt;
        private System.Windows.Forms.TextBox tar_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addtar_button;
        private System.Windows.Forms.Button syn_button;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Timer timer_copy;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_second;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_minute;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_hour;
        private System.Windows.Forms.ContextMenuStrip notifyMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem 最小化ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button addsyn_button;
    }
}

