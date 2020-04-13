using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuickTimeEnter
{
    public partial class Form1 : Form
    {
        string pattern;
        string gameName;
        private GameTime gameTime;
        private SummonerFlashTime summonerFlashTime;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pattern = @"^\d{1,2}[:：][0-5]?[0-9]$";
            gameName = "League of Legends (TM) Client";
            GlobalShortcutKey.Start(Handle);
            //SimulateIO.Initialize();
        }

        private void btnSetFromTop_Click(object sender, EventArgs e)
        {
            bool isTop = btnSetFromTop.Text.Equals("置顶");
            btnSetFromTop.Text = isTop ? "取消置顶" : "置顶";
            this.TopMost = isTop;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnStart.Text = "开始";
            txtGameTime.Text = "00:00";
            lblTopETA.Text = "";
            lblJgETA.Text = "";
            lblMidETA.Text = "";
            lblAdcETA.Text = "";
            lblSupETA.Text = "";
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text.Equals("开始"))
            {
                btnStart.Text = "暂停";
                if (!Regex.IsMatch(txtGameTime.Text, pattern))
                {
                    lblInputInfo.Visible = true;
                    return;
                }
                string[] nowGameTime = txtGameTime.Text.Split(':', '：');
                gameTime = new GameTime(nowGameTime[0], nowGameTime[1]);
                summonerFlashTime = new SummonerFlashTime(lblTopETA, lblJgETA, lblMidETA, lblAdcETA, lblSupETA);
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                btnStart.Text = "开始";
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gameTime.StartTimer(txtGameTime);
            summonerFlashTime.FlashETA(lblTopETA, lblJgETA, lblMidETA, lblAdcETA, lblSupETA);
        }

        private void txtGameTime_TextChanged(object sender, EventArgs e)
        {
            lblInputInfo.Visible = false;
        }

        private void btnSwitchGame_Click(object sender, EventArgs e)
        {
            SwitchWindow.SwitchWindowFromQTE(gameName);
        }

        private void lnklblHelpManual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //System.Diagnostics.Process.Start();
        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            try
            {
                System.Threading.Thread.Sleep(1000);
                //OutputTime.KeyTimeToGame(gameTime, summonerFlashTime);
                SimulateIO.Test(lblInputInfo);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void txtTopShortcutKey_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtJgShortcutKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMidShortcutKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdcShortcutKey_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSupShortcutKey_TextChanged(object sender, EventArgs e)
        {

        }

        // 接收快捷键信息，然后执行相关操作
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            if (summonerFlashTime != null && m.Msg==WM_HOTKEY)
            {
                // 快捷键事件
                switch (m.WParam.ToInt32())
                {
                    //设置时长
                    case (int)KeyName.Top:
                        lblTopETA.Text = "300";
                        summonerFlashTime.Time[0] = 300;
                        break;

                    case (int)KeyName.Jg:
                        lblJgETA.Text = "300";
                        summonerFlashTime.Time[1] = 300;
                        break;

                    case (int)KeyName.Mid:
                        lblMidETA.Text = "300";
                        summonerFlashTime.Time[2] = 300;
                        break;

                    case (int)KeyName.Adc:
                        lblAdcETA.Text = "300";
                        summonerFlashTime.Time[3] = 300;
                        break;

                    case (int)KeyName.Sup:
                        lblSupETA.Text = "300";
                        summonerFlashTime.Time[4] = 300;
                        break;

                    //取消时长
                    case (int)KeyName.Top + 5:
                        lblTopETA.Text = "";
                        summonerFlashTime.Time[0] = 0;
                        break;

                    case (int)KeyName.Jg + 5:
                        lblJgETA.Text = "";
                        summonerFlashTime.Time[1] = 0;
                        break;

                    case (int)KeyName.Mid + 5:
                        lblMidETA.Text = "";
                        summonerFlashTime.Time[2] = 0;
                        break;

                    case (int)KeyName.Adc + 5:
                        lblAdcETA.Text = "";
                        summonerFlashTime.Time[3] = 0;
                        break;

                    case (int)KeyName.Sup + 5:
                        lblSupETA.Text = "";
                        summonerFlashTime.Time[4] = 0;
                        break;

                    case (int)KeyName.Send:
                        OutputTime.KeyTimeToGame(gameTime, summonerFlashTime);
                        break;
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            GlobalShortcutKey.Leave(Handle);
            //SimulateIO.Shutdown();
        }
    }
}
