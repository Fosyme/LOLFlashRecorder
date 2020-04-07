using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuickTimeEnter
{
    class OutputTime
    {
        private static string[] summonerName =
            {"top", "jg", "mid", "adc", "sup"};

        public static void KeyTimeToGame(GameTime g, SummonerFlashTime s)
        {
            string msg = "";
            for (int i = 0; i < 5; i++)
            {
                if (s.Time[i] == 0)
                {
                    continue;
                }
                msg += summonerName[i] + TimeFix(g.Minutes, g.Seconds, s.Time[i]) + " ";
            }
            Console.WriteLine(msg);
            SendKeys.SendWait("{ENTER}" + "{CAPSLOCK}" + msg + "{CAPSLOCK}" + "{ENTER}");
        }

        private static string TimeFix(uint m, uint s, uint st)
        {
            uint minutes = m + (s + st) / 60;
            uint seconds = (s + st) % 60;
            if (seconds < 10)
            {
                return minutes.ToString() + "0" + seconds.ToString();
            }
            return minutes.ToString() + seconds.ToString();
        }

        #region 第二种方案
        /*
        [DllImport("user32.dll")]
        public static extern void keybd_event(
            byte bVk,
            byte bScan,
            int dwFlags,     //这里为整数类型 0为按下，2为释放
            int dwExtraInfo
        );

        public static void Click()
        {
            keybd_event((byte)Keys.CapsLock, 0, 0, 0);
            keybd_event((byte)Keys.CapsLock, 0, 2, 0);
            keybd_event((byte)Keys.A, 0, 0, 0);
            keybd_event((byte)Keys.A, 0, 2, 0);
            keybd_event((byte)Keys.CapsLock, 0, 0, 0);
            keybd_event((byte)Keys.CapsLock, 0, 2, 0);
        }
        */
        #endregion
    }
}
