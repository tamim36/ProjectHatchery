using System;
using System.Collections.Generic;
using System.Text;
using ProjectHatchery.EventDeclaration;
using ProjectHatchery.FishStorage;

namespace ProjectHatchery.SellingEvent
{
    class Customer
    {
        MarketStore marketStore = MarketStore.getInstanceMarketStore();
        FishTank insFishTank = FishTank.getInstanceFishTank();
        public void task()
        {
            while (true)
            {
                var market = new Market();   //publisher
                var marketInventory = new MarketInventory();

                Console.WriteLine(" For Rui - 1\n For Katla - 2\n For Ilish - 3\n To Quit - 4\n");
                int fishNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter amount to Purchase - ");
                int amount = Convert.ToInt32(Console.ReadLine());

                if (fishNo == 1)
                {
                    market.sellEvent += marketInventory.OnRuiSell;
                    market.raiseSellEvent(amount);
                }
                else if (fishNo == 2)
                {
                    market.sellEvent += marketInventory.OnKatlaSell;
                    market.raiseSellEvent(amount);
                }
                else if (fishNo == 3)
                {
                    market.sellEvent += marketInventory.OnIlishSell;
                    market.raiseSellEvent(amount);
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
            marketStore.getRuiList().Count, marketStore.getKatlaList().Count, marketStore.getIlishList().Count, insFishTank.getRuiList().Count, insFishTank.getKatlaList().Count, insFishTank.getIlishList().Count);
            }
        }
    }
}
