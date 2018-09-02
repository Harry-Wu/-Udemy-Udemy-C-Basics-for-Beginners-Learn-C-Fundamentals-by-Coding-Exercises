using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum
{
    public enum ShippingMethod  //如果不对变量初始化,第一个变量的值将是0,以此类推
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Experss = 3
    };
    class Program
    {
        static void Main(string[] args)
        {
            var choosenMethod = ShippingMethod.Experss;
            Console.WriteLine(choosenMethod);
            Console.WriteLine((int)choosenMethod);
            var methodId = 2;
            Console.WriteLine((ShippingMethod)methodId);
            Console.WriteLine((int)(ShippingMethod)methodId);
            Console.ReadLine();
        }
    }
}
