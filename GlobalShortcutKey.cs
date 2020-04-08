using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuickTimeEnter
{
    enum KeyName
    {
        Top,
        Jg,
        Mid,
        Adc,
        Sup,
        Send = 10
    }

    class GlobalShortcutKey
    {
        //如果函数执行成功，返回值不为0。
        //如果函数执行失败，返回值为0。要得到扩展错误信息，调用GetLastError。
        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool RegisterHotKey(
            IntPtr hWnd,                //要定义热键的窗口的句柄
            KeyName id,                     //定义热键ID（不能与其它ID重复）           
            KeyModifiers fsModifiers,   //标识热键是否在按Alt、Ctrl、Shift、Windows等键时才会生效
            Keys vk                     //定义热键的内容
            );

        [DllImport("user32.dll", SetLastError = true)]
        private static extern bool UnregisterHotKey(
            IntPtr hWnd,                //要取消热键的窗口的句柄
            KeyName id                      //要取消热键的ID
            );

        //定义了辅助键的名称（将数字转变为字符以便于记忆，也可去除此枚举而直接使用数值）
        [Flags()]
        private enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WindowsKey = 8
        }

        public static void Start(IntPtr ptr)
        {
            RegisterHotKey(ptr, KeyName.Top, KeyModifiers.None, Keys.F1);
            RegisterHotKey(ptr, KeyName.Jg, KeyModifiers.None, Keys.F2);
            RegisterHotKey(ptr, KeyName.Mid, KeyModifiers.None, Keys.F3);
            RegisterHotKey(ptr, KeyName.Adc, KeyModifiers.None, Keys.F4);
            RegisterHotKey(ptr, KeyName.Sup, KeyModifiers.None, Keys.F5);
            RegisterHotKey(ptr, KeyName.Top + 5, KeyModifiers.Shift, Keys.F1);
            RegisterHotKey(ptr, KeyName.Jg + 5, KeyModifiers.Shift, Keys.F2);
            RegisterHotKey(ptr, KeyName.Mid + 5, KeyModifiers.Shift, Keys.F3);
            RegisterHotKey(ptr, KeyName.Adc + 5, KeyModifiers.Shift, Keys.F4);
            RegisterHotKey(ptr, KeyName.Sup + 5, KeyModifiers.Shift, Keys.F5);
            RegisterHotKey(ptr, KeyName.Send, KeyModifiers.None, Keys.F6);
            //测试
        }

        /* 暂未实现
         public static void Modify()
         {

         }
         */

        public static void Leave(IntPtr ptr)
        {
            UnregisterHotKey(ptr, KeyName.Top);
            UnregisterHotKey(ptr, KeyName.Jg);
            UnregisterHotKey(ptr, KeyName.Mid);
            UnregisterHotKey(ptr, KeyName.Adc);
            UnregisterHotKey(ptr, KeyName.Sup);
            UnregisterHotKey(ptr, KeyName.Top + 5);
            UnregisterHotKey(ptr, KeyName.Jg + 5);
            UnregisterHotKey(ptr, KeyName.Mid + 5);
            UnregisterHotKey(ptr, KeyName.Adc + 5);
            UnregisterHotKey(ptr, KeyName.Sup + 5);
            UnregisterHotKey(ptr, KeyName.Send);
        }
    }
}
