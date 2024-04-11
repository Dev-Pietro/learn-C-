using System;

namespace Params_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 4);
            int s2 = Calculator.Sum(2, 4, 6, 8, 10, 10);

            Console.WriteLine($"Soma 1 = {s1}\nSoma 2 = {s2}");
        }
    }
}