using System;
using System.Collections.Generic;
using Ex12.Entities;


namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.WriteLine("Enter number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:\nCommon, used or imported (c/u/i)?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Price: ");
                double price = double.Parse(Console.ReadLine());

                if (ch == 'c') {
                    products.Add(new Product(name, price));
                } else if (ch == 'u') {
                    Console.WriteLine("Manufacture date (DD/MM/YYYY):");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, date));
                } else if (ch == 'i') {
                    Console.WriteLine("Customs fee:");
                    double fee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, fee));
                } else {
                    Console.WriteLine("INVALID OPTION");
                }
            }

            Console.WriteLine("PRICE TAGS:");
            foreach(Product product in products) {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}