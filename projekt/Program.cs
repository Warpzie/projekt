using System;
using System.IO;

namespace projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader subor = new StreamReader("C:/Users/ALEX/source/repos/projekt/projekt/TextFile1.txt");
            Console.WriteLine("zakodovat alebo dekodovat?");
            string vyber = Console.ReadLine();

            Console.WriteLine("aky je posun sifry?");
            int posun = int.Parse(Console.ReadLine());
            while (true)
            {
                string text = subor.ReadLine();
                if (text == null)
                {
                    break;
                }
            }
        }
    }
}