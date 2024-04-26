using System;
using System.Collections.Generic;
using Ex14.Entities;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.WriteLine("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data");
                Console.WriteLine("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.WriteLine("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, anualIncome, healthExpenditures));
                } else
                {
                    Console.WriteLine("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            Console.WriteLine("TAXES PAID");
            double sum = 0;
            foreach (TaxPayer payer in list)
            {
                double tp = payer.Tax();
                Console.WriteLine($"{payer.Name} ${tp:N2}");
                sum += tp;
            }

            Console.WriteLine("");
            Console.WriteLine($"TOTAL TAXES: ${sum:N2}");
        }
    }
}
