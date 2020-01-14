using System;
using System.Collections.Generic;
using System.Text;
using ProjectHatchery.EventDeclaration;

namespace ProjectHatchery.SellingEvent
{
    class Customer
    {
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
                Console.WriteLine("Available Fish -\n Rui - {0}\n Katla - {1}\n Ilish - {2}\n", MarketInventory.rui, MarketInventory.katla, MarketInventory.ilish);
            }
        }
    }
}
