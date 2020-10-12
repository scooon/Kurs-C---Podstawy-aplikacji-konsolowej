using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Szyfrator
{
    class Program
    {

        static void Main(string[] args)
        {

            char[,] tablica = new char[400, 2];

            
            string klucz = "g\\]C'H{Mm>YBY!$nv]d\"qTv:.Q9V5 / x]pd9w7p(Pz3 < Y\"Jx8~k)AWzL'~h_(xUQzxV327.hk2kCng+VA''w8z{?;?FBM@"; // 93 characters to full security

            for (int i = 0; i < klucz.Length; i++)
            {
                tablica[i, 0] = (char)(i+33);
                tablica[i, 1] = klucz[i];


            }

            Console.WriteLine("Podaj tekst");
            string tekst = Console.ReadLine();


            for (int i = 0; i < (tablica.Length / 2); i++)
            {
                Console.Write("Zamieniam " + tablica[i, 0]);
                Console.WriteLine(" na " + tablica[i, 1]);
                tekst = tekst.Replace(tablica[i, 0], tablica[i, 1]);

            }


            Console.WriteLine("Zaszyfrowany tekst:");
            Console.WriteLine(tekst);
            Console.WriteLine("Odszyfrowany tekst:");

            //Odszyfrowanie nie działa

            for (int i = 0; i < tekst.Length; i++)
            {
 
                tekst = tekst.Replace(tablica[i, 1], tablica[i, 0]);

            }

            Console.WriteLine(tekst);

            Main(args);
        }
    }
}
