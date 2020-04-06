using System;
using System.Windows.Forms;

namespace QuickTimeEnter
{
    class OutputTime
    {
        private static string[] summonerName =
            {"Top", "Jg", "Mid", "ADC", "Sup"};

        public static void KeyTimeToGame(GameTime g, SummonerFlashTime s)
        {
            string msg = "";
            for (int i = 0; i < 5; i++)
            {
                msg += (summonerName[i] + TimeFix(g.Minutes, g.Seconds, s.Time[i])).ToLower() + " ";
                
            }
            Console.WriteLine(msg);
            try
            {
                SendKeys.SendWait("{ENTER}" + "{CAPSLOCK}" + msg + "{CAPSLOCK}" + "{ENTER}");
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine(e.ToString());
                throw;
            }
            //SendKeys.SendWait("{CAPSLOCK}");
            //SendKeys.SendWait(msg);
            //SendKeys.SendWait("{CAPSLOCK}");
            //SendKeys.SendWait("{ENTER}");
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
    }
}
