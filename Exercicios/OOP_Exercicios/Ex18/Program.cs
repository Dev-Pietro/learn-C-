using System;
using System.Collections.Generic;
using System.IO;

namespace Ex18
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    while (!sr.EndOfStream) {
                        string line = sr.ReadLine();
                        string[] vect = line.Split(',');
                        string name = vect[0];
                        int votes = int.Parse(vect[1]);

                        if (users.ContainsKey(name)) {
                            users[name] += votes;
                        }
                        else {
                            users[name] = votes;
                        }
                    }

                    foreach (KeyValuePair<string, int> item in users) { 
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException e) {
                Console.WriteLine(e.Message);
            }
        }
    }
}