using System;
using System.Linq;

namespace random_class
{
    class RandomLetter
    {
        static Random _random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[_random.Next(s.Length)]).ToArray());
        }
        public static char GetRandoLetter()
        {
//            var _randomNum = new Random();
            char let;
            // This method returns a random lowercase letter.
            // ... Between 'a' and 'z' inclusize.
//            int num = _random.Next(0, 26); // Zero to 25
            int num = _random.Next(0, 26); // Zero to 51
            int randomNum = _random.Next(0, 2);  //0到1
            if (randomNum == 0)
            {
                let = (char)('a' + num);
//                Console.WriteLine(randomNum);
            }
            else
            {
                let = (char)('A' + num);
//                Console.WriteLine(randomNum);
            }

            return let;
        }
    }
}