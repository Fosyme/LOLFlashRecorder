using System.Windows.Forms;

namespace QuickTimeEnter
{
    class SummonerFlashTime
    {
        private uint[] time;

        public SummonerFlashTime()
        {
            time = new uint[5];
            for (int i = 0; i < 5; i++)
            {
                time[i] = 0;
            }
        }
        public SummonerFlashTime(params Label[] labels)
        {
            time = new uint[5];
            for (int i = 0; i < 5; i++)
            {
                time[i] = 
                    (labels[i].Text.Equals("") || labels[i].Text == null || labels[i].Text.Equals("0")) ? 
                    0 : uint.Parse(labels[i].Text);
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
