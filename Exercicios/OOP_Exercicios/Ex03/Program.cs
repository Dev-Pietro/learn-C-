using System; 

namespace Ex03
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno alunoUm = new Aluno();

            Console.WriteLine("Nome do Aluno:");
            alunoUm.Nome = Console.ReadLine();
            
            Console.WriteLine("Digite as notas dos 3 Bimestres (0 - 10,00)");
            alunoUm.NotaUm = double.Parse(Console.ReadLine());
            alunoUm.NotaDois = double.Parse(Console.ReadLine());
            alunoUm.NotaTres = double.Parse(Console.ReadLine());

            alunoUm.MediaFinal();
        }
    }
}