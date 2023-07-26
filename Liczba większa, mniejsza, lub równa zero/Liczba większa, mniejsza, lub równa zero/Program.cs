using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Liczba_większa__mniejsza__lub_równa_zero
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Podaj liczbę");
                int a = int.Parse(Console.ReadLine());

                if (a == 0)
                {
                    Console.WriteLine("Liczba jest równa zero");
                }

                else if (a > 0)
                {
                    Console.WriteLine("Liczba jest większa od zera");
                }
                else if (a < 0)
                {
                    Console.WriteLine("Liczba jest mniejsza od zera");
                }
                Console.WriteLine("czy chcesz zakończyć program, jeśli tak wciśnij x");
                Console.WriteLine("czy chcesz zakończyć program, jeśli nie wciśnij z");
                string zmienna = Console.ReadLine();
                if (zmienna == "x")
                {
                    break;
                }
            }
           
            
        }
    }
}
