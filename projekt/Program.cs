using System;
using System.IO;
using System.Text;

namespace projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("C:/Users/ALEX/source/repos/projekt/projekt/TextFile1.txt");
            Console.WriteLine("zakodovat alebo dekodovat?");
            string vyber = Console.ReadLine();

            Console.WriteLine("aky je posun sifry?");
            int posun = int.Parse(Console.ReadLine());
            string text = sr.ReadLine();
            static string koduj(string text,int posun)
            {
                string vysledok = "";
                Console.WriteLine(text);
                foreach (char c in text)
                {
                    if (c!=' ')
                    {
                        int index = c + posun % 256;

                        vysledok += (char)index;
                    }
                }
                return vysledok;
            }
            static string dekoduj(string text,int posun)
            {
                string vysledok = "";
                foreach (char c in text)
                {
                    if (c != ' ')
                    {
                        int index = c - posun % 256;

                        vysledok += (char)index;
                    }
                }
                return vysledok;
            }
            sr.Close();
            StreamWriter sw = new StreamWriter("C:/Users/ALEX/source/repos/projekt/projekt/TextFile1.txt", false);

            if (vyber == "zakodovat")
            {
                Console.WriteLine(koduj(text,posun) + "-zakodovane");
                sw.WriteLine(koduj(text, posun) + "-zakodovane");
            }
            else if (vyber == "dekodovat")
            {
                Console.WriteLine(dekoduj(text,posun) + "-dekodovane");
                sw.WriteLine(dekoduj(text, posun) + "-dekodovane");
            }
            sw.Close();
            
        }
    }
}