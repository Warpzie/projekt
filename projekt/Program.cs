﻿using System;
using System.IO;

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
            string text = sr.ReadLine(); //nacitanie obsahu suboru
            static string koduj(string text,int posun) //text - obsah suboru, psosun / o kolko sa posuva
            {
                string vysledok = ""; //prazdny string na ukladanie
                Console.WriteLine(text);
                foreach (char c in text) //pre kazdy znak
                {
                    if (c!=' ') //ak nieje medzera
                    {
                        int index = c + posun % 256; //posunutie sifry a zabezpecenie aby hodnota bola vzdy medzi 0 a 255 

                        vysledok += (char)index; //prelozenie a pridanie znaku
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
            StreamWriter sw = new StreamWriter("C:/Users/ALEX/source/repos/projekt/projekt/TextFile1.txt", false); //preco tam je false?

            if (vyber == "zakodovat")
            {
                Console.WriteLine(koduj(text,posun) + "-zakodovane"); //pre mna,nemusi byt
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