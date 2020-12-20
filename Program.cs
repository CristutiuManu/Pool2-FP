using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Pool2_Tablouri
{
    class Program
    {

        static void CateNumerePare()
        {
            // Se da o secventa de n numere. Sa se determine cate din ele sunt pare
            int n = int.Parse(Console.ReadLine());

            int x = n;
            int contor = 0;

            Console.WriteLine($"Numarul este: {x}");
            while(x!=1)
            {
                if (x % 2 == 0)
                    contor++;

                x--;
            }



            Console.WriteLine($"Numarul de elemente pare sunt: {contor}");





        }
        static void CateNumereNegativeSiPozitive()
        {
            // Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.
            Console.WriteLine("Introdu un numar negativ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu un numar pozitiv");
            int m = int.Parse(Console.ReadLine());
            int x = n;

            int contorPozitive = 0;
            int contorNegative = 0;
            int contorZerouri = 0;
            while (n <= m)
            {
                if (m > 0)
                    contorPozitive++;
                else if (m < 0)
                    contorNegative++;
                else if (m == 0)
                    contorZerouri++;
                m--;
            }

            Console.WriteLine($"Numarul de elemente negative este: {contorNegative},numarul de elemente cu zerouri este: {contorZerouri}, iar numarul de elemente pozitive este {contorPozitive}");

        }

        static void Main(string[] args)
        {
            // CateNumerePare();
            CateNumereNegativeSiPozitive();
        }
    }
}
