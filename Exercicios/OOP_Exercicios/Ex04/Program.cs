using System;

namespace Ex04
{
    class Program
    {
        static void Main(string[] args)
        {
            CriaConta contaUm = new CriaConta();
            Console.WriteLine("CADASTRO DE CONTA BANCO DIGITAL\nNome:");
            contaUm.nome = Console.ReadLine();
            Console.WriteLine("Senha:");
            contaUm.senha = Console.ReadLine();

            Console.WriteLine($"CADASTRO FEITO COM SUCESSO\n--------------------\n{contaUm}");

            while (true) {
                Console.WriteLine("OPÇÕES\n[0]Depositar\n[1]Sacar\n[2]Sair");
                string userAns = Console.ReadLine();

                if (userAns == "0") {
                    Console.WriteLine("Valor que deseja depositar:");
                    double valor = double.Parse(Console.ReadLine());
                    contaUm.Depositar(valor);
                } else if (userAns == "1") {
                    Console.WriteLine($"Valor que deseja sacar: \nSaldo Atual: R${contaUm.saldo:N2}");
                    double valorSaque = double.Parse(Console.ReadLine());
                    if (valorSaque > contaUm.saldo) {
                        Console.WriteLine("ERRO: Valor de saque maior do que saldo atual.");
                        continue;
                    } else {
                        contaUm.Sacar(valorSaque);
                    }
                } else if (userAns == "2") {
                    break;
                } else {
                    Console.WriteLine("OPÇÃO INVÁLIDA, TENTE NOVAMENTE");
                }
            }
        }
    }
}
