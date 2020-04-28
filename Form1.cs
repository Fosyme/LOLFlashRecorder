using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace LOLFlashRecorder
{
    public partial class Form1 : Form
    {
        private string pattern;
        private string gameName;
        private GameTime gameTime;
        private SummonerFlashTime summonerFlashTime;
        private OutputTime outputTime;
        private KeyboardHook hook;
        private ShowMsgOnTop smot;

        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);
        bool beginMove = false;//初始化鼠标位置
        int currentXPosition;
        int currentYPosition;

        //获取鼠标按下时的位置
        private void loginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                beginMove = true;
                currentXPosition = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标
                currentYPosition = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
            }
        }
        //获取鼠标移动到的位置
        private void loginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove)
            {
                this.Left += MousePosition.X - currentXPosition;//根据鼠标x坐标确定窗体的左边坐标x
                this.Top += MousePosition.Y - currentYPosition;//根据鼠标的y坐标窗体的顶部，即Y坐标
                currentXPosition = MousePosition.X;
                currentYPosition = MousePosition.Y;
            }
        }

        //释放鼠标时的位置
        private void loginForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentXPosition = 0; //设置初始状态
                currentYPosition = 0;
                beginMove = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pattern = @"^\d{1,2}[:：][0-5]?[0-9]$";
            gameName = "League of Legends (TM) Client";

            outputTime = new OutputTime();
            summonerFlashTime = new SummonerFlashTime();
            gameTime = new GameTime();
            hook = new KeyboardHook();

            hook.KeyDownEvent += new KeyEventHandler(hook_KeyDown);
            hook.Start();
        }

        private void hook_KeyDown(object sender, KeyEventArgs e)
        {
            #region 判断按下的键

            if (e.KeyValue == (int)Keys.F1)
            {
                if ((int)Control.ModifierKeys == (int)Keys.Shift)
                {
                    lblTopETA.Text = "";
                    summonerFlashTime.Time[0] = 0;
                }
                else
                {
                    lblTopETA.Text = "300";
                    summonerFlashTime.Time[0] = 300;
                }
            }
            if (e.KeyValue == (int)Keys.F2)
            {
                if ((int)Control.ModifierKeys == (int)Keys.Shift)
                {
                    lblJgETA.Text = "";
                    summonerFlashTime.Time[1] = 0;
                }
                else
                {
                    lblJgETA.Text = "300";
                    summonerFlashTime.Time[1] = 300;
                }
            }
            if (e.KeyValue == (int)Keys.F3)
            {
                if ((int)Control.ModifierKeys == (int)Keys.Shift)
                {
                    lblMidETA.Text = "";
                    summonerFlashTime.Time[2] = 0;
                }
                else
                {
                    lblMidETA.Text = "300";
                    summonerFlashTime.Time[2] = 300;
                }
            }
            if (e.KeyValue == (int)Keys.F4)
            {
                if ((int)Control.ModifierKeys == (int)Keys.Shift)
                {
                    lblAdcETA.Text = "";
                    summonerFlashTime.Time[3] = 0;
                }
                else
                {
                    lblAdcETA.Text = "300";
                    summonerFlashTime.Time[3] = 300;
                }
            }
            if (e.KeyValue == (int)Keys.F5)
            {
                if ((int)Control.ModifierKeys == (int)Keys.Shift)
                {
                    lblSupETA.Text = "";
                    summonerFlashTime.Time[4] = 0;
                }
                else
                {
                    lblSupETA.Text = "300";
                    summonerFlashTime.Time[4] = 300;
                }
            }
            if (e.KeyValue == (int)Keys.F6)
            {
                outputTime.KeyTimeToGame(gameTime, summonerFlashTime);
            }
            if (e.KeyValue == (int)Keys.F7)
            {
                btnStart_Click(sender, e);
            }
            if (e.KeyValue == (int)Keys.F8)
            {
                btnReset_Click(sender, e);
            }

            #endregion
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
            btnStart.ForeColor = Color.OliveDrab;
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
                btnStart.ForeColor = Color.Red;
                if (!Regex.IsMatch(txtGameTime.Text, pattern))
                {
                    lblInputInfo.Visible = true;
                    return;
                }
                string[] nowGameTime = txtGameTime.Text.Split(':', '：');
                gameTime.SetGametime(nowGameTime[0], nowGameTime[1]);
                summonerFlashTime.StartInput(lblTopETA, lblJgETA, lblMidETA, lblAdcETA, lblSupETA);
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                btnStart.Text = "开始";
                btnStart.ForeColor = Color.OliveDrab;
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
            System.Diagnostics.Process.Start(@".\使用方法.txt");
        }

        private void button1_Click(object sender, MouseEventArgs e)
        {
            try
            {
                smot = new ShowMsgOnTop();
                smot.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            hook.Stop();
        }

        private void Form1_Deactivate(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Show();
                ShowInTaskbar = true;
                WindowState = FormWindowState.Normal;
                Activate();
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            Show();
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void about_Click(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否要结束程序？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information,MessageBoxDefaultButton.Button1);
            if (dr == DialogResult.Yes) 
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true; 
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (WindowState != FormWindowState.Minimized)
            {
                Hide();
                ShowInTaskbar = false;
            }
        }
    }
}
