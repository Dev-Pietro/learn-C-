using System;
using Enum_14.Entities;
using Enum_14.Entities.Enums;

namespace Enum_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment,
            };

            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString(); //converte o tipo enum para string

            OrderStatus os = Enum.Parse<OrderStatus>("Delivered"); //converte a string para o tipo enum

            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
