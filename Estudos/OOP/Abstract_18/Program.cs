using System;
using System.Collections.Generic;
using Abstract_18.Entities;

namespace Abstract_18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Account> list = new List<Account>();

            list.Add(new SavingsAccount(1001, "Alex", 500, 0.01));
            list.Add(new BusinessAccount(1002, "Bob", 500, 400));
            list.Add(new SavingsAccount(1003, "Bob", 500, 0.01));

            double sum = 0;
            foreach (Account acc in list)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total Balance: " + sum);
        }
    }
}