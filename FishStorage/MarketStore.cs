using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectHatchery.FishStorage
{
    class MarketStore
    {
        private int rui = 100, katla = 100, ilish = 100;


        private static MarketStore _instance;
        private static readonly object _lock = new object();

        private MarketStore() { }

        public static MarketStore getInstanceMarketStore()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new MarketStore();
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
