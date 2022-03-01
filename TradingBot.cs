using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTC_Swingtrade_Simulator
{
    class TradingBot
    {
        public int LongIntegralCount { private set; get; }
        public int ShortIntegralCount { private set; get; }

        private double[] LongIntegralList;
        private double[] ShortIntegralList;

        public double LongIntegral { private set; get; }
        public double ShortIntegral { private set; get; }

        public TradingBot(ref MoneyTracker BalanceTracker, int nLongIntegral, int nShortIntegral)
        {
            if (nLongIntegral <= nShortIntegral) throw new InvalidOperationException("the Long Integral Count must be higher than the Low Integral Count");

            LongIntegralList = new double[nLongIntegral];
            ShortIntegralList = new double[nShortIntegral];
        }

        private void ProcessIntegralLists()
        {
            throw new NotImplementedException();
        }
    }
}
