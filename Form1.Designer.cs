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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.open = new System.Windows.Forms.ToolStripMenuItem();
            this.about = new System.Windows.Forms.ToolStripMenuItem();
            this.close = new System.Windows.Forms.ToolStripMenuItem();
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlJg.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.pnlAdc.SuspendLayout();
            this.pnlSup.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "LOL闪现记录器 (LFR)";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open,
            this.about,
            this.close});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 70);
            // 
            // open
            // 
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(100, 22);
            this.open.Text = "打开";
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // about
            // 
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(100, 22);
            this.about.Text = "关于";
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // close
            // 
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(100, 22);
            this.close.Text = "退出";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // lblGameTime
            // 
            this.lblGameTime.AutoSize = true;
            this.lblGameTime.Font = new System.Drawing.Font("方正粗黑宋简体", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGameTime.ForeColor = System.Drawing.Color.Chocolate;
            this.lblGameTime.Location = new System.Drawing.Point(102, 100);
            this.lblGameTime.Name = "lblGameTime";
            this.lblGameTime.Size = new System.Drawing.Size(162, 42);
            this.lblGameTime.TabIndex = 3;
            this.lblGameTime.Text = "游戏时间";
            // 
            // txtGameTime
            // 
            this.txtGameTime.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGameTime.Font = new System.Drawing.Font("Futura Md BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGameTime.Location = new System.Drawing.Point(12, 145);
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
            this.btnStart.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnStart.Font = new System.Drawing.Font("文悦新青年体 (非商业使用) W8", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStart.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnStart.Location = new System.Drawing.Point(12, 228);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(165, 46);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "开始";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnReset.Font = new System.Drawing.Font("文悦新青年体 (非商业使用) W8", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnReset.Location = new System.Drawing.Point(187, 228);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(165, 46);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "重置";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSwitchGame
            // 
            this.btnSwitchGame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSwitchGame.Font = new System.Drawing.Font("黑体", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitchGame.Location = new System.Drawing.Point(80, 576);
            this.btnSwitchGame.Name = "btnSwitchGame";
            this.btnSwitchGame.Size = new System.Drawing.Size(204, 48);
            this.btnSwitchGame.TabIndex = 8;
            this.btnSwitchGame.Text = "切换至游戏";
            this.btnSwitchGame.UseVisualStyleBackColor = false;
            this.btnSwitchGame.Click += new System.EventHandler(this.btnSwitchGame_Click);
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.BackColor = System.Drawing.Color.Teal;
            this.lblLocation.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLocation.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblLocation.Location = new System.Drawing.Point(31, 277);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(42, 16);
            this.lblLocation.TabIndex = 10;
            this.lblLocation.Text = "位置";
            // 
            // lblShortcutKeys
            // 
            this.lblShortcutKeys.AutoSize = true;
            this.lblShortcutKeys.BackColor = System.Drawing.Color.Teal;
            this.lblShortcutKeys.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblShortcutKeys.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblShortcutKeys.Location = new System.Drawing.Point(217, 277);
            this.lblShortcutKeys.Name = "lblShortcutKeys";
            this.lblShortcutKeys.Size = new System.Drawing.Size(93, 16);
            this.lblShortcutKeys.TabIndex = 11;
            this.lblShortcutKeys.Text = "全局快捷键";
            // 
            // lnklblHelpManual
            // 
            this.lnklblHelpManual.ActiveLinkColor = System.Drawing.Color.White;
            this.lnklblHelpManual.AutoSize = true;
            this.lnklblHelpManual.BackColor = System.Drawing.Color.Teal;
            this.lnklblHelpManual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lnklblHelpManual.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lnklblHelpManual.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnklblHelpManual.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lnklblHelpManual.Location = new System.Drawing.Point(127, 627);
            this.lnklblHelpManual.Name = "lnklblHelpManual";
            this.lnklblHelpManual.Size = new System.Drawing.Size(89, 25);
            this.lnklblHelpManual.TabIndex = 13;
            this.lnklblHelpManual.TabStop = true;
            this.lnklblHelpManual.Text = "帮助手册";
            this.lnklblHelpManual.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lnklblHelpManual.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblHelpManual_LinkClicked);
            // 
            // pnlJg
            // 
            this.pnlJg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlJg.Controls.Add(this.lblJgETA);
            this.pnlJg.Controls.Add(this.txtJgShortcutKey);
            this.pnlJg.Controls.Add(this.lblJg);
            this.pnlJg.Location = new System.Drawing.Point(12, 352);
            this.pnlJg.Name = "pnlJg";
            this.pnlJg.Size = new System.Drawing.Size(340, 50);
            this.pnlJg.TabIndex = 14;
            // 
            // lblJgETA
            // 
            this.lblJgETA.AutoSize = true;
            this.lblJgETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJgETA.ForeColor = System.Drawing.Color.Snow;
            this.lblJgETA.Location = new System.Drawing.Point(92, 15);
            this.lblJgETA.Name = "lblJgETA";
            this.lblJgETA.Size = new System.Drawing.Size(0, 22);
            this.lblJgETA.TabIndex = 13;
            // 
            // txtJgShortcutKey
            // 
            this.txtJgShortcutKey.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtJgShortcutKey.Enabled = false;
            this.txtJgShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtJgShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtJgShortcutKey.Name = "txtJgShortcutKey";
            this.txtJgShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtJgShortcutKey.TabIndex = 12;
            this.txtJgShortcutKey.Text = "F2";
            this.txtJgShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblJg
            // 
            this.lblJg.AutoSize = true;
            this.lblJg.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJg.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblJg.Location = new System.Drawing.Point(26, 17);
            this.lblJg.Name = "lblJg";
            this.lblJg.Size = new System.Drawing.Size(25, 17);
            this.lblJg.TabIndex = 7;
            this.lblJg.Text = "JG";
            // 
            // pnlMid
            // 
            this.pnlMid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMid.Controls.Add(this.lblMidETA);
            this.pnlMid.Controls.Add(this.txtMidShortcutKey);
            this.pnlMid.Controls.Add(this.lblMid);
            this.pnlMid.Location = new System.Drawing.Point(12, 408);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(340, 50);
            this.pnlMid.TabIndex = 14;
            // 
            // lblMidETA
            // 
            this.lblMidETA.AutoSize = true;
            this.lblMidETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMidETA.ForeColor = System.Drawing.Color.Snow;
            this.lblMidETA.Location = new System.Drawing.Point(92, 15);
            this.lblMidETA.Name = "lblMidETA";
            this.lblMidETA.Size = new System.Drawing.Size(0, 22);
            this.lblMidETA.TabIndex = 13;
            // 
            // txtMidShortcutKey
            // 
            this.txtMidShortcutKey.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtMidShortcutKey.Enabled = false;
            this.txtMidShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtMidShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtMidShortcutKey.Name = "txtMidShortcutKey";
            this.txtMidShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtMidShortcutKey.TabIndex = 12;
            this.txtMidShortcutKey.Text = "F3";
            this.txtMidShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMid
            // 
            this.lblMid.AutoSize = true;
            this.lblMid.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblMid.Location = new System.Drawing.Point(20, 17);
            this.lblMid.Name = "lblMid";
            this.lblMid.Size = new System.Drawing.Size(39, 17);
            this.lblMid.TabIndex = 7;
            this.lblMid.Text = "MID";
            // 
            // pnlAdc
            // 
            this.pnlAdc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAdc.Controls.Add(this.lblAdcETA);
            this.pnlAdc.Controls.Add(this.txtAdcShortcutKey);
            this.pnlAdc.Controls.Add(this.lblAdc);
            this.pnlAdc.Location = new System.Drawing.Point(12, 464);
            this.pnlAdc.Name = "pnlAdc";
            this.pnlAdc.Size = new System.Drawing.Size(340, 50);
            this.pnlAdc.TabIndex = 14;
            // 
            // lblAdcETA
            // 
            this.lblAdcETA.AutoSize = true;
            this.lblAdcETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdcETA.ForeColor = System.Drawing.Color.Snow;
            this.lblAdcETA.Location = new System.Drawing.Point(92, 15);
            this.lblAdcETA.Name = "lblAdcETA";
            this.lblAdcETA.Size = new System.Drawing.Size(0, 22);
            this.lblAdcETA.TabIndex = 13;
            // 
            // txtAdcShortcutKey
            // 
            this.txtAdcShortcutKey.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtAdcShortcutKey.Enabled = false;
            this.txtAdcShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdcShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtAdcShortcutKey.Name = "txtAdcShortcutKey";
            this.txtAdcShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtAdcShortcutKey.TabIndex = 12;
            this.txtAdcShortcutKey.Text = "F4";
            this.txtAdcShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAdc
            // 
            this.lblAdc.AutoSize = true;
            this.lblAdc.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAdc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAdc.Location = new System.Drawing.Point(18, 17);
            this.lblAdc.Name = "lblAdc";
            this.lblAdc.Size = new System.Drawing.Size(40, 17);
            this.lblAdc.TabIndex = 7;
            this.lblAdc.Text = "ADC";
            // 
            // pnlSup
            // 
            this.pnlSup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSup.Controls.Add(this.lblSupETA);
            this.pnlSup.Controls.Add(this.txtSupShortcutKey);
            this.pnlSup.Controls.Add(this.lblSup);
            this.pnlSup.Location = new System.Drawing.Point(12, 520);
            this.pnlSup.Name = "pnlSup";
            this.pnlSup.Size = new System.Drawing.Size(340, 50);
            this.pnlSup.TabIndex = 14;
            // 
            // lblSupETA
            // 
            this.lblSupETA.AutoSize = true;
            this.lblSupETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSupETA.ForeColor = System.Drawing.Color.Snow;
            this.lblSupETA.Location = new System.Drawing.Point(92, 15);
            this.lblSupETA.Name = "lblSupETA";
            this.lblSupETA.Size = new System.Drawing.Size(0, 22);
            this.lblSupETA.TabIndex = 13;
            // 
            // txtSupShortcutKey
            // 
            this.txtSupShortcutKey.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtSupShortcutKey.Enabled = false;
            this.txtSupShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSupShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtSupShortcutKey.Name = "txtSupShortcutKey";
            this.txtSupShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtSupShortcutKey.TabIndex = 12;
            this.txtSupShortcutKey.Text = "F5";
            this.txtSupShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSup
            // 
            this.lblSup.AutoSize = true;
            this.lblSup.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSup.Location = new System.Drawing.Point(18, 17);
            this.lblSup.Name = "lblSup";
            this.lblSup.Size = new System.Drawing.Size(37, 17);
            this.lblSup.TabIndex = 7;
            this.lblSup.Text = "SUP";
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.Font = new System.Drawing.Font("等线", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTop.Location = new System.Drawing.Point(20, 15);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(38, 17);
            this.lblTop.TabIndex = 7;
            this.lblTop.Text = "TOP";
            // 
            // txtTopShortcutKey
            // 
            this.txtTopShortcutKey.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTopShortcutKey.Enabled = false;
            this.txtTopShortcutKey.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTopShortcutKey.Location = new System.Drawing.Point(175, 10);
            this.txtTopShortcutKey.Name = "txtTopShortcutKey";
            this.txtTopShortcutKey.Size = new System.Drawing.Size(152, 29);
            this.txtTopShortcutKey.TabIndex = 12;
            this.txtTopShortcutKey.Text = "F1";
            this.txtTopShortcutKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlTop
            // 
            this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop.Controls.Add(this.lblTopETA);
            this.pnlTop.Controls.Add(this.txtTopShortcutKey);
            this.pnlTop.Controls.Add(this.lblTop);
            this.pnlTop.Location = new System.Drawing.Point(12, 296);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(340, 50);
            this.pnlTop.TabIndex = 14;
            // 
            // lblTopETA
            // 
            this.lblTopETA.AutoSize = true;
            this.lblTopETA.Font = new System.Drawing.Font("造字工房朗倩（非商用）常规体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTopETA.ForeColor = System.Drawing.Color.Snow;
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
            this.btnSetFromTop.BackColor = System.Drawing.Color.OrangeRed;
            this.btnSetFromTop.Location = new System.Drawing.Point(290, 52);
            this.btnSetFromTop.Name = "btnSetFromTop";
            this.btnSetFromTop.Size = new System.Drawing.Size(62, 45);
            this.btnSetFromTop.TabIndex = 15;
            this.btnSetFromTop.Text = "置顶";
            this.btnSetFromTop.UseVisualStyleBackColor = false;
            this.btnSetFromTop.Click += new System.EventHandler(this.btnSetFromTop_Click);
            // 
            // lblInputInfo
            // 
            this.lblInputInfo.AutoSize = true;
            this.lblInputInfo.ForeColor = System.Drawing.Color.Crimson;
            this.lblInputInfo.Location = new System.Drawing.Point(151, 213);
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
            this.lblDelay.BackColor = System.Drawing.Color.Teal;
            this.lblDelay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDelay.ForeColor = System.Drawing.Color.Cornsilk;
            this.lblDelay.Location = new System.Drawing.Point(91, 277);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(76, 16);
            this.lblDelay.TabIndex = 11;
            this.lblDelay.Text = "剩余时间";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(300, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 39);
            this.button1.TabIndex = 17;
            this.button1.Text = "测试\r\n按钮";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(40, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(196, 23);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "LOL Flash Recorder";
            // 
            // picLogo
            // 
            this.picLogo.Image = global::LOLFlashRecorder.Properties.Resources.logo;
            this.picLogo.Location = new System.Drawing.Point(2, 2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(32, 32);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogo.TabIndex = 18;
            this.picLogo.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 45);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Teal;
            this.btnClose.BackgroundImage = global::LOLFlashRecorder.Properties.Resources.资源_2;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(329, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(32, 32);
            this.btnClose.TabIndex = 20;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::LOLFlashRecorder.Properties.Resources.资源_1;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(291, 2);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(32, 32);
            this.btnMin.TabIndex = 20;
            this.btnMin.UseVisualStyleBackColor = false;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(364, 661);
            this.Controls.Add(this.btnMin);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picLogo);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOL Flash Recorder";
            this.Deactivate += new System.EventHandler(this.Form1_Deactivate);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            this.contextMenuStrip1.ResumeLayout(false);
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
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem open;
        private System.Windows.Forms.ToolStripMenuItem about;
        private System.Windows.Forms.ToolStripMenuItem close;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
    }
}

