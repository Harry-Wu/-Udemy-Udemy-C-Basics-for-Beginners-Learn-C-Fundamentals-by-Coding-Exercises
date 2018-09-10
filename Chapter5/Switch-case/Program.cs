using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            var season = Season.Spring;
            switch (season)
            {
                case Season.Autum:
                    Console.WriteLine("It's autum and a beautiful season.");
                    break;
                case Season.Spring:
                    Console.WriteLine("It's spring and nice time for reading.");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's perfect to go to beach.");
                    break;
                default:
                    Console.WriteLine("I don't understand that season.");
                    break;
            }

            Console.ReadLine();
        }
    }
}
