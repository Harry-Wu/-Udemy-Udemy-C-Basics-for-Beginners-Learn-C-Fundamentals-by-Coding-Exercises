using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = 0;
            while (i <= 10)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }

            while (true)
            {
                Console.Write("Please input your name:");
                var input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }

                Console.WriteLine("You name is {0}.", input);
            }
            Console.ReadLine();
        }
    }
}
