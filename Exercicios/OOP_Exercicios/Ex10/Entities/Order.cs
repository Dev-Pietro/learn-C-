using System;
using System.Text;
using System.Collections.Generic;
using Ex10.Entities.Enums;

namespace Ex10.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order(){}

        public Order(DateTime moment, OrderStatus status, Client client) {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item) {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item) {
            OrderItems.Remove(item);
        }

        public double Total() {
            double sum = 0;
            foreach (OrderItem item in OrderItems) {
                sum += item.SubTotal();
            }

            return sum;
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("ORDER SUMMARY:");
            sb.Append("Order Moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.AppendLine($"{Client.Name} {Client.BirthDate.ToString("dd/MM/yyyy")} - {Client.Email}");
            sb.AppendLine("Order Items:");
            foreach(OrderItem item in OrderItems) { 
                sb.AppendLine($"{item.Product.Name}, ${item.Price}, Quantity: {item.Quantity}, Subtotal: ${item.SubTotal():N2}");
            }
            sb.AppendLine($"Total price: ${Total().ToString():N2}");

            return sb.ToString();

        }
    }
}