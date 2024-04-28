using System;
using GetHashCodeEquals_20.Entities;

namespace GetHashCodeEquals_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
            Client b = new Client { Name = "Alex", Email = "alex@gmail.com" };

            Console.WriteLine(a.Equals(b));
            Console.WriteLine(a == b);
            Console.WriteLine(a.GetHashCode());
            Console.WriteLine(b.GetHashCode());

            //Equals - lento, porém preciso
            //GetHashCode - rápido, porém com chance de colisão
            //No exemplo acima foi criado um equals e um gethashcode personalizado para a classe Client
        }
    }
}
