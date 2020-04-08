using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace QuickTimeEnter
{
    class SwitchWindow
    {
        /*[DllImport("user32.dll")]
        private static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        //根据任务栏应用程序显示的名称找相应窗口的句柄
        [DllImport("User32.dll", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
        private const int SW_RESTORE = 9;

        public static void SwitchWindowFromQTE(object sender, EventArgs e)
        {
            //查找状态中的窗口线程句柄来查看目标程序是否在运行运行则前置否则打开
            IntPtr findPtr = FindWindow(null, "League of Legends");
            if (findPtr.ToInt32() != 0)
            {
                ShowWindow(findPtr, SW_RESTORE); //将窗口还原，如果不用此方法，缩小的窗口不能激活
                SetForegroundWindow(findPtr);//将指定的窗口选中(激活)
            }
        }*/

        [DllImport("user32.dll", EntryPoint = "PostMessage")]
        public static extern int PostMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        [DllImport("User32.dll ", EntryPoint = "FindWindow")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);//关键方法
        [DllImport("user32.dll", SetLastError = true)]
        private static extern int SendMessage(IntPtr HWnd, uint Msg, int WParam, int LParam);
        public const int WM_SYSCOMMAND = 0x112;
        public const int SC_MINIMIZE = 0xF020;
        public const int SC_MAXIMIZE = 0xF030;
        public const uint WM_SYSCOMMAND2 = 0x0112;
        public const uint SC_MAXIMIZE2 = 0xF030;
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
        [DllImport("user32.dll")]
        public static extern void SwitchToThisWindow(IntPtr hWnd, bool fAltTab);

        //从软件界面转跳到另一个程序界面，利用任务栏的程序名
        public static bool SwitchWindowFromQTE(string gameName)
        {
            Process[] processes = Process.GetProcessesByName(gameName);
            if (processes.Length > 0)
            {
                IntPtr handle = processes[0].MainWindowHandle;
                SendMessage(handle, WM_SYSCOMMAND2, new IntPtr(SC_MAXIMIZE2), IntPtr.Zero);	// 最大化
                SwitchToThisWindow(handle, true);	// 激活
                return true;
            }
            return false;
        }
    }
}
