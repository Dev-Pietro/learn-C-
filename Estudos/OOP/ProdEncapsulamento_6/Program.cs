using System;
using System.Globalization;

namespace ProdEncapsulamento_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto("TV", 500.00, 10);

            Console.WriteLine(p.GetNome());

            p.SetNome("Console");
            Console.WriteLine(p.GetNome());
        }
    }
}