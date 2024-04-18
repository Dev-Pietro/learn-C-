using System;
using Enum_14.Entities.Enums; //"importando" o enum que foi criado na pasta enums

namespace Enum_14.Entities
{
    class Order
    {
        public int Id { get; set;}
        public DateTime Moment { get; set; } //tipo datetime - horario em que foi feito o pedido
        public OrderStatus Status { get; set; } //recebe o tipo enum OrderStatus criado na pasta Enums

        public override string ToString() { 
            return $"{Id}, {Moment}, {Status}";
        }
    }
}