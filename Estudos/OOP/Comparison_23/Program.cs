using System;
using System.Collections.Generic;
using Comparison_23.Entities;

namespace Comparison_23
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

            //Função Lambda         parametros|arrow|Comparando o nome de um objeto/<T> com o outro
            Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

            products.Add(new Product("TV", 900));
            products.Add(new Product("Notebook", 1200));
            products.Add(new Product("Tablet", 450));

            products.Sort(comp);

            foreach (Product p in products)
            {
                Console.WriteLine(p);
            }
        }
    }
}
