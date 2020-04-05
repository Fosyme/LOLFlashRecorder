using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
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

        private void button1_Click(object sender, EventArgs e)
        {
            OutputTime.KeyTimeToGame(gameTime, summonerFlashTime);
        }
    }
}
