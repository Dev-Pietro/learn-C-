using System;

namespace Enum_14.Entities.Enums
{
    //Enum - tipo especial que serve para especificar de forma literal um conjunto de constantes relacionadas
    //como no exemplo abaixo nos status de um pedido (pagamento pendente, processando, enviado e entregue)
    enum OrderStatus : int   //herda o tipo base int
    {
        PendingPayment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3

    }
}