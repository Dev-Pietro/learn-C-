using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq1_26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Specify the Data Source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            //Define the query expression
            var result = numbers.Where(x => x % 2 == 0).Select(x => x * 10); 

            //Execute the query expression
            foreach (int x in result)
            {
                Console.WriteLine(x); //20 - 40
            }
        }
    }
}