using System;

namespace Calculator
{   
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
                Console.Clear();
                Console.WriteLine("Primeiro valor: ");
                float v1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Segundo valor: ");
                float v2 = float.Parse(Console.ReadLine());
                Console.WriteLine("Operação que deseja realizar:");
                Console.WriteLine("+ | - | x | /");
                string operacaoDesejada = Console.ReadLine();

                switch (operacaoDesejada) {
                    case "+": Console.WriteLine($"{v1} + {v2} = {(v1 + v2)}"); break;
                    case "-": Console.WriteLine($"{v1} - {v2} = {(v1 - v2)}"); break;
                    case "x": Console.WriteLine($"{v1} x {v2} = {(v1 * v2)}"); break;
                    case "/": Console.WriteLine($"{v1} / {v2} = {(v1 / v2)}"); break;
                    default: Console.WriteLine("ERRO: Operação inválida"); break;
                }

                Console.WriteLine("Deseja continuar ? (s/n)");
                string continuar = Console.ReadLine();

                if (continuar == "n"){
                    Console.WriteLine("Obrigado por utilizar a calculadora !");
                    break;
                }
            };
        }
    }
}