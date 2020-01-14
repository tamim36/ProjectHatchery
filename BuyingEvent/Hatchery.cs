using System;
using System.Collections.Generic;
using System.Text;
using ProjectHatchery.EventDeclaration;
using ProjectHatchery.SellingEvent;

namespace ProjectHatchery.BuyingEvent
{
    public class Hatchery
    {
        public void OnRuiBuy(object source, FishAmountArgs e)
        {
            if((FishTank.rui - e.amount) >= 0){
                Console.WriteLine("rui buy");
                FishTank.rui -= e.amount;
                MarketInventory.rui += e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }

        public void OnKatlaBuy(object source, FishAmountArgs e)
        {
            if ((FishTank.katla - e.amount) >= 0)
            {
                Console.WriteLine("katla buy");
                FishTank.katla -= e.amount;
                MarketInventory.katla += e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }

        public void OnIlishBuy(object source, FishAmountArgs e)
        {
            if ((FishTank.ilish - e.amount) >= 0)
            {
                FishTank.ilish -= e.amount;
                MarketInventory.ilish += e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient fish in fish tank");
            }
        }
    }
}
