using System;
using System.Collections.Generic;
using System.Text;
using ProjectHatchery.EventDeclaration;
using ProjectHatchery.SellingEvent;
using ProjectHatchery.FishStorage;

namespace ProjectHatchery.BuyingEvent
{
    public class Hatchery
    {
        FishTank insFishTank = FishTank.getInstanceFishTank();
        MarketStore marketStore = MarketStore.getInstanceMarketStore();
        private int temp;

        public void OnRuiBuy(object source, FishAmountArgs e)
        {
            if((insFishTank.getRui() - e.amount) >= 0){
                Console.WriteLine("rui buy");
                temp = insFishTank.getRui();
                temp -= e.amount;
                insFishTank.setRui(temp);

                temp = marketStore.getRui();
                temp += e.amount;
                marketStore.setRui(temp);
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }

        public void OnKatlaBuy(object source, FishAmountArgs e)
        {
            if ((insFishTank.getKatla() - e.amount) >= 0)
            {
                temp = insFishTank.getKatla();
                temp -= e.amount;
                insFishTank.setKatla(temp);

                temp = marketStore.getKatla();
                temp += e.amount;
                marketStore.setKatla(temp);
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }

        public void OnIlishBuy(object source, FishAmountArgs e)
        {
            if ((insFishTank.getIlish() - e.amount) >= 0)
            {
                temp = insFishTank.getIlish();
                temp -= e.amount;
                insFishTank.setIlish(temp);

                temp = marketStore.getIlish();
                temp += e.amount;
                marketStore.setIlish(temp);
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }
    }
}
