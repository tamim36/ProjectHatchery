using System;
using System.Collections.Generic;
using System.Text;
using ProjectHatchery.EventDeclaration;
using ProjectHatchery.SellingEvent;
using ProjectHatchery.FishStorage;

namespace ProjectHatchery.BuyingEvent
{
    public class Owner
    {
        FishTank insFishTank = FishTank.getInstanceFishTank();
        MarketStore marketStore = MarketStore.getInstanceMarketStore();
        public void task()
        {
            while (true)
            {
                var market = new Market();
                var hatchery = new Hatchery();


                Console.WriteLine(" For Rui - 1\n For Katla - 2\n For Ilish - 3\n To Quit - 0\n");
                int fishNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter amount to buy - ");
                int amount = Convert.ToInt32(Console.ReadLine());


                if (fishNo == 1)
                {
                    market.buyEvent += hatchery.OnRuiBuy;
                    market.raiseBuyEvent(amount);
                }
                else if (fishNo == 2)
                {
                    market.buyEvent += hatchery.OnKatlaBuy;
                    market.raiseBuyEvent(amount);
                }
                else if (fishNo == 3)
                {
                    market.buyEvent += hatchery.OnIlishBuy;
                    market.raiseBuyEvent(amount);
                }
                else if (fishNo == 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }

                Console.WriteLine(
            "All Available Fish -- \n" +
            "in Market Store   . . . . . . . .   in Fish Tank\n" +
            "(1) Rui - {0}   . . . . . . . . . .   (1) Rui - {3}\n" +
            "(2) Katla - {1}   . . . . . . . . .   (2) Katla - {4}\n" +
            "(3) Ilish - {2}   . . . . . . . . .   (3) Ilish - {5}\n",
            marketStore.getRui(), marketStore.getKatla(), marketStore.getIlish(), insFishTank.getRui(), insFishTank.getKatla(), insFishTank.getIlish());
            }
        }
    }
}
