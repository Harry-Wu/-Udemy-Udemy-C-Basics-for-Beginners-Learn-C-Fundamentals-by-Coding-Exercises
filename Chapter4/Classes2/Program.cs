using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Person harry = new Person
            {
                FirstName = "Harry",
                LastName = "Wu"
            };
            harry.Introduce();
            Calculator calculator = new Calculator();
            var c = calculator.Add(1, 2);
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
