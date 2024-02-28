using System;

namespace StartsEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Isto é um texto";
            Console.WriteLine(texto.StartsWith("Isto")); //retorna booleano
            Console.WriteLine(texto.StartsWith("Esse")); 

            Console.WriteLine(texto.EndsWith("texto")); //retorna booleano
            Console.WriteLine(texto.EndsWith("batata"));
        }
    }
}
