using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What you want to do ?");
            Console.WriteLine("1 - Open a file");
            Console.WriteLine("2 - Create a new file");
            Console.WriteLine("0 - Exit");
            short option = short.Parse(Console.ReadLine());

            switch (option) {
                case 0: System.Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
                default: Menu(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("What path of file ?");
            string path = Console.ReadLine();

            using(var file = new StreamReader(path))
            {
                string text = file.ReadToEnd();
                Console.WriteLine(text);
            }

            Console.WriteLine("");
            Console.ReadLine();
            Menu();
        }

        static void Edit()
        {
            Console.Clear();
            Console.WriteLine("Type your text bellow (ESC to exit)");
            Console.WriteLine("----------------------");
            string text = "";

            do 
            {
                text += Console.ReadLine();
                text += Environment.NewLine; //colocando nova linha a cada fim de escrita
            }
            while(Console.ReadKey().Key != ConsoleKey.Escape); //enquanto usuario não apertar ESC não irá sair

            Save(text);
        }
    
        static void Save(string text)
        {
            Console.Clear();
            Console.WriteLine("What path to save this file ?");
            var path = Console.ReadLine();

            using (var file =  new StreamWriter(path)) //abrindo e fechando o arquivo através do caminho e com StreamWriter
            {   
                file.Write(text);
            }

            Console.WriteLine($"File {path} saved successfully !");
            Console.ReadLine();
            Menu();
        }
    }
}


