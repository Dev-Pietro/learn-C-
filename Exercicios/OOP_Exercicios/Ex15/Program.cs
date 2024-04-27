using System;
using Ex15.Entities;

namespace Ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Enter account data");
                Console.WriteLine("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine("Holder: ");
                string holder = Console.ReadLine();
                Console.WriteLine("Initial balance: ");
                double balance = double.Parse(Console.ReadLine());
                Console.WriteLine("Withdraw limit: ");
                double withdrawLimit = double.Parse(Console.ReadLine());

                Account acc = new Account(number, holder, balance, withdrawLimit);
                Console.WriteLine("");

                Console.WriteLine("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                acc.WithDraw(withdraw);
                Console.WriteLine($"New Balance : {acc.Balance:N2}");
            }
            catch (Exception e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}