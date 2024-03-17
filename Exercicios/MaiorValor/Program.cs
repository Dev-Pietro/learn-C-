using System;
using System.Globalization;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = {3, 5, 20, 10, 2};
            var h_val = nums[0];

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] > h_val)
                    h_val = nums[i]; 
            }

            Console.WriteLine(h_val);
        }
    }
}