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
            SimulateIO.MykeyDown((int)Keys.Enter);
            SimulateIO.MykeyUp((int)Keys.Enter);
            SimulateIO.MykeyDown((int)Keys.CapsLock);
            SimulateIO.MykeyUp((int)Keys.CapsLock);
            Click(msg.ToCharArray());
            SimulateIO.MykeyDown((int)Keys.CapsLock);
            SimulateIO.MykeyUp((int)Keys.CapsLock);
            SimulateIO.MykeyDown((int)Keys.Enter);
            SimulateIO.MykeyUp((int)Keys.Enter);

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

        public static void Click(char[] msg)
        {
            for (int i = 0; i < msg.Length; i++)
            {
                #region 自闭代码，谁碰谁知道
/*
                    object o;
                    int ri;
                    if (msg[i].Equals(""))
                    {
                        o = Keys.Space;
                    }
                    else if (int.TryParse(msg.ToString(), out ri))
                    {
                        o = Enum.Parse(typeof(Keys), "D" + ri);
                    }
                    else
                    {
                        o = Enum.Parse(typeof(Keys), msg[i].ToString().ToUpper());
                        //Console.WriteLine(o.ToString());
                    }
*/
                #endregion
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
                SimulateIO.MykeyDown((int)k);
                SimulateIO.MykeyUp((int)k);
            }
        }
    }
}
