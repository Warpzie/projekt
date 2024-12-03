using System;
using System.IO;
using System.Text;

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
            string text = subor.ReadLine();
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
            if (vyber == "zakodovat")
            {
                Console.WriteLine(koduj(text,posun));
                

                /* byte[] bytes = Encoding.ASCII.GetBytes(text);
                int encoded = BitConverter.ToInt32(bytes, 0);
                Console.WriteLine(encoded);
                int kodovanie = encoded + posun;
                string vysledok = Convert.ToChar(kodovanie);
                Console.WriteLine(vysledok);
                */
            }
            
            
        }
    }
}