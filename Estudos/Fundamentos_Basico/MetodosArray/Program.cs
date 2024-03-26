using System;

namespace MetodosArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] codes = {"B12", "B14", "C01", "A22", "A10", "Z05"};

            Array.Sort(codes); //sort
            foreach(string code in codes) {
                Console.WriteLine($"Code: {code}");
            }

            Console.WriteLine("-----------------------------------------------------");

            Array.Reverse(codes); //reverse
            foreach(string code in codes) {
                Console.WriteLine($"Code: {code}");
            }

            Console.WriteLine("-----------------------------------------------------");

            Array.Clear(codes, 0, 2); //remove
            foreach(string code in codes) {
                Console.WriteLine($"Code: {code}");
            }

            Console.WriteLine("-----------------------------------------------------");

            Array.Resize(ref codes, 8); //"add" or "remove"

            codes[6] = "B02";
            codes[7] = "F05";

            foreach(string code in codes) {
                Console.WriteLine($"Code: {code}");
            }
        }
    }
}