using System;

namespace ProdEncapsulamento_6
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;
        //Encapsulamento - deixa os atributos privados para que eles não possam ser acessados convencionalmente,
        //mantendo o estado dele de acordo com as regras de negocio. OBS: indicado pelo private e pelo _ antes do 
        //nome do atributo

        public Produto(string nomeProduto, double precoProduto, int quantidadeProduto) {
            _nome = nomeProduto;
            _preco = precoProduto;
            _quantidade = quantidadeProduto;
        } 

        public string GetNome() { 
            return _nome; //Metodo Get para o atributo nome 
        }

        public void SetNome(string nome) {
            if (nome != null && nome.Length > 1) {
                _nome = nome; //Metodo Set para que o usuario consigar setar/alterar o nome
            };
        } 
        //vantagem de encapsular atributos é poder controlar que "parametros" ele aceitará, no exemplo acima
        //só poderá mudar o nome se o novo nome não for nulo e for maior que um

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int qtd) {
            _quantidade += qtd;
        }

        public void RemoveProdutos(int qtd) {
            if(qtd > _quantidade){
                Console.WriteLine("OPERAÇÃO INVÁLIDA");
            } else {
                _quantidade -= qtd;
            };
        }

        public override string ToString() { 
            return $"{_nome}, R${_preco:N2}, {_quantidade} unidades. Valor total em estoque R${ValorTotalEmEstoque():N2}";
        }
    }
}