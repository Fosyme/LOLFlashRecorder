using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickTimeEnter
{
    class OutputTime
    {
        private static string[] summonerName =
            {"Top", "Jg", "Mid", "ADC", "Sup"};

        public static void KeyTimeToGame(GameTime g, SummonerFlashTime s)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(summonerName[i] + TimeFix(g.Minutes, g.Seconds, s.Time[i]));
            }
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
