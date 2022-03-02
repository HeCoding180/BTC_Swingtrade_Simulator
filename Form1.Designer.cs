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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPannel = new System.Windows.Forms.Panel();
            this.lBTCBal = new System.Windows.Forms.Label();
            this.lUSDBal = new System.Windows.Forms.Label();
            this.lBalances = new System.Windows.Forms.Label();
            this.BTCWorthChangeLabel = new System.Windows.Forms.Label();
            this.InfoBar = new System.Windows.Forms.Label();
            this.BTCWorthLabel = new System.Windows.Forms.Label();
            this.bClose = new System.Windows.Forms.Button();
            this.lTitle = new System.Windows.Forms.Label();
            this.MainPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPannel
            // 
            this.MainPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPannel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.MainPannel.Controls.Add(this.lBTCBal);
            this.MainPannel.Controls.Add(this.lUSDBal);
            this.MainPannel.Controls.Add(this.lBalances);
            this.MainPannel.Controls.Add(this.BTCWorthChangeLabel);
            this.MainPannel.Controls.Add(this.InfoBar);
            this.MainPannel.Controls.Add(this.BTCWorthLabel);
            this.MainPannel.Location = new System.Drawing.Point(1, 26);
            this.MainPannel.Name = "MainPannel";
            this.MainPannel.Size = new System.Drawing.Size(798, 273);
            this.MainPannel.TabIndex = 0;
            // 
            // lBTCBal
            // 
            this.lBTCBal.AutoSize = true;
            this.lBTCBal.Font = new System.Drawing.Font("Open Sans Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBTCBal.Location = new System.Drawing.Point(11, 192);
            this.lBTCBal.Name = "lBTCBal";
            this.lBTCBal.Size = new System.Drawing.Size(176, 42);
            this.lBTCBal.TabIndex = 7;
            this.lBTCBal.Text = "BTC: 0.0011";
            this.lBTCBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lUSDBal
            // 
            this.lUSDBal.AutoSize = true;
            this.lUSDBal.Font = new System.Drawing.Font("Open Sans Light", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUSDBal.Location = new System.Drawing.Point(11, 150);
            this.lUSDBal.Name = "lUSDBal";
            this.lUSDBal.Size = new System.Drawing.Size(165, 42);
            this.lUSDBal.TabIndex = 6;
            this.lUSDBal.Text = "USD: 50.0$";
            this.lUSDBal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lBalances
            // 
            this.lBalances.AutoSize = true;
            this.lBalances.Font = new System.Drawing.Font("Open Sans Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBalances.Location = new System.Drawing.Point(11, 119);
            this.lBalances.Name = "lBalances";
            this.lBalances.Size = new System.Drawing.Size(168, 31);
            this.lBalances.TabIndex = 5;
            this.lBalances.Text = "Virtual Balances:";
            this.lBalances.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BTCWorthChangeLabel
            // 
            this.BTCWorthChangeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BTCWorthChangeLabel.Font = new System.Drawing.Font("Open Sans Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTCWorthChangeLabel.Location = new System.Drawing.Point(11, 96);
            this.BTCWorthChangeLabel.Name = "BTCWorthChangeLabel";
            this.BTCWorthChangeLabel.Size = new System.Drawing.Size(753, 23);
            this.BTCWorthChangeLabel.TabIndex = 4;
            this.BTCWorthChangeLabel.Text = "+0.00%";
            this.BTCWorthChangeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // InfoBar
            // 
            this.InfoBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.InfoBar.AutoSize = true;
            this.InfoBar.Font = new System.Drawing.Font("Open Sans Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoBar.Location = new System.Drawing.Point(3, 250);
            this.InfoBar.Name = "InfoBar";
            this.InfoBar.Size = new System.Drawing.Size(165, 19);
            this.InfoBar.TabIndex = 3;
            this.InfoBar.Text = "Init, retrieving bitcoin value";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 300);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.MainPannel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Trading Bot Emulator";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label BTCWorthChangeLabel;
        private System.Windows.Forms.Label lBalances;
        private System.Windows.Forms.Label lBTCBal;
        private System.Windows.Forms.Label lUSDBal;
    }
}

