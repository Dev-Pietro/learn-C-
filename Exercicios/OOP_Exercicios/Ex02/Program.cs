using System;

namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            CriaFuncionario func1, func2;
            func1 = new CriaFuncionario();
            func2 = new CriaFuncionario();

            Console.WriteLine("DIGITE O NOME E O SALÁRIO DO SEU FUNCIONARIO 01:");
            func1.nome = Console.ReadLine();
            func1.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("DIGITE O NOME E O SALÁRIO DO SEU FUNCIONARIO 02:");
            func2.nome = Console.ReadLine();
            func2.salario = double.Parse(Console.ReadLine());

            double salarioMedio = (func1.salario + func2.salario) / 2;

            Console.WriteLine($"DADOS FUNCIONARIO 01\nNome: {func1.nome}\nSalário: {func1.salario}\nDADOS FUNCIONARIO 02\nNome: {func2.nome}\nSalário: {func2.salario}");
            Console.WriteLine($"Salário médio = {salarioMedio}");
        }
    }
}