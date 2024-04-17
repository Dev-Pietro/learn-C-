using System;

namespace Matriz_13
{
    class Program
    {
        static void Main(string[] args)
        {
           double[,] mat = new double[2, 3]; //matriz bidimensional - 2 linhas e 3 colunas

           Console.WriteLine(mat.Length); //quantos elementos tem no total

           Console.WriteLine(mat.Rank); //quantas linhas tem no total
        }
    }
}