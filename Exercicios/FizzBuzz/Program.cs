﻿using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++) {

                if(i % 3 == 0 && i % 5 == 0) {
                    Console.WriteLine($"{i} - FizzBuzz");
                    continue;
                } else if(i % 3 == 0) {
                    Console.WriteLine($"{i} - Fizz");
                    continue;
                } else if(i % 5 == 0) {
                    Console.WriteLine($"{i} - Buzz");
                    continue;
                }
                
                Console.WriteLine($"{i}");
            }
        }
    }
}