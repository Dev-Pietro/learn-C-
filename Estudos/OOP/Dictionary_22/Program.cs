using System;
using System.Collections.Generic;

namespace Dictionary_22
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //possui uma chave e um valor
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            //       chave      valor
            cookies["user"] = "Maria";
            cookies["email"] = "mariadb@gmail.com";
            cookies["phone"] = "11 999999";
            cookies["phone"] = "11 888888"; //sobreescreve o phone acima, pois dicts não aceitam repetição

            Console.WriteLine(cookies["user"]); //print: Maria
            Console.WriteLine(cookies["email"]); //print: mariadb@gmail.com

            cookies.Remove("email"); //remove a chave email junto com seu valor

            if (cookies.ContainsKey("email")) { //verifica se o dict cookies contem a chave email
                Console.WriteLine(cookies["email"]);
            } else {
                cookies.Remove("There is not email in this dict");
            }

            Console.WriteLine("Size: " + cookies.Count);

            Console.WriteLine("ALL COOKIES");
            foreach (KeyValuePair<string, string> item in cookies) { //como iterar em um dict
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
    }
}
