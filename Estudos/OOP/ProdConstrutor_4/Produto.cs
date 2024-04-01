using System;

namespace Produto_3
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

        public Produto(string nomeProduto, double precoProduto, int quantidadeProduto) {
            nome = nomeProduto;
            preco = precoProduto;
            quantidade = quantidadeProduto;
        } //Isso é um Construtor - obriga a instanciar a classe com suas variaveis, no caso nome, preco e quantidade

        public double ValorTotalEmEstoque() {
            return preco * quantidade;
        }

        public void AdicionarProdutos(int qtd) {
            quantidade += qtd;
        }

        public void RemoveProdutos(int qtd) {
            if(qtd > quantidade){
                Console.WriteLine("OPERAÇÃO INVÁLIDA");
            } else {
                quantidade -= qtd;
            };
        }

        public override string ToString() { 
            return $"{nome}, R${preco:N2}, {quantidade} unidades. Valor total em estoque R${ValorTotalEmEstoque():N2}";
        }
    }
}