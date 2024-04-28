using System;

namespace Generics_19
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintService<string> printservice = new PrintService<string>(); //utilizando Generics

            Console.WriteLine("How many values ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string x = Console.ReadLine();
                printservice.AddValue(x);
            }

            printservice.Print();
            Console.WriteLine("First: " + printservice.First());
        }
    }
}
