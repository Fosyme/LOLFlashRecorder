using System.Windows.Forms;

namespace LOLFlashRecorder
{
    public partial class ShowMsgOnTop : Form
    {
        //使窗口无焦点
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_NOACTIVATE = 0x08000000;
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= WS_EX_NOACTIVATE;
                return cp;
            }
        }

        public ShowMsgOnTop()
        {
            InitializeComponent();
            this.Left = Screen.PrimaryScreen.Bounds.Width - 800;
            this.Top = 10;
        }

        public void ShowMsg(GameTime gt, SummonerFlashTime sft)
        {
            lblMsgTemp.Text = "游戏时间\r\n";
            lblMsgTemp.Text += gt.Minutes.ToString() + ":" + ((gt.Seconds < 10) ? ("0" + gt.Seconds.ToString()) : gt.Seconds.ToString()) + "\r\n";
            for (int i = 0; i < 5; i++)
            {
                uint t = sft.Time[i];
                if (t != 0)
                {
                    lblMsgTemp.Text += (i == 2) ? " " : "" + OutputTime.summonerName[i] + t;
                    if (t < 10)
                    {
                        lblMsgTemp.Text += " ";
                    }
                    else if (t < 100)
                    {
                        lblMsgTemp.Text += "  ";
                    }
                    lblMsgTemp.Text += "\r\n";
                }
            }
        }
    }
}
