using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace BTC_Swingtrade_Simulator
{
    public class BTCEventArgs : EventArgs
    {
        public double BTCValue { set; get; }
        public double BTCValuePrev { set; get; }
        public double BTCChange { set; get; }
        public double BTCPercentageChange { set; get; }
    }

    class ReadBTC_Value
    {
        private Timer OneSecTimer = new Timer();

        public event EventHandler<BTCEventArgs> NewBTCValueAvailable;

        private bool FirstCycle = true;
        private double PreviousBTCValue = 0.0f;

        public ReadBTC_Value()
        {
            OneSecTimer.Interval = 1000; //ms
            OneSecTimer.Tick += OneSecTimer_Tick;
        }

        public void Start()
        {
            readBTCValue();
            FirstCycle = true;
            OneSecTimer.Start();
        }
        public void Stop()
        {
            OneSecTimer.Stop();
        }
        private void OneSecTimer_Tick(object sender, EventArgs e)
        {
            readBTCValue();
        }
        protected virtual void NewBTC_Value_Availalble(BTCEventArgs e)
        {
            EventHandler<BTCEventArgs> handler = NewBTCValueAvailable;
            handler(this, e);
        }

        public void readBTCValue()
        {
            dynamic BTCJson;
            using (WebClient wc = new WebClient())
            {
                BTCJson = JObject.Parse(wc.DownloadString("https://api.coindesk.com/v1/bpi/currentprice.json"));
            }

            string BTCRateUSD = (BTCJson.bpi.USD.rate).ToString();
            BTCRateUSD = BTCRateUSD.Replace(",", string.Empty);

            BTCEventArgs _BTCEventArgs = new BTCEventArgs();
            //Try both '.' and ',' for parsing, since decimal points may vary in different environments
            try
            {
                _BTCEventArgs.BTCValue = double.Parse(BTCRateUSD);
            }
            catch(Exception)
            {
                BTCRateUSD = BTCRateUSD.Replace('.', ',');
                _BTCEventArgs.BTCValue = double.Parse(BTCRateUSD);
            }

            if (_BTCEventArgs.BTCValue != PreviousBTCValue)
            {
                if (FirstCycle)
                    _BTCEventArgs.BTCChange = 0.0f;
                else
                    _BTCEventArgs.BTCChange = _BTCEventArgs.BTCValue - PreviousBTCValue;

                FirstCycle = false;
                _BTCEventArgs.BTCValuePrev = PreviousBTCValue;
                _BTCEventArgs.BTCPercentageChange = _BTCEventArgs.BTCValue / _BTCEventArgs.BTCValuePrev - 1;
                PreviousBTCValue = double.Parse(BTCRateUSD);
                NewBTC_Value_Availalble(_BTCEventArgs);
            }
        }
    }
}
