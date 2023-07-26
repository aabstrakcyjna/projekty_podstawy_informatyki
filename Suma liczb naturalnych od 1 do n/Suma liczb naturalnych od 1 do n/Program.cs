using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_liczb_naturalnych_od_1_do_n
{
    internal class Program
    {
        static int PetlaFor(int n)
        {
            int suma = 0;
            for (int aktualna_liczba = 1; aktualna_liczba <= n; aktualna_liczba++)
            {
                suma += aktualna_liczba;
            }
            return suma;
        }

        static int PetlaWhile(int n)
        {
                int suma = 0;
                int aktualna_liczba = 1;
            while(aktualna_liczba<=n)
            {
                suma += aktualna_liczba;
                aktualna_liczba++;

            }
            return suma;
        }

        static int PetlaDoWhile(int n)
        {
            int suma = 0;
            int aktualna_liczba = 1;
            do
            {
                suma += aktualna_liczba;
                aktualna_liczba++;
            }
            while (aktualna_liczba <= n);

            return suma;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Podaj n:");
            int n;
            string _n = Console.ReadLine();
            n=int.Parse( _n );
            if (n < 1)
            {
                Console.WriteLine("liczba nie jest naturalna");
                Console.ReadLine();
                return;
            }
            int sumaFor = PetlaFor(n);
            Console.WriteLine("Suma dla pętli for dla n=" +n + " : " +sumaFor);
            int sumaWhile = PetlaWhile(n);
            Console.WriteLine("Suma dla pętli while dla n=" + n + " : " + sumaWhile);
            int sumaDoWhile = PetlaDoWhile(n);
            Console.WriteLine("Suma dla pętli DoWhile dla n=" + n + " : " + sumaDoWhile);
            Console.ReadLine();

        }

    }
}
