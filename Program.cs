using System;

namespace ProjectHatchery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("For Customer (To decrease Fish) Application press - 1");
            Console.WriteLine("For Owner (To increase Fish) Application press - 2");
            int userType = Convert.ToInt32(Console.ReadLine());

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
