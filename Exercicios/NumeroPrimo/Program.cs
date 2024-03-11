using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i < 30; i++) {
                Console.WriteLine($"{i} é número primo ? {VerificaPrimo(i)}");
            }
        }

        static bool VerificaPrimo(int num)
        {
            if (num == 2 || num == 3)
                return true;
            
            if (num % 2 == 0 || num % 3 == 0)
                return false;
            
            return true;
        }
    }
}