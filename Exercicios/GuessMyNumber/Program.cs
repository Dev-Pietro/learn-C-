using System;

namespace GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a program called GuessMyNumber !!!! \n Do you wanna play ? [Y/N]");
            string answear = Console.ReadLine().ToUpper();

            if (answear == "N") {
                System.Environment.Exit(0);
            } else {
                Random numberRandom = new Random();
                int numberThink = numberRandom.Next(1, 20);

                Console.WriteLine("Then i think that was a YESSSS!!!!\nI'm thinking a number between 1 - 20, what number i'm thinking ?");
                string guessNumber = Console.ReadLine();
                int guessNumberInt = Convert.ToInt32(guessNumber);
                while (true) {
                    if (guessNumberInt == numberThink) {
                        Console.WriteLine($"YOU WIN !!!! NICE, I WAS THINKING IN {numberThink}!");
                        break;
                    } else if (guessNumberInt < numberThink) {
                        Console.WriteLine("Try Again, my number is bigger than this...");
                        guessNumber = Console.ReadLine();
                        guessNumberInt = Convert.ToInt32(guessNumber);
                    } else if (guessNumberInt > numberThink) {
                        Console.WriteLine("Try Again, my number is smaller than this...");
                        guessNumber = Console.ReadLine();
                        guessNumberInt = Convert.ToInt32(guessNumber);
                    }
                }
            }
        }
    }
}
