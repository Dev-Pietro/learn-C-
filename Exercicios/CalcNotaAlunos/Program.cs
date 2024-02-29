using System;

namespace CalcNotaAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            float sophia1 = 8.5f;
            float sophia2 = 6f;
            float sophia3 = 5.5f;

            float nicolas1 = 9.5f;
            float nicolas2 = 7.5f;
            float nicolas3 = 10f;

            float paulo1 = 5.5f;
            float paulo2 = 9.75f;
            float paulo3 = 8f;

            Console.WriteLine($"Estudantes\tMAT\tPOR\tHIS\tMédia\n");
            Console.WriteLine($"Sophia\t\t{sophia1}\t{sophia2}\t{sophia3}\t{Media(sophia1, sophia2, sophia3).ToString("F")}\n");
            Console.WriteLine($"Nicolas\t\t{nicolas1}\t{nicolas2}\t{nicolas3}\t{Media(nicolas1, nicolas2, nicolas3).ToString("F")}\n");
            Console.WriteLine($"Paulo\t\t{paulo1}\t{paulo2}\t{paulo3}\t{Media(paulo1, paulo2, paulo3).ToString("F")}\n");
        }

        static float Media(float nota1, float nota2, float nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }
    }
}
