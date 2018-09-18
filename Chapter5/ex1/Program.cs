using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a number between 1 to 10:");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");

            Console.WriteLine("Compare two numbers, and display the maximum of the two.");
            Console.Write("Please input the 1st number:");
            float number1 = Convert.ToSingle(Console.ReadLine());
            Console.Write("Please input the 2nd number:");
            float number2 = Convert.ToSingle(Console.ReadLine());
            float maxNumber = number1 > number2 ? number1 : number2;
            Console.WriteLine("The maximum number is {0}.", maxNumber);

            Console.WriteLine("Check if the image is landscape or portrait.");
            Console.Write("Please input the width of your image:");
            int imgWidth = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please input the height of your image:");
            int imgHeight = Convert.ToInt32(Console.ReadLine());
            if (imgWidth > imgHeight)
                Console.WriteLine("This image is landscape.");
            else if (imgWidth < imgHeight)
                Console.WriteLine("This image is portrait.");
            else
                Console.WriteLine("This image is square.");

            /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
            /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
            /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
            /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
            /// demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on 
            /// the console. If the number of demerit points is above 12, the program should display License Suspended.
            Console.WriteLine("Demerit potions calculate!");
            Console.Write("What is the speed limit? ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.Write("What is the speed of this car? ");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed < speedLimit)
                Console.WriteLine("Ok");
            else
            {
                const int kmPerDemeritPoint = 5;  //每超速5公里罚1个驾驶积分
                int demeritPoints = (carSpeed - speedLimit) / kmPerDemeritPoint;
                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended");
                else
                    Console.WriteLine("Left demerit points: " + demeritPoints);
            }
            Console.ReadLine();
        }
    }
}
