using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Kierunek_odjazdów_pociągu
{
    internal class Program
    {
        static void Main(string[] args)
        {
          bool a = true;
            while (a)
            {
                Console.Clear();
                Console.WriteLine("Podaj kierunek odjazdu");
                string kierunek = Console.ReadLine();
                 switch (kierunek)
                {
                    case "Katowice":
                        Console.WriteLine("Pociąg odjeżdża z peronu 1");
                        Console.ReadLine();
                        break;
                    case "Gliwice":
                        Console.WriteLine("Pociąg odjeżdża z peronu 2");
                        Console.ReadLine();
                        break;
                    case "Częstochowa":
                        Console.WriteLine("Pociąg odjeżdża z peronu 3");
                        Console.ReadLine();
                        break;
                    case "Mysłowice":
                        Console.WriteLine("Pociąg odjeżdża z peronu 4");
                        Console.ReadLine();
                        break;
                    case "Kołobrzeg":
                        Console.WriteLine("Pociąg odjeżdża z peronu 5");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Nie ma takiego kierunku jazdy");
                        Console.ReadLine();
                        break;
                }
                Console.WriteLine("czy chcesz zakończyć program, jeśli tak wciśnij x");
                Console.WriteLine("czy chcesz zakończyć program, jeśli nie wciśnij z");
                string zmienna = Console.ReadLine();
                if (zmienna == "x")
                    a = false;
                else
                {
                    continue;
                }
            }
        }
    }
}
