using System;
using System.Globalization;

namespace Comparison_23.Entities
{
    public class Product  
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Product(string name, int price) {
            Name = name;
            Price = price;
        }

        public override string ToString() {
            return Name + ", " + Price;
        }
    }
}