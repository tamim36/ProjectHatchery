using System;
using ProjectHatchery.BuyingEvent;
using ProjectHatchery.SellingEvent;
using System.Threading;
using ProjectHatchery.FishStorage;

namespace ProjectHatchery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Customer (To decrease Fish) Application press - 1");
            Console.WriteLine("For Owner (To increase Fish) Application press - 2");
            int userType = Convert.ToInt32(Console.ReadLine());

            // Creating new Thread
            ThreadGenerateFish _instance = new ThreadGenerateFish();
            ThreadStart childref = new ThreadStart(_instance.GeneratingFish);
            Thread childThread = new Thread(childref);
            childThread.Start();


            if (userType == 1)
            {
                Customer customer = new Customer();
                customer.task();
            }

            if (userType == 2)
            {
                Owner owner = new Owner();
                owner.task();
            }
        }
    }
}
