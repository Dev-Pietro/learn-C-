using System;

namespace ProdEncProperties
{
    class Produto
    {
        private string _nome;
        public double preco { get; private set; } 
        public int quantidade { get; private set; }
        //auto properties - utilizado quando não há uma lógica na utilização, sendo possivel ve-lo e não altera-lo (get, private set)

        public Produto(string nomeProduto, double precoProduto, int quantidadeProduto) {
            _nome = nomeProduto;
            preco = precoProduto;
            quantidade = quantidadeProduto;
        } 

        public string Nome { 
            get { return _nome; }
            set {
                if(value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        } //forma melhor de get e set atraves de properties normal, mais convencional no C#, 
        //principalmente se houver alguma logica exercida pelo atributo, como no caso de nome no set

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
            return $"{_nome}, R${preco:N2}, {quantidade} unidades. Valor total em estoque R${ValorTotalEmEstoque():N2}";
        }
    }
}