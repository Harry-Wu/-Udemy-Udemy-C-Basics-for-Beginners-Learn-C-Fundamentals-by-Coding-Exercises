using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            float price = 0;
            bool isVipcustomer = false;
            Console.WriteLine("Are you VIP customer?(Y/N)");
            string customerType = Console.ReadLine();
            if (customerType == "Y")
                isVipcustomer = true;
//                price = 19.99f;
            else if (customerType == "N")
                isVipcustomer = false;
            //                price = 29.99f;
            else
                Console.WriteLine("Please input Y or N.");
            price = isVipcustomer ? 19.99f : 29.99f;
            Console.WriteLine("The price of the milk is {0}.", price);
            Console.ReadLine();
        }
    }
}
