using System;

namespace Heranca_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual nome do cidadão ?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade dele ?");
            int idade = int.Parse(Console.ReadLine());
            Padeiro pessoa1 = new Padeiro(nome, idade);

            Console.WriteLine($"{pessoa1.Nome} ACABOU DE SE TORNAR {pessoa1.Profissao}!!!!");
            pessoa1.Trabalhar();
            pessoa1.Acordar();
            pessoa1.Trabalhar();
            Console.WriteLine(pessoa1);
            pessoa1.Dormir();
        }
    }

    class Pessoa
    {
        public string Nome {get; set; }
        public int Idade {get; private set;}
        public bool Dormindo = true;

        public Pessoa(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }

        public void Acordar() {
            Console.WriteLine($"{Nome} acabou de acordar...");
            Dormindo = false;
        }
    }

    class Padeiro(string nome, int idade) : Pessoa(nome, idade)
    {
        public string Profissao = "Padeiro";

        public void Trabalhar() {
            if(Dormindo == true) {
                Console.WriteLine("O Padeiro não pode trabalhar agora... Ele está DORMINDO, precisa ACORDAR!");
            } else {
                Console.WriteLine("Ele começou a trabalhar, está abrindo a padaria, fazendo os pãos...");
            }
        }

        public void Dormir() {
            Console.WriteLine($"Após um longo dia o padeiro {Nome} irá dormir...");
            Dormindo = true;
        }

        public override string ToString() {
            return $"{Nome}\nIdade: {Idade}\nProfissão: {Profissao}";
        }
    }
}