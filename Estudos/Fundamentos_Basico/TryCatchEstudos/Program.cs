using System;

namespace TryCatchEstudos
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "ab";
            int y = 0;

            try
            {
                int xInt = Convert.ToInt32(x);
                Console.WriteLine($"{x} + {y} = {x + y}");
                // Console.WriteLine($"{x} / {y} = {x / y}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}