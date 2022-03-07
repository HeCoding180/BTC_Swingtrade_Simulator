using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTC_Swingtrade_Simulator
{
    class MoneyTracker
    {
        public double USD_Balance { private set; get; }
        public double BTC_Worth { private set; get; }
        public double BTC_Balance { private set; get; }
        public double OriginBalance { private set; get; }

        public MoneyTracker(double InitialBalance)
        {
            USD_Balance = InitialBalance;

            OriginBalance = InitialBalance;
        }
        public MoneyTracker(double InitialUSDBalance, double InitialBTCBalance, double InitialBTCWorth)
        {
            USD_Balance = InitialUSDBalance;
            BTC_Balance = InitialBTCBalance;

            OriginBalance = InitialUSDBalance + InitialBTCWorth * InitialBTCBalance;
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
