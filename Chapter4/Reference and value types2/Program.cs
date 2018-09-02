using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference_and_value_types2
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            var person = new Person() {Age = 3};
            MakOld(person);
            Console.WriteLine(person.Age);
            Console.ReadLine();
        }

        static void Increment(int number)
        {
            number += 10;
        }

        static void MakOld(Person person)
        {
            person.Age += 10;
        }
    }
}
