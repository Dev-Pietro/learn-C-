using System;
using Sobreposicao_17.Entities;

namespace Sobreposicao_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001, "Alex", 500);
            Account acc2 = new SavingsAccount(1002, "Ana", 500, 0.01);

            acc.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc.Balance);
            Console.WriteLine(acc2.Balance);

            //virtual - indica que o metodo da classe pode ser sobreescrito (override), usado na classe account
            //contexto: Account comum tem uma taxa de saque de R$5,00 , já uma conta poupança (savingsaccount) não possui taxa de saque, por isso foi utilizado override
        }
    }
}