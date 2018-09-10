using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input the time in hour:");
            Console.Write(">");
            int hour = Convert.ToInt32(Console.ReadLine());
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's morning.");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's afternoon.");
            }
            else if (hour >= 18 && hour < 25)
            {
                Console.WriteLine("It's evening.");
            }
            else
            {
                Console.WriteLine("The hour time you input is wrong.");
            }

            Console.ReadLine();
        }
    }
}
