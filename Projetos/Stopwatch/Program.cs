using System;
using System.Threading;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to your StopWatch");
            Console.WriteLine("OPTIONS:");
            Console.WriteLine("S - Seconds => 10s = 10 seconds");
            Console.WriteLine("M - Minutes => 1m = 1 minute");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("How much time you wish to count ?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1)); //take the last character
            int time = int.Parse(data.Substring(0, data.Length - 1)); //take all character except the last (type)
            int multiplier = 1;

            if (type == 'm') {
                multiplier = 60; //multiplier seconds to convert in minutes
            }
            if (time == 0) {
                System.Environment.Exit(0);
            }

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("GO !!!!");
            Thread.Sleep(2200);

            Start(time);
        }

        static void Start(int time) 
        {
            int currentTime = 0; //start time (seconds)

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //wait 1 second
            }

            Console.Clear();
            Console.WriteLine("STOP ! Let's back to menu");
            Thread.Sleep(2500); 
            Menu();
        }
    }
}
