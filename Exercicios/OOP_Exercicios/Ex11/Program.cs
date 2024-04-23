using System;
using System.Collections.Generic;
using Ex11.Entities;


namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Employee #{i} Data:");
                Console.WriteLine("Outsourced [y/n] ?");
                char ch = char.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Hours:");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per Hour:");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (ch == 'y') {
                    Console.WriteLine("Aditional Charge:");
                    double aditionalCharge = double.Parse(Console.ReadLine());
                    list.Add(new OutsourcedEmployee(name, hours, valuePerHour, aditionalCharge));
                }
                else {
                    list.Add(new Employee(name, hours, valuePerHour));
                }
            }

            Console.WriteLine("Payments:");

            foreach (Employee emp in list)
            {
                Console.WriteLine($"{emp.Name} ${emp.Payment():N2}");
            }
        }

    }
}