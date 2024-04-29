using System;
using System.Collections.Generic;

namespace Ex17
{
    public class Program
    {
        public static void Main(string[] args)
        {
            HashSet<int> courseA = new HashSet<int>();
            HashSet<int> courseB = new HashSet<int>();
            HashSet<int> courseC = new HashSet<int>();

            Console.Write("How many students for course A? ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseA.Add(cod);
            }

            Console.Write("How many students for course B? ");
            int b = int.Parse(Console.ReadLine());
            for (int i = 0; i < b; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseB.Add(cod);
            }

            Console.WriteLine("How many students for course C? ");
            int c = int.Parse(Console.ReadLine());
            for (int i = 0; i < c; i++) {
                int cod = int.Parse(Console.ReadLine());
                courseC.Add(cod);
            }

            HashSet<int> all = new HashSet<int>(courseA);
            all.UnionWith(courseB);
            all.UnionWith(courseC);

            Console.WriteLine("Total students: " + all.Count);
        }
    }
}