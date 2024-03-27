using System;

namespace Produto_3
{
    class Produto
    {
        public string nome;
        public double preco;
        public int quantidade;

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

        public override string ToString() { //metodo que utiliza a sobreposição para retornar o objeto como string
            return $"{nome}, R${preco:N2}, {quantidade} unidades. Valor total em estoque R${ValorTotalEmEstoque():N2}";
        }
    }
}