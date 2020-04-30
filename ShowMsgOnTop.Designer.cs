namespace LOLFlashRecorder
{
    partial class ShowMsgOnTop
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMsgTemp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMsgTemp
            // 
            this.lblMsgTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMsgTemp.Font = new System.Drawing.Font("JetBrains Mono", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMsgTemp.Location = new System.Drawing.Point(0, 0);
            this.lblMsgTemp.Margin = new System.Windows.Forms.Padding(0);
            this.lblMsgTemp.Name = "lblMsgTemp";
            this.lblMsgTemp.Size = new System.Drawing.Size(250, 350);
            this.lblMsgTemp.TabIndex = 0;
            this.lblMsgTemp.Text = "游戏时间\r\n10:10\r\nTop 52 \r\n Jg 10 \r\nMid 100\r\nAdc 12 \r\nSup 1  \r\n";
            this.lblMsgTemp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ShowMsgOnTop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.ControlBox = false;
            this.Controls.Add(this.lblMsgTemp);
            this.Enabled = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ShowMsgOnTop";
            this.Opacity = 0.4D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ShowMsgOnTop";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblMsgTemp;
    }
}