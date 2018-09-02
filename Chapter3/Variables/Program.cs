using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            byte number = 2;
            var number2 = 3;
            int count = 10;
            float totalPrice = 20.95F;
            char character = 'A';
            string firstName = "Harry";
            bool isWorking = false;
            Console.WriteLine(number);
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine("The Min and Max value of byte is {0} and {1}.", byte.MinValue, byte.MaxValue);
            Console.WriteLine("The Min and Max value of int is {0} and {1}.", int.MinValue, int.MaxValue);
            Console.WriteLine("The Min and Max value of float is {0} and {1}.", float.MinValue, float.MaxValue);
            Console.WriteLine("The Min and Max value of char is {0} and {1}.", char.MinValue, char.MaxValue);
            Console.ReadLine();
        }
    }
}
