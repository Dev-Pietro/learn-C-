using System;

namespace Matrizes_ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string[] fraudlentOrderIDs = new string[3];

            fraudlentOrderIDs[0] = "A123";
            fraudlentOrderIDs[1] = "B456";
            fraudlentOrderIDs[2] = "C789";
            */
            string[] suspects = {"Batman", "Robin", "Joker"}; 
            foreach (string name in suspects)
            {
                Console.WriteLine(name);
            };

            int[] inventory = {200, 100, 50};
            int totalPrice = 0;
            int bin = 0;
            foreach (int price in inventory)
            {
                totalPrice += price;
                bin++;
                Console.WriteLine($"Bin {bin}: {price} (Total: {totalPrice})");
            };

            Console.WriteLine($"Inventory Price: {totalPrice}.");

        }
    }
}