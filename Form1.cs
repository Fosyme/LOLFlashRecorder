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
            gameName = "League of Legends";
            GlobalShortcutKey.RegDefault(Handle);
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
            lblTopETA.Text = "20";
            lblJgETA.Text = "20";
            lblMidETA.Text = "20";
            lblAdcETA.Text = "20";
            lblSupETA.Text = "20";
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
                summonerFlashTime = new SummonerFlashTime
                    (lblTopETA.Text, lblJgETA.Text, lblMidETA.Text, lblAdcETA.Text, lblSupETA.Text);
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
            #region 解决一个问题

            /// <summary>
            /// 关于 Click(EventArgs) 事件和 MouseClick(MouseEventArgs) 事件的区别和影响
            /// </summary>
            /// 
            #endregion

            if (SwitchWindow.SwitchWindowFromQTE("notepad")) //舍弃将会造成输入持续进行
            {
                //OutputTime.Click();
            }
            OutputTime.KeyTimeToGame(gameTime, summonerFlashTime);
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


        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;
            //按快捷键 
            switch (m.Msg)
            {
                case WM_HOTKEY:
                    switch (m.WParam.ToInt32())
                    {
                        case (int)KeyName.Top:    //按下的是Shift+S
                                                  //此处填写快捷键响应代码         
                            break;

                        case (int)KeyName.Jg:     //按下的是Ctrl+B
                                                  //此处填写快捷键响应代码
                            break;

                        case (int)KeyName.Mid:    //按下的是Alt+D
                                     //此处填写快捷键响应代码
                            break;

                        case (int)KeyName.Adc:

                            break;

                        case (int)KeyName.Sup:

                            break;
                    }
                    break;
            }
            base.WndProc(ref m);
        }
    }
}
