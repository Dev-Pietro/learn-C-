using System;

namespace RefOut_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            // Calculator.Triple(ref a); 
            // Console.WriteLine(a);
            //ref - referencia ao metodo da classe a variavel do escopo main que será mudada, no caso variavel a 
            //no metodo triple

            int doubleVal;
            Calculator.Double(a, out doubleVal);
            Console.WriteLine(doubleVal);
            //out - guarda o valor executado no metodo double na variavel inicializada, utilizado para guardar valores
            //em variaveis que foram apenas inicializas e não possuem algum valor (ainda)
        }
    }
}
