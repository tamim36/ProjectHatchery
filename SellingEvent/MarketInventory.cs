using System;
using System.Collections.Generic;
using System.Text;
using ProjectHatchery.EventDeclaration;
using ProjectHatchery.FishStorage;

namespace ProjectHatchery.SellingEvent
{
    public class MarketInventory
    {
        MarketStore marketStore = MarketStore.getInstanceMarketStore();
        private int temp;

        public void OnRuiSell(object source, FishAmountArgs e)
        {
            if ((marketStore.getRuiList().Count - e.amount) >= 0)
            {
                temp = marketStore.getRuiList().Count;
                temp -= e.amount;
                marketStore.setRuiList(temp);
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }

        public void OnKatlaSell(object source, FishAmountArgs e)
        {
            if ((marketStore.getKatlaList().Count - e.amount) >= 0)
            {
                temp = marketStore.getKatlaList().Count;
                temp -= e.amount;
                marketStore.setKatlaList(temp);
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }

        public void OnIlishSell(object source, FishAmountArgs e)
        {
            if ((marketStore.getIlishList().Count - e.amount) >= 0)
            {
                temp = marketStore.getIlishList().Count;
                temp -= e.amount;
                marketStore.setIlishList(temp);
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }
    }
}
