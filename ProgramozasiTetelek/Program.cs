using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    class Program
    {

        static int[] tomb = new int[] {12, 7, 2, 4, 45, 99, 1, 8, 95, 50 };

        static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write("{0}, ", tomb[i]);
            }
            
        }

        static void Osszegzes()
        {
            Console.WriteLine("\nÖsszegzés tétele");
            int osszes = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                osszes += tomb[i];
            }
            Console.WriteLine("{0}",osszes);
        }

        static void Megszamolas()
        {
            Console.WriteLine("Megszámolás tétele");
            int darab = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i] % 3 == 0)
                {
                    darab++;
                }
            }
            Console.WriteLine("{0} 3-al osztható elem van", darab);
        }

        static void Eldontes()
        {
            Console.WriteLine("Eldöntés tétele");
            int i = 0;
            while (i < tomb.Length && tomb[i] != 69 )
            {
                i++;
            }

            if (i < tomb.Length)
            {
                Console.WriteLine("Van a tömbben 69.");
            }
            else
            {
                Console.WriteLine("Nincs a tömbben 69.");
            }
        }

        static void Kivalasztas()
        {
            Console.WriteLine("Kiválasztás tétele");
            int i = 0;
            while (tomb[i] != 50)
            {
                i++;
            }
            Console.WriteLine("Az 50 a {0}. a tömbben.", i + 1);
        }

        static void Kereses()
        {
            Console.WriteLine("Keresés tétele");
            int i = 0;
            while (i < tomb.Length && tomb[i] != 50)
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("Van benne 50 és a {0}. helyen/ {1}. indexű helyen van.", i + 1, i);
            }
            else
            {
                Console.WriteLine("Nincs benne 50.");
            }
        }

        static void Main(string[] args)
        {
            TombKiiras();
            Console.WriteLine();

            Osszegzes();
            Console.WriteLine();

            Megszamolas();
            Console.WriteLine();

            Eldontes();
            Console.WriteLine();

            Kivalasztas();
            Console.WriteLine();

            Kereses();
            Console.WriteLine();

            Console.ReadKey();
        }

        
    }
}
