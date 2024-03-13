using System;

namespace ReversePhrase
{
    class Programming
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a Phrase:");
            var phrase = Convert.ToString(Console.ReadLine());

            char[] phraseArray = phrase.ToCharArray();
            Array.Reverse(phraseArray);

            string phraseReverse = new string(phraseArray);

            Console.WriteLine($"Reverse Phrase: {phraseReverse}");
        }
    }
}