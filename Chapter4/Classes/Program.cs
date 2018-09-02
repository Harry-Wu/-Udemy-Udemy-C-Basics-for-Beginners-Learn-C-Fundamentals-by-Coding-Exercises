using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Person
    {
        public string FirstName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName + '.');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person harry = new Person();
            harry.FirstName = "Harry";
            harry.LastName = "Wu";
            harry.Introduce();

            Console.ReadLine();
        }
    }
}
