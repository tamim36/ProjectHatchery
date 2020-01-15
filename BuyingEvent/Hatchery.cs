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
            if((insFishTank.getRuiList().Count - e.amount) >= 0){
                Console.WriteLine("rui buy");
                temp = insFishTank.getRuiList().Count;
                temp -= e.amount;
                insFishTank.setRuiList(temp);

                temp = marketStore.getRuiList().Count;
                temp += e.amount;
                marketStore.setRuiList(temp);
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }

        public void OnKatlaBuy(object source, FishAmountArgs e)
        {
            if ((insFishTank.getKatlaList().Count - e.amount) >= 0)
            {
                temp = insFishTank.getKatlaList().Count;
                temp -= e.amount;
                insFishTank.setKatlaList(temp);

                temp = marketStore.getKatlaList().Count;
                temp += e.amount;
                marketStore.setKatlaList(temp);
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }

        public void OnIlishBuy(object source, FishAmountArgs e)
        {
            if ((insFishTank.getIlishList().Count - e.amount) >= 0)
            {
                temp = insFishTank.getIlishList().Count;
                temp -= e.amount;
                insFishTank.setIlishList(temp);

                temp = marketStore.getIlishList().Count;
                temp += e.amount;
                marketStore.setIlishList(temp);
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }
    }
}
