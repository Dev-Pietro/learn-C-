using System; 

namespace Ex08.Entities
{
    class Department
    {
        //classe que possui o nome do departamento a ser associado com worker
        public string Name { get; set;}

        public Department() {
        }

        public Department(string name) {
            Name = name;
        }
    }
}