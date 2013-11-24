using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uygulama5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            double d, k1, k2;
            Console.WriteLine("denklemin katsayılarını giriniz :");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());
            d = (b * b) - (4 * a * c);
            if (d < 0)
            {
                Console.Write("reel kök yoktur .");
                Console.ReadKey();
            }
            else if (d == 0)
            {

                k1 = k2 = -b / (2 * a);
                Console.Write("kökler eşittir. " + k1);
                Console.ReadKey();

            }
            else
            {
                k1 = (-b + Math.Sqrt(d)) / (2 * a);
                k2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("birinci kök :" + k1);
                Console.WriteLine("ikinci kök :" + k2);
                Console.ReadKey();

            }

        }
    }
}
