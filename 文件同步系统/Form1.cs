using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;
namespace 文件同步系统
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  //初始化窗体
            //设置默认同步周期
            comboBox_hour.SelectedIndex = 0;    //时
            comboBox_minute.SelectedIndex = 5;  //分
            comboBox_second.SelectedIndex = 0;  //秒

        }


        int synflag = 0;  //初始化同步标志，为零时可配置新的同步任务


        static public void CopyDir(string srcPath, string aimPath)  //复制文件夹子程序 
        {
            try
            {

                //检查目标目录是否以目录分割字符结束,如果不是则添加
                if (aimPath[aimPath.Length - 1] != Path.DirectorySeparatorChar)
                {
                    aimPath += Path.DirectorySeparatorChar;
                }

                //判断目标目录是否存在如果不存在则新建之  
                if (!Directory.Exists(aimPath))
                {
                    Directory.CreateDirectory(aimPath);
                }

                //得到源目录的文件列表,是一个包含文件以及文件夹路径的数组
                string[] fileList = Directory.GetFileSystemEntries(srcPath);

                //遍历所有的文件和目录    
                foreach (string file in fileList)
                {
                    //先当作目录处理，如果存在这个目录，就递归复制该目录下面的文件    
                    if (Directory.Exists(file))
                    {
                        CopyDir(file, aimPath + Path.GetFileName(file));
                    }

                    //否则直接Copy文件   
                    else
                    {
                        //当目的文件夹不存在此文件，或者两文件最后修改日期不相同时才复制
                        if (!File.Exists(aimPath + Path.GetFileName(file)) ||
                            (File.GetLastWriteTime(aimPath + Path.GetFileName(file)) != File.GetLastWriteTime(file)))
                        {
                            File.Copy(file, aimPath + Path.GetFileName(file), true);
                        }
                    }
                } //foreach
            } //try
            catch (Exception e)
            {
                MessageBox.Show("The process failed: {0}", e.ToString());
            }

        }  //CopyDir


        private void addsrc_button_Click(object sender, EventArgs e)  //添加源文件夹路径
        {
            FolderBrowserDialog P_File_Folder = new FolderBrowserDialog();  //打开文件夹对话框

            if (P_File_Folder.ShowDialog() == DialogResult.OK)  // 文件夹对话框点击确定

            {

                //MessageBox.Show(P_File_Folder.SelectedPath);//选定目录后打印路径信息
                src_txt.Text = P_File_Folder.SelectedPath;
            }
        }


        private void addtar_button_Click(object sender, EventArgs e)  //添加目标文件夹路径
        {
            FolderBrowserDialog P_File_Folder = new FolderBrowserDialog();

            if (P_File_Folder.ShowDialog() == DialogResult.OK)

            {
                tar_txt.Text = P_File_Folder.SelectedPath;
            }
        }


        private void syn_button_Click(object sender, EventArgs e)  //点击同步按钮
        {
            string path = src_txt.Text;
            string target = tar_txt.Text;

            if (path == "" || target == "")  //文件夹路径为空
            {
                MessageBox.Show("请添加文件夹路径");
                return;
            }
            if (!Directory.Exists(path))  //不存在源文件夹
            {
                MessageBox.Show("操作失败： 源文件夹不存在，请检查！");
                return;
            }
            if (comboBox_hour.SelectedIndex == 0 && comboBox_minute.SelectedIndex == 0
                && comboBox_second.SelectedIndex == 0)  //同步周期为0
            {
                MessageBox.Show("请选择正确的同步周期！");
                return;
            }

            if (synflag == 0)
            {

                //禁用同步周期下拉框
                comboBox_hour.Enabled = false;
                comboBox_minute.Enabled = false;
                comboBox_second.Enabled = false;
                //禁用文件夹路径选择按键
                addsrc_button.Enabled = false;
                addtar_button.Enabled = false;

                richTextBox1.Text = richTextBox1.Text + "\n开始同步文件，如果待同步文件较大，" +
                                    "执行首次同步任务时可能会出现卡顿现象，请耐心等待...\n\n";
                richTextBox1.Text = richTextBox1.Text + "正在将文件夹：\"" + src_txt.Text +
                    "\" 下的文件复制到文件夹：\"" + tar_txt.Text + "\" 内，请等待...\n\n";

                Application.DoEvents(); //刷新窗口进行的更改，立即显示上边那句话

                CopyDir(path, target);  //立即执行一次copy动作

                richTextBox1.Text = richTextBox1.Text + "已完成首次同步任务！首次同步时间：" + DateTime.Now.ToString() + "\n\n";

                timer_copy.Interval = (comboBox_hour.SelectedIndex * 3600 +
                    comboBox_minute.SelectedIndex * 60 + comboBox_second.SelectedIndex) * 1000;  //获取同步周期，单位为毫秒
                timer_copy.Enabled = true;  //设置定时器开，按设置频率重复执行动作
                richTextBox1.Text = richTextBox1.Text + "开始执行自动同步，" + "同步周期为：" + comboBox_hour.SelectedIndex
                    + "时" + comboBox_minute.SelectedIndex + "分" + comboBox_second.SelectedIndex + "秒。\n\n" + "下次同步将在 "
                     + comboBox_hour.SelectedIndex + "时" + comboBox_minute.SelectedIndex + "分" +
                     comboBox_second.SelectedIndex + "秒 后开始执行。\n\n";

                synflag = 1; //打开同步开关，禁止设置新的同步任务
            }
            else
            {
                MessageBox.Show(@"您已设置一个同步任务，如要更改，" +
                    "请点击“重置”取消该同步并设置新的同步任务！", "提示信息",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


        private void reset_button_Click(object sender, EventArgs e)  //点击重置按钮，重新设置同步任务
        {
            synflag = 0;  //同步关闭，可配置新的同步任务
            timer_copy.Enabled = false; //禁用定时器
            //启用同步周期下拉框
            comboBox_hour.Enabled = true;
            comboBox_minute.Enabled = true;
            comboBox_second.Enabled = true;
            //启用文件夹路径选择按键
            addsrc_button.Enabled = true;
            addtar_button.Enabled = true;
            //输出提示语
            richTextBox1.Text = richTextBox1.Text + "已停止当前同步任务，请重新设置以执行新的同步任务！\n\n";
        }


        private void addsyn_button_Click(object sender, EventArgs e)  //点击新建按钮，打开新的窗口
        {
            DialogResult result = MessageBox.Show("您确定要新建一个同步任务吗？", "提示信息",
              MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Form2 f2 = new Form2();
                f2.Show();
            }
        }


        private void timer_copy_Tick(object sender, EventArgs e)  //定时器，执行周期任务
        {
            string path = src_txt.Text;
            string target = tar_txt.Text;
            timer_copy.Enabled = false; //暂时关闭定时器，待此次同步完成后开启
            CopyDir(path, target);
            richTextBox1.Text = richTextBox1.Text + "同步成功，本次同步完成时间：" + DateTime.Now.ToString() + "，下次同步将在 "
                + comboBox_hour.SelectedIndex + " 时 " +
                comboBox_minute.SelectedIndex + " 分 " + comboBox_second.SelectedIndex + " 秒 后开始执行。\n\n";
            timer_copy.Enabled = true; //此次同步完成，开启定时器
        }


        private void richTextBox1_TextChanged(object sender, EventArgs e)  //系统日志文本框
        {
            richTextBox1.SelectionStart = richTextBox1.TextLength;   //自动定位到多行文本框的最后一行
            richTextBox1.ScrollToCaret();
        }


        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)  //点击托盘左键，显示主程序
        {
            if (e.Button == MouseButtons.Left)
            {
                ShowInTaskbar = true;
                this.WindowState = FormWindowState.Normal;

            }

        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e) //托盘右键，显示主程序
        {
            ShowInTaskbar = true;
            this.WindowState = FormWindowState.Normal;

        }


        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized) //最小化时关闭任务栏图标
            {
                ShowInTaskbar = false;
            }
        }


        private void 最小化ToolStripMenuItem_Click(object sender, EventArgs e) //点击托盘右键最小化按钮，最小化
        {
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }


        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e) //双击托盘图标，最小化
        {
            this.WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }


        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)  //点击托盘右键退出按钮，退出
        {
            DialogResult result = MessageBox.Show("您确定要关闭文件同步系统吗？\n点击确定将关闭所有已开启的同步任务。\n请确认！！！", "提示信息",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                this.Dispose();
                Application.Exit(); //点击OK，确定退出   
            }
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)  //关闭窗口时提醒
        {
            DialogResult result = MessageBox.Show("你确定要关闭文件同步系统吗？\n点击确定将关闭所有已开启的同步任务。\n请确认！！！", "提示信息",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Information);  //获取消息提示框的返回值

            if (result == DialogResult.OK)
            {
                e.Cancel = false;  //点击OK，确定退出   
            }
            else
            {
                e.Cancel = true; //点击取消，程序继续运行
            }
        }

    }
}
