using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHatchery
{
    public class Owner
    {
        public void task()
        {
            while (true)
            {
                var market = new Market();
                var hatchery = new Hatchery();


                Console.WriteLine(" For Rui - 1\n For Katla - 2\n For Ilish - 3\n");
                int fishNo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter amount to buy - ");
                int amount = Convert.ToInt32(Console.ReadLine());


                if (fishNo == 1)
                {
                    market.buyEvent += hatchery.OnRuiBuy;
                    market.raiseBuyEvent(amount);
                }
                if (fishNo == 2)
                {
                    market.buyEvent += hatchery.OnKatlaBuy;
                    market.raiseBuyEvent(amount);
                }
                if (fishNo == 3)
                {
                    market.buyEvent += hatchery.OnIlishBuy;
                    market.raiseBuyEvent(amount);
                }

                Console.WriteLine("Available Fish in Fish Tank -\n Rui - {0}\n Katla - {1}\n Ilish - {2}\n", FishTank.rui, FishTank.katla, FishTank.ilish);

                Console.WriteLine("Available Fish in Market Inventory -\n Rui - {0}\n Katla - {1}\n Ilish - {2}\n", MarketInventory.rui, MarketInventory.katla, MarketInventory.ilish);
            }
        }
    }
}
