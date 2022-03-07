using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTC_Swingtrade_Simulator
{
    public partial class Form1 : Form
    {
        public readonly Color DEFAULT_BACKCOLOR = Color.FromArgb(58, 64, 79);
        public readonly Color LIGHT_BACKCOLOR = Color.FromArgb(86, 90, 112);

        public readonly Color DEFAULT_FORECOLOR = Color.FromArgb(40, 121, 235);

        public readonly Color NEGATIVE_COURSE_COLOR = Color.FromArgb(255, 0, 0);
        public readonly Color POSITIVE_COURSE_COLOR = Color.FromArgb(43, 255, 0);

        bool BTC_InitValue = true;

        MoneyTracker moneyTracker;
        ReadBTC_Value BTCReader;
        TradingBot tradingBot;
        InfoLabelHandler infoLabelHandler;

        public Form1()
        {
            InitializeComponent();

            using (Font checkFont = new Font("Open Sans Light", 9.75f, FontStyle.Regular, GraphicsUnit.Point))
            {
                if (checkFont.Name != "Open Sans Light")
                {
                    Process fontview_exe = Process.Start(Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\Resources\Fonts\OpenSans-Light.ttf"));

                    while (fontview_exe.HasExited == false) ;

                    Application.Restart();
                }
            }

            BTCReader = new ReadBTC_Value();
            moneyTracker = new MoneyTracker(10);
            tradingBot = new TradingBot(ref moneyTracker, 5, 2);
            infoLabelHandler = new InfoLabelHandler(5000);
            BTCReader.NewBTCValueAvailable += BTC_Tracker_NewBTCValueAvailable;
            tradingBot.TradeOccurred += TradingBot_TradeOccurred;
            infoLabelHandler.InfoLabelUpdate += InfoLabelHandler_InfoLabelUpdate;

            this.BackColor = DEFAULT_BACKCOLOR;
            MainPannel.BackColor = LIGHT_BACKCOLOR;

            lTitle.ForeColor = LIGHT_BACKCOLOR;

            BTCWorthLabel.ForeColor = DEFAULT_FORECOLOR;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BTCReader.Start();
        }
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }

        private void BTC_Tracker_NewBTCValueAvailable(object sender, BTCEventArgs e)
        {
            BTCWorthLabel.Text = e.BTCValue.ToString() + "$";

            if (e.BTCPercentageChange >= 0)
            {
                BTCWorthChangeLabel.Text = "+" + e.BTCPercentageChange.ToString() + "%";
                BTCWorthChangeLabel.ForeColor = POSITIVE_COURSE_COLOR;
            }
            else
            {
                BTCWorthChangeLabel.Text = e.BTCPercentageChange.ToString() + "%";
                BTCWorthChangeLabel.ForeColor = NEGATIVE_COURSE_COLOR;
            }

            moneyTracker.BTC_Worth = e.BTCValue;
            tradingBot.UpdateChangeList(e.BTCPercentageChange, ref moneyTracker);

            if(BTC_InitValue)
            {
                BTC_InitValue = false;
                moneyTracker.BuyInUSD(0.5f * moneyTracker.USD_Balance);
            }

            lUSDBal.Text = "USD: " + moneyTracker.USD_Balance.ToString() + "$";
            lBTCBal.Text = "BTC: " + moneyTracker.BTC_Balance.ToString();
        }
        private void TradingBot_TradeOccurred(object sender, TradingResultEventArgs e)
        {
            switch(e.TradeDirection)
            {
                case TradingDirection.Buy:
                    if (e.Amount != 0) infoLabelHandler.setInfo(e.Amount + " USD were traded into BTC");
                    else infoLabelHandler.setInfo("Insufficient Funds to Buy BTC");
                    break;
                case TradingDirection.Sell:
                    if (e.Amount != 0) infoLabelHandler.setInfo(e.Amount + " BTC were traded into USD");
                    else infoLabelHandler.setInfo("Insufficient Funds to Sell BTC");
                    break;
                case TradingDirection.Cooldown:
                    infoLabelHandler.setInfo("Bot on cooldown for another " + e.Amount + " minutes");
                    break;
            }
        }
        private void InfoLabelHandler_InfoLabelUpdate(object sender, InfoLabelEventArgs e)
        {
            InfoBar.Text = e.InfoLabelText;
        }
    }
}
