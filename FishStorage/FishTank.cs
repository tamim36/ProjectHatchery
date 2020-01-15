using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHatchery.FishStorage
{
    class FishTank
    {
        private int rui = 1000, katla = 1000, ilish = 1000;


        private static FishTank _instance;
        private static readonly object _lock = new object();

        private FishTank() { }

        public static FishTank getInstanceFishTank()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new FishTank();
                    }
                }
            }
            return _instance;
        }

        public int getRui()
        {
            return rui;
        }
        public void setRui(int num)
        {
            rui = num;
        }

        public int getKatla()
        {
            return katla;
        }
        public void setKatla(int num)
        {
            katla = num;
        }

        public int getIlish()
        {
            return ilish;
        }
        public void setIlish(int num)
        {
            ilish = num;
        }
    }
}
