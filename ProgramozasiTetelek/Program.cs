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
        static void Main(string[] args)
        {
            TombKiiras();

            Osszegzes();

            Megszamolas();

            Eldontes();

            Console.ReadKey();
        }

       
    }
}
