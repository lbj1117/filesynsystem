using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;

namespace 文件同步系统
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        static System.Threading.Mutex _mutex;

        [STAThread]
        static void Main()
        {
            //判断本程序是否已运行一个实例
            bool createNew;
            Attribute guid_attr = Attribute.GetCustomAttribute(Assembly.GetExecutingAssembly(), typeof(GuidAttribute));
            string guid = ((GuidAttribute)guid_attr).Value;
            _mutex = new System.Threading.Mutex(true, guid, out createNew);

            if (createNew == false) //已运行一个实例,则不再新建本程序的实例
            {
                MessageBox.Show("文件同步系统已在运行！");
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1());
            }
           
        }
    }
}
