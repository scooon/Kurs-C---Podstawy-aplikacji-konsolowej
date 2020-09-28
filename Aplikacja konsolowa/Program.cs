using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplikacja_konsolowa
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbę");
                int numer = Int32.Parse(Console.ReadLine());


                if (numer <= 50)
                {
                    Console.WriteLine("Tak! Liczba jest mniejsza lub równa 50");
                }
                else
                {
                    Console.WriteLine("Nie! Liczba jest większa od 50");
                }

                Console.ReadLine();
            }
            catch
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Wpisana wartość musi być cyfrą!");
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
                Main(args);
            }

            Main(args);
        }
    }
}
