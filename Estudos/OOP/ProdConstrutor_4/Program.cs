using System;
using System.Globalization;

namespace Produto_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre os Dados do Produto\nNome do Produto:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade em Estoque:");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade); //Exemplo com o construtor em ação

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