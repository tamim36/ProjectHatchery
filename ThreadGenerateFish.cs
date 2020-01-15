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
                if(insFishTank.getRuiList().Count<500 || insFishTank.getKatlaList().Count < 500 || insFishTank.getIlishList().Count < 500)
                {
                    insFishTank.setRuiList(1000);
                    insFishTank.setKatlaList(1000);
                    insFishTank.setIlishList(1000);
                    Console.WriteLine("Increasing Fish amount in Fish Tank");
                }
                Thread.Sleep(2000);
            }
        }
    }
}
