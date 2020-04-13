using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace QuickTimeEnter
{
    class OutputTime
    {
        private static string[] summonerName =
            {"top", "jg", "mid", "adc", "sup"};

        //将时间格式化输出
        public static void KeyTimeToGame(GameTime g, SummonerFlashTime s)
        {
            string msg = "";
            for (int i = 0; i < 5; i++)
            {
                //判断是否需要输出的信息
                if (s.Time[i] == 0)
                {
                    continue;
                }
                msg += summonerName[i] + TimeFix(g.Minutes, g.Seconds, s.Time[i]) + " ";
            }
            Console.WriteLine(msg);

            /*
            try
            {
                SendKeys.Send("{ENTER}" + "{CAPSLOCK}" + msg + "{CAPSLOCK}" + "{ENTER}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Find a error!");
                throw;
            }
            */

        }

        //将信息格式化处理
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

        //将主体信息部分进行底层模拟信号处理
        public static void IOHandle(char[] msg)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                Keys k = Keys.Space;
                switch (msg[i])
                {
                    case ' ':
                        k = Keys.Space;
                        break;
                    case '0':
                        k = Keys.D0;
                        break;
                    case '1':
                        k = Keys.D1;
                        break;
                    case '2':
                        k = Keys.D2;
                        break;
                    case '3':
                        k = Keys.D3;
                        break;
                    case '4':
                        k = Keys.D4;
                        break;
                    case '5':
                        k = Keys.D5;
                        break;
                    case '6':
                        k = Keys.D6;
                        break;
                    case '7':
                        k = Keys.D7;
                        break;
                    case '8':
                        k = Keys.D8;
                        break;
                    case '9':
                        k = Keys.D9;
                        break;
                    case 'a':
                        k = Keys.A;
                        break;
                    case 'c':
                        k = Keys.C;
                        break;
                    case 'd':
                        k = Keys.D;
                        break;
                    case 'g':
                        k = Keys.G;
                        break;
                    case 'i':
                        k = Keys.I;
                        break;
                    case 'j':
                        k = Keys.J;
                        break;
                    case 'm':
                        k = Keys.M;
                        break;
                    case 'o':
                        k = Keys.O;
                        break;
                    case 'p':
                        k = Keys.P;
                        break;
                    case 's':
                        k = Keys.S;
                        break;
                    case 't':
                        k = Keys.T;
                        break;
                    case 'u':
                        k = Keys.U;
                        break;
                }
            }
        }
    }
}
