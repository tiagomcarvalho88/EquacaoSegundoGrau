using System;

namespace Formula
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, delta;
            double x1, x2;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"A: {a}\nB: {b}\nC: {c}");
            Console.WriteLine($"{a}x² + {b}x + {c} = 0");

            //----------------

            delta = Convert.ToInt32(Math.Pow(b,2)) - (4*a*c);
            Console.WriteLine($"DELTA = {b}² - (4*{a}*{c})");
            Console.WriteLine($"DELTA = {delta}");

            //-------------

            x1 = ((-1 * b) + Math.Sqrt(delta)) / (2 * a);
            x2 = ((-1 * b) - Math.Sqrt(delta)) / (2 * a);

            if (delta < 0) { 
                Console.WriteLine("x1 e x2 não pertencem aos numeros reais");
                return;
            }

            if (delta == 0)
                Console.WriteLine($"x1 = x2 ({x1} = {x2})");
            else if(delta > 0)
                Console.WriteLine($"x1 != x2 ({x1} != {x2})");

            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");
        }
    }
}
