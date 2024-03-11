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
            if (num % 2 == 0) {
                if (num == 2) {
                    return true;
                }
                return false;
            }
            
            for(int i = 3; i < num; i+=2) {
                if (num % i == 0) {
                    return false;
                }
            }
            
            return true;
        }
    }
}