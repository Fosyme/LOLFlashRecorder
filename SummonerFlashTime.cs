using System.Windows.Forms;

namespace QuickTimeEnter
{
    class SummonerFlashTime
    {
        private uint[] time;

        public SummonerFlashTime(params string[] t)
        {
            time = new uint[5];
            for (int i = 0; i < 5; i++)
            {
                time[i] = t[i].Equals("") || t[i] == null ? 0 : uint.Parse(t[i]);
            }
        }

        public uint[] Time { get => time; set => time = value; }

        public void FlashETA(params Label[] labels)
        {
            for (int i = 0; i < 5; i++)
            {
                labels[i].Text = time[i] == 0 ? "" : (--time[i]).ToString();
            }
        }

    }
}
