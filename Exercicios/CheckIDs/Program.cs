using System;

namespace CheckIDs
{
    class Program
    {
        static void Main(string[] args)
        {
            string ids = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] arrayIds = ids.Split(',');
            Array.Sort(arrayIds);
            foreach (string id in arrayIds) {
                if(id.Length == 4) {
                    Console.WriteLine(id);
                    continue;
                }
                Console.WriteLine($"{id}\t- Error");
            }
        }
    }
}