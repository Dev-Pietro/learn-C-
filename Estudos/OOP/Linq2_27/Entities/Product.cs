using System;

namespace Linq2_27.Entities
{
    class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }

        public override string ToString() {
            return $"{Id}, {Name}, {Price:N2}, {Category.Name}, {Category.Tier}";
        }
    }
}