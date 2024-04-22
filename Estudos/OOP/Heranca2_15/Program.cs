using System;
using Heranca2_15.Entities;

namespace Heranca2_15
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new BusinessAccount(8010, "Bob", 100, 500);

            account.Balance = 10;

            Console.WriteLine(account.Balance); //forçando o erro para mostrar o uso de protected;
                                                //que deixa o atributo da superclass só poder ser alterado de classes que derivam dele, ou subclasses 
        }
    }
}
