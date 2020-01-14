using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHatchery
{
    public class MarketInventory
    {
        public static int rui = 100, katla = 100, ilish = 100;

        public void OnRuiSell(object source, FishAmountArgs e)
        {
            if ((rui - e.amount) >= 0)
            {
                rui = rui - e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }

        public void OnKatlaSell(object source, FishAmountArgs e)
        {
            if ((katla - e.amount) >= 0)
            {
                katla = katla - e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }

        public void OnIlishSell(object source, FishAmountArgs e)
        {
            if ((ilish - e.amount) >= 0)
            {
                ilish = ilish - e.amount;
            }
            else
            {
                Console.WriteLine("Insufficient Fish ! ");
            }
        }
    }
}
