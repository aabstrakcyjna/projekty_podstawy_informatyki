using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funkcja_Random
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Jeśli chcesz wykonać losowanie w przedziale liczb 1-49 wciśnij x");
            Console.WriteLine("Jesli chcesz wylosować 5 liczb z przedziału 1-45 wciśnij z");
            Console.WriteLine("Jesli chcesz opuścić program wciśnij y");
            Console.WriteLine();
           
            Random losuj = new Random();
            int[] tab = new int[6];
            bool czyLosowacLiczbe = true;
            while (czyLosowacLiczbe)
            {    
                string zmienna = Console.ReadLine();
                if (zmienna == "x")
                {
                    for (int i = 0; i < 6; i++)
                    {
                        int przedzialLiczby = losuj.Next(1, 49);
                        Console.Write(przedzialLiczby + " ");
                    }
                }
                else if (zmienna == "z")
                {
                    for (int i = 0; i < 5; i++)
                    {
                        int przedzialLiczby2 = losuj.Next(1, 45);
                        Console.Write(przedzialLiczby2 + " ");
                    }
                }            
                else if (zmienna == "y")
                {
                    czyLosowacLiczbe = false;

                    break;
                }             
            }              
        }
    }
}
