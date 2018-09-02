using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_types_and_value_types
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine("a = {0}, b = {1}", a, b);

            var array1 = new int[3] {1, 2, 3};
            var array2 = array1;
            array2[0] = 7;
            Console.WriteLine("array1[0] = {0}, array2[0] = {1}", array1[0], array2[0]);

            Console.ReadLine();
        }
    }
}
