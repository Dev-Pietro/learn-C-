using System;

namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre o número da conta:");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre o titular da conta:");
            string titular = Console.ReadLine();

            Console.WriteLine("Haverá depósito inicial (s/n)?");
            string resposta = Console.ReadLine();

            if (resposta.ToLower().StartsWith("s")) {
                Console.WriteLine("Entre o valor de depósito inicial:");
                double depInicial = double.Parse(Console.ReadLine());
                Conta conta = new Conta(numeroConta, titular, depInicial);
                Console.WriteLine("");
                Console.WriteLine($"Dados da Conta:\n{conta}");
                Console.WriteLine("");
                Console.WriteLine("Entre um valor para depósito:");
                double valorDep = double.Parse(Console.ReadLine());
                conta.Depositar(valorDep);
                Console.WriteLine($"Dados da Conta atualizados:\n{conta}");
                Console.WriteLine("");
                Console.WriteLine("Entre um valor para saque:");
                double valorSaque = double.Parse(Console.ReadLine());
                conta.Sacar(valorSaque);
                Console.WriteLine($"Dados da Conta atualizados:\n{conta}");
            } else if (resposta.ToLower().StartsWith("n")) {
                Conta conta = new Conta(numeroConta, titular);
                Console.WriteLine("");
                Console.WriteLine($"Dados da Conta:\n{conta}");
                Console.WriteLine("");
                Console.WriteLine("Entre um valor para depósito:");
                double valorDep = double.Parse(Console.ReadLine());
                conta.Depositar(valorDep);
                Console.WriteLine($"Dados da Conta atualizados:\n{conta}");
                Console.WriteLine("");
                Console.WriteLine("Entre um valor para saque:");
                double valorSaque = double.Parse(Console.ReadLine());
                conta.Sacar(valorSaque);
                Console.WriteLine($"Dados da Conta atualizados:\n{conta}");
            }
        }
    }
}