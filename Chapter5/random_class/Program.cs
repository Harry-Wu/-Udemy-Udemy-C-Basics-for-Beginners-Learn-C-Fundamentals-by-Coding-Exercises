using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_class
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("Print randowm numbers between 1 to 100:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(1, 100));  //1到99
            }
            Console.WriteLine("Print randowm numbers under 10:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.Next(10));  //0到9
            }
            Console.WriteLine("Print random characters:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(RandomLetter.GetRandoLetter());
            }
            Console.WriteLine("Print random string:");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(RandomLetter.RandomString(1));
            }
            Console.ReadLine();
        }
    }
}
