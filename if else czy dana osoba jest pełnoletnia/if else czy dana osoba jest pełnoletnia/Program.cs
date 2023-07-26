using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_czy_dana_osoba_jest_pełnoletnia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Podaj wiek");
            Console.WriteLine();
            string _a = Console.ReadLine();
            a = int.Parse(_a);
            if (a >= 18)
            {
                Console.WriteLine("osoba jest pełnoletnia");
            }
            else
                Console.WriteLine("osoba nie jest pełnoletnia");

            Console.ReadLine();






       
        }
    }
}
