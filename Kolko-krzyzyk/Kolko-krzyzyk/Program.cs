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
        private static int kto()
                {
                    
                    #region Poziomo
                    if (tablica[1] == tablica[2] && tablica[2] == tablica[3])
                    {
                        return 1;
                    }
                    else if (tablica[4] == tablica[5] && tablica[5] == tablica[6])
                    {
                        return 1;
                    }
                    else if (tablica[6] == tablica[7] && tablica[7] == tablica[8])
                    {
                        return 1;
                    }
                    #endregion
         
                    #region Pionowo
                    else if (tablica[1] == tablica[4] && tablica[4] == tablica[7])
                    {
                        return 1;
                    }
                    else if (tablica[2] == tablica[5] && tablica[5] == tablica[8])
                    {
                        return 1;
                    }
                    else if (tablica[3] == tablica[6] && tablica[6] == tablica[9])
                    {
                        return 1;
                    }
                    #endregion
                    
                    #region Remis
                    else if (tablica[1] != '1' && tablica[2] != '2' && tablica[3] != '3' && tablica[4] != '4' && tablica[5] != '5' && tablica[6] != '6' && tablica[7] != '7' && tablica[8] != '8' && tablica[9] != '9')
                    {
                        return -1;
                    }
                    #endregion
         
                    #region Skos
                    else if (tablica[1] == tablica[5] && tablica[5] == tablica[9])
                    {
                        return 1;
                    }
                    else if (tablica[3] == tablica[5] && tablica[5] == tablica[7])
                    {
                        return 1;
                    }
                    #endregion
        
                    else
                    {
                        return 0;
                    }
                }
    }
}