namespace Stack
{
    partial class Alert
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.closeBtn = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.messageInfo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.fadeIn = new System.Windows.Forms.Timer(this.components);
            this.fadeOut = new System.Windows.Forms.Timer(this.components);
            this.timeOut = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(301, 4);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 21);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // messageInfo
            // 
            this.messageInfo.AutoSize = true;
            this.messageInfo.BackColor = System.Drawing.Color.Transparent;
            this.messageInfo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.messageInfo.ForeColor = System.Drawing.Color.White;
            this.messageInfo.Location = new System.Drawing.Point(64, 35);
            this.messageInfo.Name = "messageInfo";
            this.messageInfo.Size = new System.Drawing.Size(101, 24);
            this.messageInfo.TabIndex = 1;
            this.messageInfo.Text = "Message";
            // 
            // fadeIn
            // 
            this.fadeIn.Interval = 25;
            this.fadeIn.Tick += new System.EventHandler(this.FadeIn_Tick);
            // 
            // fadeOut
            // 
            this.fadeOut.Interval = 25;
            this.fadeOut.Tick += new System.EventHandler(this.FadeOut_Tick);
            // 
            // timeOut
            // 
            this.timeOut.Enabled = true;
            this.timeOut.Interval = 3000;
            this.timeOut.Tick += new System.EventHandler(this.TimeOut_Tick);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.ClientSize = new System.Drawing.Size(325, 92);
            this.Controls.Add(this.messageInfo);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alert";
            this.Opacity = 0D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Alert";
            this.Load += new System.EventHandler(this.Alert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuCustomLabel closeBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel messageInfo;
        private System.Windows.Forms.Timer fadeIn;
        private System.Windows.Forms.Timer fadeOut;
        private System.Windows.Forms.Timer timeOut;
    }
}