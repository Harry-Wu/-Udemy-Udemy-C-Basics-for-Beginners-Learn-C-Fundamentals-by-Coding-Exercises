using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 1;
            int i = a;
            Console.WriteLine(i);

            int j = 2;
            byte b = Convert.ToByte(j);
            Console.WriteLine(b);
            j = 259;
            b = (byte) j;  //(byte)方式的强制转换对溢出不告警
            Console.WriteLine(b);

            string number = "1234";
            i = int.Parse(number);
            j = Convert.ToInt32(number);
            Console.WriteLine(i);
            Console.WriteLine(j);
            Console.ReadLine();
        }
    }
}
