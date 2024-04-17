using System;

namespace Ex07
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; private set; }
        public double Salary { get; private set; }

        public Employee(string name, int id, double salary) {
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void IncreaseSalary(double n) {
            Salary += Salary * n / 100;
        }

        public override string ToString() {
            return $"Id: {Id}, Name: {Name}, Salary: {Salary:N2}";
        }
    }
}