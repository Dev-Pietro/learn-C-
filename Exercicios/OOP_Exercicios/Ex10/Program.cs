using System;
using Ex10.Entities;
using Ex10.Entities.Enums;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Client Data: ");
            Console.WriteLine("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Birth Date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());
            Client c1 = new Client(name, email, birthDate);

            Console.WriteLine("------------------------");
            Console.WriteLine("Enter Order Data:");
            Console.WriteLine("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.WriteLine("How many items to this order:");
            int n = int.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;

            Order order = new Order(now, status, c1);

            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Enter #{i} item data:");
                Console.WriteLine("Product name: ");
                string pName = Console.ReadLine();
                Console.WriteLine("Price: ");
                double pPrice = double.Parse(Console.ReadLine());   
                Console.WriteLine("Quantity: ");
                int pQuan = int.Parse(Console.ReadLine());

                Product product = new Product(pName, pPrice);
                OrderItem orderItem = new OrderItem(pQuan, pPrice, product);

                order.AddItem(orderItem);
                Console.WriteLine("");
            }
            Console.WriteLine("");
            Console.WriteLine(order);

        }
    }
}