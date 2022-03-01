namespace BTC_Swingtrade_Simulator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainPannel = new System.Windows.Forms.Panel();
            this.BTCWorthLabel = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.InfoBar = new System.Windows.Forms.Label();
            this.MainPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPannel
            // 
            this.MainPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPannel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPannel.Controls.Add(this.InfoBar);
            this.MainPannel.Controls.Add(this.BTCWorthLabel);
            this.MainPannel.Location = new System.Drawing.Point(1, 26);
            this.MainPannel.Name = "MainPannel";
            this.MainPannel.Size = new System.Drawing.Size(798, 423);
            this.MainPannel.TabIndex = 0;
            // 
            // BTCWorthLabel
            // 
            this.BTCWorthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCWorthLabel.Font = new System.Drawing.Font("Open Sans Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCWorthLabel.Location = new System.Drawing.Point(11, 11);
            this.BTCWorthLabel.Name = "BTCWorthLabel";
            this.BTCWorthLabel.Size = new System.Drawing.Size(776, 91);
            this.BTCWorthLabel.TabIndex = 0;
            this.BTCWorthLabel.Text = "00000.0000$";
            this.BTCWorthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bClose.BackgroundImage = global::BTC_Swingtrade_Simulator.Properties.Resources.CloseIcon_Red;
            this.bClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bClose.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bClose.Location = new System.Drawing.Point(775, 1);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(24, 24);
            this.bClose.TabIndex = 1;
            this.bClose.TabStop = false;
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.bClose_Click);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.Location = new System.Drawing.Point(5, 4);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(193, 19);
            this.lTitle.TabIndex = 2;
            this.lTitle.Text = "Bitcoin Swing Trading Simulator";
            // 
            // InfoBar
            // 
            this.InfoBar.AutoSize = true;
            this.InfoBar.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBar.Location = new System.Drawing.Point(3, 400);
            this.InfoBar.Name = "InfoBar";
            this.InfoBar.Size = new System.Drawing.Size(165, 19);
            this.InfoBar.TabIndex = 3;
            this.InfoBar.Text = "Init, retrieving bitcoin value";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.MainPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Trading Bot Emulator";
            this.MainPannel.ResumeLayout(false);
            this.MainPannel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel MainPannel;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label BTCWorthLabel;
        private System.Windows.Forms.Label InfoBar;
    }
}

