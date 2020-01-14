using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectHatchery
{
    public class ThreadGenerateFish
    {
        public static void GeneratingFish()
        {
            while (true)
            {
                if(FishTank.rui<500 || FishTank.katla<500 || FishTank.ilish < 500)
                {
                    FishTank.rui = 1000;
                    FishTank.katla = 1000;
                    FishTank.ilish = 1000;
                    Console.WriteLine("Increasing Fish amount in Fish Tank");
                }
                Thread.Sleep(2000);
            }
        }
    }
}
