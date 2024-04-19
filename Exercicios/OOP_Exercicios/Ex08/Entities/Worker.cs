using System;
using System.Collections.Generic;
using Ex08.Entities.Enums;

namespace Ex08.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; } //instancia do tipo enum que foi criado
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //associando a classe Department com worker, composição
        public List<HourContract> Contracts { get; set; } = new List<HourContract>(); //recebe uma lista da classe de contratos, pois um trabalhador pode possuir varios contratos

        //sempre que tiver uma associação para muitos, como uma lista, não se deve instanciar ela no construtor, pois
        //ela será adicionada em outras funções, por isso ela foi inicializada acima e não coloca no construtor

        public Worker(){
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department) {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract) {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract) {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month) {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts) {
                if (contract.Date.Year == year && contract.Date.Month == month) {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }
    }
}