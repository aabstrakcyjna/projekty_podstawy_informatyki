using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ciąg_Fibonacciego
{
    internal class Program
    {

        static ulong FibRekurencja(ulong n)
        {
            if (n <= 2)

            {
                return 1;
            }

            return FibRekurencja(n - 2) + FibRekurencja(n - 1);
        }
        private static ulong FibIteracja(ulong n)
        {
            ulong a = 0, b = 1;

            for (ulong i = 0; i < n; i++)
            {
                b = a + b;
                a = b - a;
            }
            return a;
        }

        static void Main(string[] args)
        {
            ulong n, wynik;
            Stopwatch timer = new Stopwatch();

            // rekurencyjnie

            Console.WriteLine("Podaj liczbę dla obliczenia ciągu sposobem rekurencyjnym");
            n = ulong.Parse(Console.ReadLine());

            timer.Start();
            wynik = FibRekurencja(n);
            //timer.Stop();

            Console.WriteLine("Ciąg Fibonacciego sposobem rekurencyjnym");
            Console.WriteLine("Wynik: " + wynik);

            Console.WriteLine("Czas pracy: " + timer.Elapsed.TotalMilliseconds + "ms");

            // iteracyjnie

            //Console.WriteLine("Podaj liczbę dla obliczenia ciągu sposobem interacyjnym");
            //n = ulong.Parse(Console.ReadLine());
            
            timer = new Stopwatch();
            timer.Start();
            wynik = FibIteracja(n);
            timer.Stop();

            Console.WriteLine("Ciąg Fibonacciego sposobem iteracyjnym ");
            Console.WriteLine("Wynik: " + wynik);

            Console.WriteLine("Czas pracy: " + timer.Elapsed.TotalMilliseconds + "ms");

            Console.ReadLine();
        }
    }
}
