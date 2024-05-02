using System;
using Delegates_24.Services;

namespace Delegates_24
{
    //delegate - tipo referência, que no exemplo referencia a uma função, com type safety
    delegate double BinaryNumericOperation(double n1, double n2);

    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationServices.Sum;

            double Result = op(a, b);
            Console.WriteLine(Result);
        }
    }
}
