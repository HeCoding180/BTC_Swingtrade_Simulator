using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTC_Swingtrade_Simulator
{
    public enum TradingDirection
    {
        Buy,
        Sell,
        Cooldown
    }

    public class TradingResultEventArgs : EventArgs
    {
        public TradingDirection TradeDirection { set; get; }
        public double Amount { set; get; }
    }

    class TradingBot
    {
        public event EventHandler<TradingResultEventArgs> TradeOccurred;

        public int LongIntegralLength { private set; get; }
        public int ShortIntegralLength { private set; get; }
        public int FullIntegralLength { private set; get; } 

        private double[] ChangeList;

        public double LongIntegral { private set; get; }
        public double ShortIntegral { private set; get; }

        public double LastBuyBTCWorth { private set; get; }
        public double LastSellBTCWorth { private set; get; }

        public double TransactionCooldown { private set; get; }
        public double TransactionCooldown_Duration { private set; get; }

        public TradingBot(ref MoneyTracker BalanceTracker, int nLongIntegral, int nShortIntegral)
        {
            if (nLongIntegral <= nShortIntegral) throw new InvalidOperationException("the Long Integral Count must be higher than the Low Integral Count");

            LongIntegralLength = nLongIntegral;
            ShortIntegralLength = nShortIntegral;
            FullIntegralLength = nLongIntegral + nShortIntegral;

            ChangeList = new double[FullIntegralLength];

            TransactionCooldown = 0;
            TransactionCooldown_Duration = FullIntegralLength;

            BalanceTracker.BuyInUSD(0.5f * BalanceTracker.USD_Balance);
        }

        private void InvokeTradeEvent(TradingDirection tradingDirection, double amount)
        {
            TradingResultEventArgs tradingResultArgs = new TradingResultEventArgs();
            tradingResultArgs.Amount = amount;
            tradingResultArgs.TradeDirection = tradingDirection;

            EventHandler<TradingResultEventArgs> handler = TradeOccurred;
            handler(this, tradingResultArgs);
        }

        public void UpdateChangeList(double NewValue, ref MoneyTracker BalanceTracker)
        {
            //Advance all ChangeList items
            for(int i = 0; i < (FullIntegralLength - 1); i++) ChangeList[i + 1] = ChangeList[i];
            //Insert new ChangeList item at the highest index
            ChangeList[0] = NewValue;

            if (TransactionCooldown < TransactionCooldown_Duration)
            {
                TransactionCooldown++;
                InvokeTradeEvent(TradingDirection.Cooldown, 0.5f * (double)(TransactionCooldown_Duration - TransactionCooldown));
            }
            else
            {
                //Trade based on the gathered Information
                Trade(ref BalanceTracker);
            }
        }

        private void ProcessChangeList()
        {
            LongIntegral = 0;
            ShortIntegral = 0;

            for (int i = 0; i < FullIntegralLength; i++)
            {
                if(i < ShortIntegralLength) ShortIntegral += ChangeList[i];
                else                        LongIntegral += ChangeList[i];
            }
        }
        private void Trade(ref MoneyTracker BalanceTracker)
        {
            //CalculateIntegralValues
            ProcessChangeList();

            if /*(*/(((LongIntegral / LongIntegralLength) > 0) && ((ShortIntegral / ShortIntegralLength) < 0))/* && (BalanceTracker.BTC_Worth > LastSellBTCWorth))*/
            {
                InvokeTradeEvent(TradingDirection.Sell, 0.5f * BalanceTracker.BTC_Balance);

                //Sell half the balance
                BalanceTracker.SellInBTC(0.5f * BalanceTracker.BTC_Balance);

                LastSellBTCWorth = BalanceTracker.BTC_Worth;

                TransactionCooldown = 0;
                TransactionCooldown_Duration = ShortIntegralLength;
            }
            else if /*(*/(((LongIntegral / LongIntegralLength) < 0) && ((ShortIntegral / ShortIntegralLength) > 0))/* && (BalanceTracker.BTC_Worth < LastBuyBTCWorth))*/
            {
                InvokeTradeEvent(TradingDirection.Buy, 0.5f * BalanceTracker.USD_Balance);

                //Buy half the balance
                BalanceTracker.BuyInUSD(0.5f * BalanceTracker.USD_Balance);

                LastBuyBTCWorth = BalanceTracker.BTC_Worth;

                TransactionCooldown = 0;
                TransactionCooldown_Duration = ShortIntegralLength;
            }
        }
    }
}
