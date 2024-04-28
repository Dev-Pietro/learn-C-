using System;
using System.Collections.Generic;

namespace Conjuntos_21
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conjuntos - alterantiva a List e Array, não aceita duplicatas e possui algumas funções
            //HashSet<string> set = new HashSet<string>();       

            //SortedSet - sempre mostra em ordem
            SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //union
            SortedSet<int> c = new SortedSet<int>(a); //inserindo no conjunto c todos os elementos do a
            c.UnionWith(b);
            PrintCollection(c);


            //intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b); //mostra os elementos que possui nos 2 conjuntos, intersecção
            PrintCollection(d);

            //diference
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);
            PrintCollection(e);
        }

        //IEnumerable - Interface implementada por todas as coleções básicas de System.Collection
        static void PrintCollection<T>(IEnumerable<T> collection)  
        {
            foreach (T obj in collection)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine("");
        }
    }
}
