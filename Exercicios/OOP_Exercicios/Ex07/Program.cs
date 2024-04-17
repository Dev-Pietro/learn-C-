using System;
using System.Collections.Generic;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many employees will be registered ?");
            int countEmployees = int.Parse(Console.ReadLine());

            List<Employee> list = new List<Employee>();

            for (int i = 1; i <= countEmployees; i++) { 
                Console.WriteLine($"Employee #{i}\nId:");
                int idEmployee = int.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Salary:");
                double salaryEmployee = double.Parse(Console.ReadLine());

                list.Add(new Employee(name, idEmployee, salaryEmployee));
            }

            Console.WriteLine("Enter the employee id that will have salary increase:");
            int searchId = int.Parse(Console.ReadLine());

            Employee emp = list.Find(x => x.Id == searchId);

            if(emp != null) {
                Console.WriteLine("Porcentage:");
                double porcentage = double.Parse(Console.ReadLine());
                emp.IncreaseSalary(porcentage);
            } else {
                Console.WriteLine("This ID does not exist !");
            }

            Console.WriteLine("");
            Console.WriteLine("Updated list of employees !");
            foreach(Employee obj in list) {
                Console.WriteLine(obj);
            }
        }
    }
}