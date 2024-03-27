using System;
using System.Globalization;

namespace Produto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre os Dados do Produto\nNome do Produto:");
            p.nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            p.preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade em Estoque:");
            p.quantidade = int.Parse(Console.ReadLine());

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