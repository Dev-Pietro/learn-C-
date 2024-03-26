using System;

namespace MetodosArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "abcde12345";
            char[] valueArray = value.ToCharArray(); //Convert string to char array

            foreach(char x in valueArray){
                Console.WriteLine($"Value - {x}");
            }

            string result = String.Join("-", valueArray); //Convert array to separate string with "-"
            Console.WriteLine(result);

            string[] items = result.Split("-"); //Separate the array with the char that you want
            foreach(string i in items) {
                Console.WriteLine(i);
            }

        }
    }
}
