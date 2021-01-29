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
        static void SumaSiProdusulNumerelor()
        {
            // Calculati suma si produsul numerelor de la 1 la n.
            Console.WriteLine("Introdu numarul: ");
            int n = int.Parse(Console.ReadLine());
            int suma = 0, produs = 1;
            int x = n;

            for (int i = n; i >= 1; i--)
            {
                suma += i;
                produs *= i;
            }

            Console.WriteLine($"suma: {suma} si produsul: {produs}");
        }

        public static double getNumber()
        {
            string line;
            bool valid;
            double numar = 0;
            do
            {
                valid = true;
                line = Console.ReadLine();
                try
                {
                    numar = double.Parse(line);
                }
                catch (Exception)
                {
                    valid = false;
                    Console.WriteLine("Please don't do 'funny' things");
                }
            } while (!valid);

            return numar;
        }


        static void DeterminarePozitie()
        {
            // Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a.
            // Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
            Console.WriteLine("Introdu secventa de n numere: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Introdu numarul pe care doresti sa il afli:");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i ++)
            {
                for(int j = 0; j >= i; j++)
                {
                    if (j == a)
                    {
                        Console.WriteLine($"Numarul {a} se afla pe pozitia {j}");
                    }
                }
                //Console.Write(i + " ");
            }



        }


        private static void MaximDeNumereConsecutive()
        {
            Console.Write("Primul element: ");
            double x = (int)getNumber();
            double a = int.MaxValue;
            double b = int.MinValue;
            int consecutivCounter = 0;
            int maxCons = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    a = x;
                else
                    b = x;

                if (a == b)
                {
                    consecutivCounter++;
                    if (consecutivCounter > maxCons)
                    {
                        maxCons = consecutivCounter;
                    }
                }
                else
                {
                    consecutivCounter = 0;
                }
                Console.Write($"{x} ");
                x = Math.Pow(-1, i) * Math.Round((x / 3) * 2);
            }

            Console.WriteLine($"Cel mai lung cifra consecutive: {maxCons + 1}");

        }


        private static void CeaMaiMareSiMica()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            int max = x;
            int min = x;

            for (int i = 0; i < 10; i++)
            {
                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;

                if (x > max)
                    max = x;
                else if (x < min)
                    min = x;

                Console.WriteLine(x);
            }

            Console.WriteLine("");
            Console.WriteLine($"min: {min}, max: {max}");
        }

        private static void Fibonacci()
        {
            int a = 0;
            int b = 1;
            int c = 0;

            Console.Write("Catelea element vreti din fibo: ");
            int n = (int)getNumber();

            if (n == 1)
                Console.WriteLine(a);
            else
            {
                if (n == 2)
                    Console.WriteLine(b);
                else
                {
                    for (int i = 0; i < n - 1; i++)
                    {
                        a = b;
                        b = c;
                        c = a + b;
                    }
                }
                Console.Write($"{c} ");
            }
        }

        private static void NumereConsocutiveDiferiteDe0Count()
        {
            Console.Write("Primul element: ");
            int x = (int)getNumber();
            Console.Write("Cate elemente sa aiba sirul: ");
            int n = (int)getNumber();
            int grupCounter = 0;
            int helper = 0;

            for (int i = 0; i < n + 1; i++)
            {
                if (x != 0)
                    helper++;

                if (x == 0 && helper > 0)
                {
                    grupCounter++;
                    helper = 0;
                }

                if (x % 2 == 0)
                    x = x / 2;
                else
                    x = 3 * x + 1;

                if (i == n - 1 && x != 0)
                    grupCounter++;

            }
            Console.WriteLine("");
            Console.WriteLine($"Sunt in total {grupCounter} grupuri.");

        }


        static void Main(string[] args)
        {
            // CateNumerePare();
            // CateNumereNegativeSiPozitive();
            // SumaSiProdusulNumerelor();
            //Fibonacci();
            //DeterminarePozitie();
            
        }
    }
}
