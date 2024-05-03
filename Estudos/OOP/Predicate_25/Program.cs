using System;
using System.Collections.Generic;
using Predicate_25.Entities;

namespace Predicate_25
{
    class Program
    {
        //Predicate - recebe um objeto e devolve um valor booleano

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900));
            list.Add(new Product("Mouse", 50));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            list.RemoveAll(ProductTest); //remove todos produtos com preços iguais ou maiores que 100 (usando predicate)
            foreach(Product p in list) {
                Console.WriteLine(p);
            }
        }

        public static bool ProductTest(Product p) {
            return p.Price >= 100; //exemplo de predicate que recebe um produto e retorna bool
        }
    }
}