using System;
using Ex08.Entities;
using Ex08.Entities.Enums;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter department's name:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.WriteLine("Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Level (Junior/MidLevel/Senior):");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine()); //convertendo a string para enum workerlevel
            Console.WriteLine("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine());
            //primeira parte declarando as variaveis das instancias que serão utilizadas desde o enum, até o department e de worker, seguindo a logica das instancias


            Department dept = new Department(deptName);
            Worker worker= new Worker(name, level, baseSalary, dept);
            //atribuindo os inputs do usuario nas respectivas classes

            Console.WriteLine("How many contracts to this worker ?");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} contract data:\nDate (DD/MM/YYYY):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour:");
                double valuePerHour = double.Parse(Console.ReadLine());
                Console.WriteLine("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());  
                HourContract contract = new HourContract(date, valuePerHour, hours);

                worker.AddContract(contract); //adicionando o contrato criado na lista do parametro da classe worker
            }
            //segunda parte iterando na quantidade de contrator que o worker tem e em seguida pegando os parametros para armazenar na classe HourContract

            Console.WriteLine("Enter month and year to calculate income (MM/YYYY):");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine($"Name: {worker.Name}\nDepartment: {worker.Department.Name}\nIncome for {monthAndYear}: {worker.Income(month, year):N2}");
            //terceira parte calculando income do respectivo mes e ano do worker e em seguida mostrando na tela
        }
    }
}
