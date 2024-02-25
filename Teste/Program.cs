using System;

namespace Teste
{
    class Program 
    {
        static void Main(string[] args)
        {
            var mouse = new Product(002, "Logitech", 110.00);
            Console.WriteLine(mouse.Id);
            Console.WriteLine(mouse.Name);
            Console.WriteLine(mouse.Price);
            Console.WriteLine(mouse.PriceInDolar(5));
        }
    }

    struct Product 
    {
        public Product(int id, string name, double price) //metodo construtor, não retorna nada
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public int Id;
        public string Name;
        public double Price;

        public double PriceInDolar(double dolar) { //metodo
            return Price * dolar;
        }
    }
}
