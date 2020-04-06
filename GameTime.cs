using System.Windows.Forms;

namespace QuickTimeEnter
{
    class GameTime
    {
        private uint minutes;
        private uint seconds;

        public GameTime(string m, string s)
        {
            minutes = uint.Parse(m);
            seconds = uint.Parse(s);
        }

        public uint Minutes { get => minutes; set => minutes = value; }
        public uint Seconds { get => seconds; set => seconds = value; }

        public void StartTimer(TextBox textBox)
        {
            string m;
            string s;

            if (seconds < 59)
            {
                seconds++;
                if (seconds < 10)
                {
                    s = "0" + seconds.ToString();
                }
                else
                {
                    s = seconds.ToString();
                }
            }
            else
            {
                minutes++;
                seconds = 0;
                s = "00";
            }
            if (minutes < 10)
            {
                m = "0" + minutes.ToString();
            }
            else
            {
                if (minutes == 100)
                    minutes = 0;
                m = minutes.ToString();
            }
            textBox.Text = m + ":" + s;
        }

    }
}
