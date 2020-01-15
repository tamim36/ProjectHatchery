using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using ProjectHatchery.FishStorage;

namespace ProjectHatchery
{
    public class ThreadGenerateFish
    {
        FishTank insFishTank = FishTank.getInstanceFishTank();
        public void GeneratingFish()
        {
            while (true)
            {
                if(insFishTank.getRui()<500 || insFishTank.getKatla() < 500 || insFishTank.getKatla() < 500)
                {
                    insFishTank.setRui(1000);
                    insFishTank.setKatla(1000);
                    insFishTank.setIlish(1000);
                    Console.WriteLine("Increasing Fish amount in Fish Tank");
                }
                Thread.Sleep(2000);
            }
        }
    }
}
