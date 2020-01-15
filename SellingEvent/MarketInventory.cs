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
            if ((marketStore.getRui() - e.amount) >= 0)
            {
                temp = marketStore.getRui();
                temp -= e.amount;
                marketStore.setRui(temp);
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }

        public void OnKatlaSell(object source, FishAmountArgs e)
        {
            if ((marketStore.getKatla() - e.amount) >= 0)
            {
                temp = marketStore.getKatla();
                temp -= e.amount;
                marketStore.setKatla(temp);
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }

        public void OnIlishSell(object source, FishAmountArgs e)
        {
            if ((marketStore.getIlish() - e.amount) >= 0)
            {
                temp = marketStore.getIlish();
                temp -= e.amount;
                marketStore.setIlish(temp);
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }
    }
}
