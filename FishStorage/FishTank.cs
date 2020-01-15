using System;
using System.Collections.Generic;
using System.Text;
using ProjectHatchery.AvailableFish;

namespace ProjectHatchery.FishStorage
{
    class FishTank
    {
        private List<Rui> RuiList = new List<Rui>();
        private List<Katla> KatlaList = new List<Katla>();
        private List<Ilish> IlishList = new List<Ilish>();

        private static FishTank _instance;
        private static readonly object _lock = new object();

        private FishTank()
        {
            for (int i = 0; i < 1000; i++)
            {
                RuiList.Add(new Rui());
                KatlaList.Add(new Katla());
                IlishList.Add(new Ilish());
            }
        }


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

        public List<Rui> getRuiList()
        {
            return RuiList;
        }

        public void setRuiList(int num)
        {
            RuiList.Clear();
            for (int i = 0; i < num; i++)
            {
                RuiList.Add(new Rui());
            }
        }

        public List<Katla> getKatlaList()
        {
            return KatlaList;
        }

        public void setKatlaList(int num)
        {
            KatlaList.Clear();
            for (int i = 0; i < num; i++)
            {
                KatlaList.Add(new Katla());
            }
        }

        public List<Ilish> getIlishList()
        {
            return IlishList;
        }

        public void setIlishList(int num)
        {
            IlishList.Clear();
            for (int i = 0; i < num; i++)
            {
                IlishList.Add(new Ilish());
            }
        }
    }
}
