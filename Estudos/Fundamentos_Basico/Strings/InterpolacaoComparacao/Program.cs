using System;

namespace InterpolacaoComparacao
{
    class Program
    {
        static void Main(string[] args)
        {
            //var price = 10.2;
            //var texto = $"O preço do produto é {price}"; formata string com cifrão
            //var texto = string.Format("O preço do produto é {0}", price); //formata string com format -  
            // \n quebra a linha                                                         
            // @ deixa dar enter para escrever na outra linha

            var texto = "Isso é um teste";

            Console.WriteLine(texto.CompareTo("Testando")); //CompareTo - Compara algo com outra coisa, retorna int
            Console.WriteLine(texto.Contains("teste")); // Contains - segue o de cima porem retorna booleano
        }
    }
}
