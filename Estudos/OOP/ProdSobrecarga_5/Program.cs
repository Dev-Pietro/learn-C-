using System;
using System.Globalization;

namespace ProdSobrecarga_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os Dados do Produto\nNome do Produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto p = new Produto(nome, preco); //Exemplo com o construtor com sobrecarga

            Console.WriteLine($"Dados do Produto: {p}\n");

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque:");
            int qtd = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qtd);

            Console.WriteLine($"Dados Atualizados: {p}\n");

            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
            int rmv = int.Parse(Console.ReadLine());
            p.RemoveProdutos(rmv);

            Console.WriteLine($"Dados Atualizados: {p}");

        }
    }
}