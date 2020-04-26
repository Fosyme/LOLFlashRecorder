namespace LOLFlashRecorder
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblGameTime = new System.Windows.Forms.Label();
            this.txtGameTime = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSwitchGame = new System.Windows.Forms.Button();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblShortcutKeys = new System.Windows.Forms.Label();
            this.lnklblHelpManual = new System.Windows.Forms.LinkLabel();
            this.pnlJg = new System.Windows.Forms.Panel();
            this.lblJgETA = new System.Windows.Forms.Label();
            this.txtJgShortcutKey = new System.Windows.Forms.TextBox();
            this.lblJg = new System.Windows.Forms.Label();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.lblMidETA = new System.Windows.Forms.Label();
            this.txtMidShortcutKey = new System.Windows.Forms.TextBox();
            this.lblMid = new System.Windows.Forms.Label();
            this.pnlAdc = new System.Windows.Forms.Panel();
            this.lblAdcETA = new System.Windows.Forms.Label();
            this.txtAdcShortcutKey = new System.Windows.Forms.TextBox();
            this.lblAdc = new System.Windows.Forms.Label();
            this.pnlSup = new System.Windows.Forms.Panel();
            this.lblSupETA = new System.Windows.Forms.Label();
            this.txtSupShortcutKey = new System.Windows.Forms.TextBox();
            this.lblSup = new System.Windows.Forms.Label();
            this.lblTop = new System.Windows.Forms.Label();
            this.txtTopShortcutKey = new System.Windows.Forms.TextBox();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTopETA = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnSetFromTop = new System.Windows.Forms.Button();
            this.lblInputInfo = new System.Windows.Forms.Label();
            this.lblDelay = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnlJg.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.pnlAdc.SuspendLayout();
            this.pnlSup.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LOL Flash Recorder";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // lblGameTime
            // 
            this.lblGameTime.AutoSize = true;
            this.lblGameTime.Font = new System.Drawing.Font("黑体", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGameTime.Location = new System.Drawing.Point(102, 60);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(159, 35);
            this.lblGameTime.TabIndex = 3;
            this.lblGameTime.Text = "游戏时间";
            // 
            // txtGameTime
            // 
            this.txtGameTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGameTime.Font = new System.Drawing.Font("Futura Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameTime.Location = new System.Drawing.Point(12, 98);
            this.txtGameTime.Name = "txtGameTime";
            this.txtGameTime.Size = new System.Drawing.Size(340, 65);
            this.txtGameTime.TabIndex = 4;
            this.txtGameTime.Text = "00:00";
            this.txtGameTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtGameTime.WordWrap = false;
            this.txtGameTime.TextChanged += new System.EventHandler(this.txtGameTime_TextChanged);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.Location = new System.Drawing.Point(12, 181);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 46);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("宋体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.Location = new System.Drawing.Point(187, 181);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 46);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSwitchGame
            // 
            this.btnSwitchGame.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitchGame.Location = new System.Drawing.Point(80, 542);
            this.btnSwitchGame.Name = "btnSwitchGame";
            this.btnSwitchGame.Size = new System.Drawing.Size(204, 48);
            this.btnSwitchGame.TabIndex = 8;
            this.btnSwitchGame.Text = "切换至游戏";
            this.btnSwitchGame.UseVisualStyleBackColor = true;
            this.btnSwitchGame.Click += new System.EventHandler(this.btnSwitchGame_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLocation.Location = new System.Drawing.Point(32, 243);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(42, 16);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "位置";
            // 
            // lblShortcutKeys
            // 
            this.lblShortcutKeys.AutoSize = true;
            this.lblShortcutKeys.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShortcutKeys.Location = new System.Drawing.Point(218, 243);
            this.lblShortcutKeys.Name = "lblShortcutKeys";
            this.lblShortcutKeys.Size = new System.Drawing.Size(93, 16);
            this.lblShortcutKeys.TabIndex = 11;
            this.lblShortcutKeys.Text = "全局快捷键";
            // 
            // lnklblHelpManual
            // 
            this.lnklblHelpManual.AutoSize = true;
            this.lnklblHelpManual.Location = new System.Drawing.Point(156, 593);
            this.lnklblHelpManual.Name = "lnklblHelpManual";
            this.lnklblHelpManual.Size = new System.Drawing.Size(53, 12);
            this.lnklblHelpManual.TabIndex = 13;
            this.lnklblHelpManual.TabStop = true;
            this.lnklblHelpManual.Text = "帮助手册";
            this.lnklblHelpManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblHelpManual_LinkClicked);
            // 
            // pnlJg
            // 
            this.pnlJg.Controls.Add(this.lblJgETA);
            this.pnlJg.Controls.Add(this.txtJgShortcutKey);
            this.pnlJg.Controls.Add(this.lblJg);
            this.pnlJg.Location = new System.Drawing.Point(12, 318);
            this.pnlJg.Name = "pnlJg";
            this.pnlJg.Size = new System.Drawing.Size(340, 50);
            this.pnlJg.TabIndex = 14;
            // 
            // lblJgETA
            // 
            this.lblJgETA.AutoSize = true;
            this.lblJgETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJgETA.Location = new System.Drawing.Point(92, 15);
            this.lblJgETA.Name = "lblJgETA";
            this.lblJgETA.Size = new System.Drawing.Size(0, 22);
            this.lblJgETA.TabIndex = 13;
            // 
            // txtJgShortcutKey
            // 
            this.txtJgShortcutKey.Enabled = false;
            this.txtJgShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJgShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtJgShortcutKey.Name = "txtJgShortcutKey";
            this.txtJgShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtJgShortcutKey.TabIndex = 12;
            this.txtJgShortcutKey.Text = "F2";
            this.txtJgShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJgShortcutKey.TextChanged += new System.EventHandler(this.txtJgShortcutKey_TextChanged);
            // 
            // lblJg
            // 
            this.lblJg.AutoSize = true;
            this.lblJg.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJg.Location = new System.Drawing.Point(26, 17);
            this.lblJg.Name = "lblJg";
            this.lblJg.Size = new System.Drawing.Size(24, 17);
            this.lblJg.TabIndex = 7;
            this.lblJg.Text = "JG";
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.lblMidETA);
            this.pnlMid.Controls.Add(this.txtMidShortcutKey);
            this.pnlMid.Controls.Add(this.lblMid);
            this.pnlMid.Location = new System.Drawing.Point(12, 374);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(340, 50);
            this.pnlMid.TabIndex = 14;
            // 
            // lblMidETA
            // 
            this.lblMidETA.AutoSize = true;
            this.lblMidETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMidETA.Location = new System.Drawing.Point(92, 15);
            this.lblMidETA.Name = "lblMidETA";
            this.lblMidETA.Size = new System.Drawing.Size(0, 22);
            this.lblMidETA.TabIndex = 13;
            // 
            // txtMidShortcutKey
            // 
            this.txtMidShortcutKey.Enabled = false;
            this.txtMidShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMidShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtMidShortcutKey.Name = "txtMidShortcutKey";
            this.txtMidShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtMidShortcutKey.TabIndex = 12;
            this.txtMidShortcutKey.Text = "F3";
            this.txtMidShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMidShortcutKey.TextChanged += new System.EventHandler(this.txtMidShortcutKey_TextChanged);
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMid.Location = new System.Drawing.Point(20, 17);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(37, 17);
            this.lblMid.TabIndex = 7;
            this.lblMid.Text = "MID";
            // 
            // pnlAdc
            // 
            this.pnlAdc.Controls.Add(this.lblAdcETA);
            this.pnlAdc.Controls.Add(this.txtAdcShortcutKey);
            this.pnlAdc.Controls.Add(this.lblAdc);
            this.pnlAdc.Location = new System.Drawing.Point(12, 430);
            this.pnlAdc.Name = "pnlAdc";
            this.pnlAdc.Size = new System.Drawing.Size(340, 50);
            this.pnlAdc.TabIndex = 14;
            // 
            // lblAdcETA
            // 
            this.lblAdcETA.AutoSize = true;
            this.lblAdcETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdcETA.Location = new System.Drawing.Point(92, 15);
            this.lblAdcETA.Name = "lblAdcETA";
            this.lblAdcETA.Size = new System.Drawing.Size(0, 22);
            this.lblAdcETA.TabIndex = 13;
            // 
            // txtAdcShortcutKey
            // 
            this.txtAdcShortcutKey.Enabled = false;
            this.txtAdcShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdcShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtAdcShortcutKey.Name = "txtAdcShortcutKey";
            this.txtAdcShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtAdcShortcutKey.TabIndex = 12;
            this.txtAdcShortcutKey.Text = "F4";
            this.txtAdcShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdcShortcutKey.TextChanged += new System.EventHandler(this.txtAdcShortcutKey_TextChanged);
            // 
            // lblAdc
            // 
            this.lblAdc.AutoSize = true;
            this.lblAdc.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdc.Location = new System.Drawing.Point(18, 17);
            this.lblAdc.Name = "lblAdc";
            this.lblAdc.Size = new System.Drawing.Size(39, 17);
            this.lblAdc.TabIndex = 7;
            this.lblAdc.Text = "ADC";
            // 
            // pnlSup
            // 
            this.pnlSup.Controls.Add(this.lblSupETA);
            this.pnlSup.Controls.Add(this.txtSupShortcutKey);
            this.pnlSup.Controls.Add(this.lblSup);
            this.pnlSup.Location = new System.Drawing.Point(12, 486);
            this.pnlSup.Name = "pnlSup";
            this.pnlSup.Size = new System.Drawing.Size(340, 50);
            this.pnlSup.TabIndex = 14;
            // 
            // lblSupETA
            // 
            this.lblSupETA.AutoSize = true;
            this.lblSupETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSupETA.Location = new System.Drawing.Point(92, 15);
            this.lblSupETA.Name = "lblSupETA";
            this.lblSupETA.Size = new System.Drawing.Size(0, 22);
            this.lblSupETA.TabIndex = 13;
            // 
            // txtSupShortcutKey
            // 
            this.txtSupShortcutKey.Enabled = false;
            this.txtSupShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSupShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtSupShortcutKey.Name = "txtSupShortcutKey";
            this.txtSupShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtSupShortcutKey.TabIndex = 12;
            this.txtSupShortcutKey.Text = "F5";
            this.txtSupShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSupShortcutKey.TextChanged += new System.EventHandler(this.txtSupShortcutKey_TextChanged);
            // 
            // lblSup
            // 
            this.lblSup.AutoSize = true;
            this.lblSup.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSup.Location = new System.Drawing.Point(18, 17);
            this.lblSup.Name = "lblSup";
            this.lblSup.Size = new System.Drawing.Size(36, 17);
            this.lblSup.TabIndex = 7;
            this.lblSup.Text = "SUP";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTop.Location = new System.Drawing.Point(20, 17);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(37, 17);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "TOP";
            // 
            // txtTopShortcutKey
            // 
            this.txtTopShortcutKey.Enabled = false;
            this.txtTopShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTopShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtTopShortcutKey.Name = "txtTopShortcutKey";
            this.txtTopShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtTopShortcutKey.TabIndex = 12;
            this.txtTopShortcutKey.Text = "F1";
            this.txtTopShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTopShortcutKey.TextChanged += new System.EventHandler(this.txtTopShortcutKey_TextChanged);
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.lblTopETA);
            this.pnlTop.Controls.Add(this.txtTopShortcutKey);
            this.pnlTop.Controls.Add(this.lblTop);
            this.pnlTop.Location = new System.Drawing.Point(12, 262);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(340, 50);
            this.pnlTop.TabIndex = 14;
            // 
            // lblTopETA
            // 
            this.lblTopETA.AutoSize = true;
            this.lblTopETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTopETA.Location = new System.Drawing.Point(92, 15);
            this.lblTopETA.Name = "lblTopETA";
            this.lblTopETA.Size = new System.Drawing.Size(0, 22);
            this.lblTopETA.TabIndex = 13;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnSetFromTop
            // 
            this.btnSetFromTop.Location = new System.Drawing.Point(290, 12);
            this.btnSetFromTop.Name = "btnSetFromTop";
            this.btnSetFromTop.Size = new System.Drawing.Size(62, 45);
            this.btnSetFromTop.TabIndex = 15;
            this.btnSetFromTop.Text = "置顶";
            this.btnSetFromTop.UseVisualStyleBackColor = true;
            this.btnSetFromTop.Click += new System.EventHandler(this.btnSetFromTop_Click);
            // 
            // lblInputInfo
            // 
            this.lblInputInfo.AutoSize = true;
            this.lblInputInfo.Location = new System.Drawing.Point(151, 166);
            this.lblInputInfo.Name = "lblInputInfo";
            this.lblInputInfo.Size = new System.Drawing.Size(65, 12);
            this.lblInputInfo.TabIndex = 16;
            this.lblInputInfo.Text = "输入不正确";
            this.lblInputInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblInputInfo.Visible = false;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDelay.Location = new System.Drawing.Point(92, 243);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(76, 16);
            this.lblDelay.TabIndex = 11;
            this.lblDelay.Text = "剩余时间";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 542);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "测试\r\n按钮";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(364, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblInputInfo);
            this.Controls.Add(this.btnSetFromTop);
            this.Controls.Add(this.pnlSup);
            this.Controls.Add(this.pnlAdc);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.pnlJg);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.lnklblHelpManual);
            this.Controls.Add(this.lblShortcutKeys);
            this.Controls.Add(this.lblDelay);
            this.Controls.Add(this.lblLocation);
            this.Controls.Add(this.btnSwitchGame);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.txtGameTime);
            this.Controls.Add(this.lblGameTime);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOL闪现记录器 - LOL Flash Recorder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnlJg.ResumeLayout(false);
            this.pnlJg.PerformLayout();
            this.pnlMid.ResumeLayout(false);
            this.pnlMid.PerformLayout();
            this.pnlAdc.ResumeLayout(false);
            this.pnlAdc.PerformLayout();
            this.pnlSup.ResumeLayout(false);
            this.pnlSup.PerformLayout();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblGameTime;
        private System.Windows.Forms.TextBox txtGameTime;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSwitchGame;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblShortcutKeys;
        private System.Windows.Forms.LinkLabel lnklblHelpManual;
        private System.Windows.Forms.Panel pnlJg;
        private System.Windows.Forms.Label lblJg;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.TextBox txtMidShortcutKey;
        private System.Windows.Forms.Label lblMid;
        private System.Windows.Forms.Panel pnlAdc;
        private System.Windows.Forms.TextBox txtAdcShortcutKey;
        private System.Windows.Forms.Label lblAdc;
        private System.Windows.Forms.Panel pnlSup;
        private System.Windows.Forms.TextBox txtSupShortcutKey;
        private System.Windows.Forms.Label lblSup;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.TextBox txtTopShortcutKey;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnSetFromTop;
        private System.Windows.Forms.Label lblInputInfo;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.Label lblJgETA;
        private System.Windows.Forms.TextBox txtJgShortcutKey;
        private System.Windows.Forms.Label lblMidETA;
        private System.Windows.Forms.Label lblAdcETA;
        private System.Windows.Forms.Label lblSupETA;
        private System.Windows.Forms.Label lblTopETA;
        private System.Windows.Forms.Button button1;
    }
}

