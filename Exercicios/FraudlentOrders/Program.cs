using System;

namespace FraudlentOrders
{
    class Program
    {
        static void Main(string[] args)
        {
            //orders that starts with B have a greater chance to be a fraudlent
            string[] orders = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};
            int index = 0;
            foreach (string order in orders)
            {
                index++;
                if (order.StartsWith("B")) {
                    Console.WriteLine($"Fraudlent order founded: {order} (Order {index})");
                }
            }
        }
    }
}