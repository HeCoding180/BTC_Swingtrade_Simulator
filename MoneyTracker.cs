using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTC_Swingtrade_Simulator
{
    class MoneyTracker
    {
        public double USD_Balance { set; get; }
        public double BTC_Worth { set; get; }
        public double BTC_Balance { set; get; }

        public MoneyTracker(double InitialBalance)
        {
            USD_Balance = InitialBalance;
        }

        public void BTC_Tracker_NewBTCValueAvailable(object sender, BTCEventArgs e)
        {
            BTC_Worth = e.BTCValue;
        }

        public void BuyInBTC(double Amount)
        {
            USD_Balance -= BTC_Worth * Amount;
            BTC_Balance += Amount;
        }
        public void BuyInUSD(double Amount)
        {
            BTC_Balance += Amount / BTC_Worth;
            USD_Balance -= Amount;
        }
        public void SellInBTC(double Amount)
        {
            USD_Balance += BTC_Worth * Amount;
            BTC_Balance -= Amount;
        }
        public void SellInUSD(double Amount)
        {
            BTC_Balance -= Amount / BTC_Worth;
            USD_Balance += Amount;
        }
    }
}
