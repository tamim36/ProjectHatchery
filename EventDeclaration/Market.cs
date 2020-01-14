using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHatchery.EventDeclaration
{
    class Market
    {
        public delegate void sellDelegate(object source, FishAmountArgs e);
        public delegate void buyDelegate(object source, FishAmountArgs e);

        public event sellDelegate sellEvent;
        public event buyDelegate buyEvent;

        public void raiseSellEvent(int amount)
        {
            OnSellCall(amount);
        }

        public void raiseBuyEvent(int amount)
        {
            OnBuyCall(amount);
        }

        protected virtual void OnSellCall(int amount)
        {
            if (sellEvent != null)
                sellEvent(this, new FishAmountArgs { amount = amount });
        }

        protected virtual void OnBuyCall(int amount)
        {
            if (buyEvent != null)
                buyEvent(this, new FishAmountArgs { amount = amount });
        }
    }
}
