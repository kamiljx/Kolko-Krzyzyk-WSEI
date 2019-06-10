using System;
using System.Threading;
 
namespace KolkoKrzyzyk
{
    class Program
    {
  
        static char[] tablica = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int Gracz = 1;   
        static int wybor;   
        static int ktowygral = 0;
 
        static void Main(string[] args)
        {
            do
            {
                Console.Clear(); 
                Console.WriteLine("\n");
                if (Gracz % 2 == 0)  
                {
                    Console.WriteLine("Ruch gracz 2");
                }
                else
                {
                    Console.WriteLine("Ruch gracza 1");
                }
                Console.WriteLine("\n");
                Plansza();  
                wybor = int.Parse(Console.ReadLine());   
 
                if (tablica[wybor] != 'X' && tablica[wybor] != 'O')
                {
                    if (Gracz % 2 == 0)  
                    {
                        tablica[wybor] = 'O';
                        Gracz++;
                    }
                    else
                    {
                        tablica[wybor] = 'X';
                        Gracz++;
                    }
                }
                else 
                {
                    Console.WriteLine("Pole {0} jest już zajęte przez {1}", wybor, tablica[wybor]);
                    Console.WriteLine("\n");
                    Thread.Sleep(2000);
                }
                ktowygral = kto();  
            } while (ktowygral != 1 && ktowygral != -1); 
 
            Console.Clear();  
            Plansza();  
 
            if (ktowygral == 1)
            {
                Console.WriteLine("Wygrywa {0} ", (Gracz % 2) + 1);
            }
            else 
            {
                Console.WriteLine("Remis");
            }
            Console.ReadLine();
        }
        private static void Plansza()
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
