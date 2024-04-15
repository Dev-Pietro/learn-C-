using System;
using System.Collections.Generic;

namespace List_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //vantagens da lista: tamanho variavel, facilidade para acrescentar elementos
            List <string> list = new List<string>();
            // List <string> list2 = new List<string> { "João", "Gabriel" };
            list.Add("Gabriel");
            list.Add("João");
            list.Add("Samuel");
            list.Add("Pedro"); ;
            list.Insert(2, "Pardo"); //insere no indice 2 da lista a string Pardo, empurrando os items da lista para frente
            Console.WriteLine(list[0]);

            string s1 = list.Find(x => x[0] == 'S'); //acha primeiro valor na lista atraves de func lambda
            Console.WriteLine($"First 'S': {s1}");

            string s2 = list.FindLast(x => x[0] == 'P'); //acha o ultimo valor que começa com parametro
            Console.WriteLine($"Last 'P': {s2}");

            int pos1 = list.FindIndex(x => x[0] == 'P');
            Console.WriteLine($"First Position 'P': {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'P');
            Console.WriteLine($"Last Position 'P': {pos2}");

            //filtra a lista antiga guardando em uma nova apenas os items da antiga que tinham tamanho de 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5); 
            Console.WriteLine("-----------------");
            foreach(string i in list2) {
                Console.WriteLine(i);
            };

            Console.WriteLine("----------------");
            list.Remove("Gabriel"); //remove um item com este parametro da lista
            foreach(string i in list) {
                Console.WriteLine(i);
            };

            Console.WriteLine("----------------");
            list.RemoveAll(x => x[0] == 'P'); //remove todas da lista que começam com P
            foreach(string i in list) {
                Console.WriteLine(i);
            };

            Console.WriteLine("----------------");
            list.RemoveAt(0); //remove pelo indice
            foreach(string i in list) {
                Console.WriteLine(i);
            };
        }
    }
}