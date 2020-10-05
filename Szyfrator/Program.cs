using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrator
{
    class Program
    {
        public static char[,] tablica = new char[,] 
        {
        {'a', '@' },
        {'s', '$' },
        {'i', '!' },
        {'e', '3' }
        
        };
        static void Main(string[] args)
        {
            
            
            
            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();


            for (int i = 0; i < (tablica.Length / 2); i++)
            {
                Console.Write("Zamieniam " + tablica[i, 0]);
                Console.WriteLine(" na " + tablica[i, 1]);
                tekst = tekst.Replace(tablica[i, 0], tablica[i, 1]);

            }

            

            Console.WriteLine(tekst);

            Main(args);
        }
    }
}
