using System;

namespace Guids
{
    class Program 
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid(); //gera um id novo
            id.ToString();
            Console.WriteLine(id);
        }
    }
}