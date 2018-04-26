using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filesynsystem
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>

        [STAThread]
        static void Main()
        {
            SystemSleepManagement.PreventSleep();  //程序运行时，禁止Windows睡眠或休眠，以使程序可以一直运行
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            SystemSleepManagement.ResotreSleep(); //程序运行结束时，恢复Windows系统原来的睡眠策略
        }
    }


    static class SystemSleepManagement
    {
        /// <summary>
        /// 系统睡眠管理
        /// </summary>
       
        //定义API函数
        [DllImport("kernel32.dll")]
        static extern uint SetThreadExecutionState(ExecutionFlag flags);

        //枚举类型
        [Flags]
        enum ExecutionFlag : uint
        {
            System = 0x00000001, //不使用Continus参数时，实现阻止系统休眠关闭一次,
            Display = 0x00000002, //不使用Continus参数时，实现阻止显示器关闭一次
            Continus = 0x80000000,//只使用Continus参数时，则是恢复系统休眠策略，配合使用上述参数，阻止休眠或者。
        }

        ///阻止系统休眠，直到线程结束恢复休眠策略
        public static void PreventSleep()
        {
            SetThreadExecutionState(ExecutionFlag.System | ExecutionFlag.Continus);
        }

        ///恢复系统休眠策略
        public static void ResotreSleep()
        {
            SetThreadExecutionState(ExecutionFlag.Continus);
        }

    }
}
