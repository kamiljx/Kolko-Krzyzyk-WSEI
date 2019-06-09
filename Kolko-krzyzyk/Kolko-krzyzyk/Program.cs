using System;

namespace Kolko_krzyzyk
{
    internal class Program
    {
        static char[] tablica = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        public static void Main(string[] args)
        {
            Plansza();
        }

        public static void Plansza()
        {
            Console.WriteLine("     █     █      ");
            Console.WriteLine("  {0}  █  {1}  █  {2}", tablica[1], tablica[2], tablica[3]);
            Console.WriteLine("■■■■■■■■■■■■■■■■");
            Console.WriteLine("     █     █      ");
            Console.WriteLine("  {0}  █  {1}  █  {2}", tablica[4], tablica[5], tablica[6]);
            Console.WriteLine("■■■■■■■■■■■■■■■■");
            Console.WriteLine("     █     █     ");
            Console.WriteLine("  {0}  █  {1}  █  {2}", tablica[7], tablica[8], tablica[9]);
        }
    }
}