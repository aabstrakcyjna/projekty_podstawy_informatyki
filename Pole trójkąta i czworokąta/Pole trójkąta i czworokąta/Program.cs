using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pole_trójkąta_i_czworokąta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool zmienna = true;
            while (zmienna)
            {
                Console.Clear();
                Console.WriteLine("Jeśli chcesz wprowadzić dane aby obliczyć pole trójkątu wciśnij g");
                Console.WriteLine("Jeśli chcesz wprowadzić dane aby obliczyć pole czworokątu wciśnij h");
                Console.WriteLine("Jeśli chcesz wyjść z programu naciśnij k");
                string zmienna2 = Console.ReadLine();
                if (zmienna2 == "g")
                {
                    double p, d, s, a, b, c;
                    Console.WriteLine("Podaj długość boku a");
                    string _a = Console.ReadLine();
                    a = double.Parse(_a);
                    Console.WriteLine("Podaj długość boku b");
                    string _b = Console.ReadLine();
                    b = double.Parse(_b);
                    Console.WriteLine("Podaj długość boku c");
                    string _c = Console.ReadLine();
                    c = double.Parse(_c);
                    if (((a + b) < c) || ((a + c) < b) || ((b + c) < a))
                    {
                        Console.WriteLine("taki trójkąt nie istnieje");
                    }
                    else
                    {
                        p = (a + b + c) / 2.0;
                        d = (p * (p - a) * (p - b) * (p - c));
                        s = Math.Sqrt(d);
                        Console.WriteLine("Pole trójkata");
                        Console.WriteLine(s);
                    }
                    Console.ReadLine();
                }
                else if (zmienna2 == "h")
                { 
                    Console.WriteLine("Pamiętaj, że aby obliczyć czworokąt wpisany w koło musi zachodzić następujący warunek (dla kątów nazwanych q,w,r,t):");
                    Console.WriteLine("q+w=r+t=180");
                    double q, w, r, t, l;
                    l = 180;
                    Console.WriteLine("Podaj wartość kąta q");
                    string _q = Console.ReadLine();
                    q = double.Parse(_q);
                    Console.WriteLine("Podaj wartość kąta w");
                    string _w = Console.ReadLine();
                    w = double.Parse(_w);
                    Console.WriteLine("Podaj wartość kąta r");
                    string _r = Console.ReadLine();
                    r = double.Parse(_r);
                    Console.WriteLine("Podaj wartość kąta t");
                    Console.WriteLine();
                    string _t = Console.ReadLine();
                    t = double.Parse(_t);

                    if ((q + w) == l && (r + t) == l)
                    {
                        double p, d, s, a, b, c, e;
                        Console.WriteLine("Podaj długość boku a");
                        string _a = Console.ReadLine();
                        a = double.Parse(_a);
                        Console.WriteLine("Podaj długość boku b");
                        string _b = Console.ReadLine();
                        b = double.Parse(_b);
                        Console.WriteLine("Podaj długość boku c");
                        string _c = Console.ReadLine();
                        c = double.Parse(_c);
                        Console.WriteLine("Podaj długość boku e");
                        string _e = Console.ReadLine();
                        e = double.Parse(_e);
                        p = (a + b + c + e) / 2.0;
                        d = ((p - e) * (p - a) * (p - b) * (p - c));
                        s = Math.Sqrt(d);
                        Console.WriteLine("Pole czworokąta");
                        Console.WriteLine(s);
                    }
                    else
                    { 
                        Console.WriteLine("Nie można obliczyć pola trójkąta. Zmień parametry");
                    } Console.ReadLine();
                }
                else if (zmienna2 == "k")
                {
                    zmienna=false;
                    break;
                }
            } Console.ReadLine();
        }  
    }
}
