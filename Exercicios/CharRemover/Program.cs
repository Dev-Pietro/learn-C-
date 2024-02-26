using System;

namespace CharRemover
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type a word:");
            string userWord = Console.ReadLine();
            Console.WriteLine("Which character you want to remove ?"); 
            string charWant = Console.ReadLine();
            string wordWithCharRemove = "";
            
            for (int count = 0; count < userWord.Length; count++)
            {
                if (userWord[count].ToString() == charWant) {
                    continue;
                }
                wordWithCharRemove += userWord[count].ToString();
            }

            Console.WriteLine($"The word with the specified character removed: {wordWithCharRemove}");
        }
    }
}


