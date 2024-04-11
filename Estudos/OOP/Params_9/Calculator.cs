using System;

namespace Params_9
{
    class Calculator
    {
        //params - mostra que irá receber uma quantidade variada de valores, podendo aceitar assim varios valores,
        //como na soma de uma calculadora
        public static int Sum(params int[] numbers) {
            int sum = 0;
            for(int i = 0; i < numbers.Length; i++) {
                sum += numbers[i];
            }
            return sum;
        }
    }
}