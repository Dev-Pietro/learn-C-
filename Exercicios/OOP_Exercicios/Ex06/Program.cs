using System;

namespace Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluguel[] aluguel = new Aluguel[10];
            Console.WriteLine("Quantos quartos serão alugados ?");
            int quartosAlug = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            int count = 0;

            for(int i = 0; i < quartosAlug; i++) {
                count++;
                Console.WriteLine($"Aluguel #{count}\nNome:");
                string nome = Console.ReadLine();
                Console.WriteLine("Email:");
                string email = Console.ReadLine();
                Console.WriteLine("Quarto:");
                int numQuarto = int.Parse(Console.ReadLine());

                aluguel[numQuarto] = new Aluguel(nome, email);
                Console.WriteLine("");
            };

            Console.WriteLine("Quartos Ocupados:");

            for(int i = 0; i < aluguel.Length; i++) {
                if(aluguel[i] == null) continue;
                else {
                    Console.WriteLine($"{i}: {aluguel[i].Nome}, {aluguel[i].Email}");
                }
            };
        }
    }
}