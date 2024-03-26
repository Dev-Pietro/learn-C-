using System;

namespace Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1, pessoa2;

            pessoa1 = new Pessoa();
            pessoa2 = new Pessoa();

            Console.WriteLine("Digite um nome e sua idade:");
            pessoa1.nome = Console.ReadLine();
            pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite outro nome e a respectiva idade:");
            pessoa2.nome = Console.ReadLine();
            pessoa2.idade = int.Parse(Console.ReadLine());
            Console.WriteLine("------------");

            Console.WriteLine($"Dados Pessoa 01\nNome: {pessoa1.nome}\nIdade: {pessoa1.idade}\n------------\nDados Pessoa 02\nNome: {pessoa2.nome}\nIdade: {pessoa2.idade}\n------------");

            if(pessoa1.idade > pessoa2.idade) {
                Console.WriteLine($"Pessoa mais velha: {pessoa1.nome}");
            } else Console.WriteLine($"Pessoa mais velha: {pessoa2.nome}");

        }
    }
}
