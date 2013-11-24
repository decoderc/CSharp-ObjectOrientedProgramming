using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            int no;
            Console.Write("kaçıncı ay: ");
            no = Convert.ToInt32(Console.ReadLine());
            string mevsim ;

            switch (no)
            {
                case 3:
                case 4:
                case 5:
                    mevsim = "ilkbahar";
                    Console.Write("mevsim : " + mevsim);
                    Console.ReadKey();
                    break;
                case 6:
                case 7:
                case 8:
                    mevsim = "yaz";
                    Console.Write("mevsim : " + mevsim);
                    Console.ReadKey();
                    break;
                case 9:
                case 10:
                case 11:
                    mevsim = "sonbahar";
                    Console.Write("mevsim : " + mevsim);
                    Console.ReadKey();
                    break;
                default:
                    mevsim = "kış";
                    Console.Write("mevsim : " + mevsim);
                    Console.ReadKey();
                    break;
            }



        }
    }
}
