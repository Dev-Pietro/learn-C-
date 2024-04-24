using System;
using Ex12.Entities;


namespace Ex12.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override string PriceTag()
        {
            return $"{Name} (used) ${Price:N2} (Manufacture Date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}