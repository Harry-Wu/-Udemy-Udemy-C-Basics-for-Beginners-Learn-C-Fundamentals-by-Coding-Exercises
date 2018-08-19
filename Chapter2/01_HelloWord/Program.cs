using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _01_HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcom to C# World!");
            // Console.Beep(37, 10000);
            Console.Beep();
           // string audioPath = "http://www.wavsource.com/snds_2018-06-03_5106726768923853/music/such_a_state_x.wav";
            string audioPath = "C:/Windows/media/Ring06.wav";
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(audioPath);
            player.Load();
            player.PlayLooping();
            Console.WriteLine("Now playlooping:-> {0}", audioPath);

            Console.ReadKey();
        }
    }
}
