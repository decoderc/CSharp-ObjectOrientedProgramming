using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int sayac = 0, a;
            do
            {
                a = r.Next(25);
                sayac++;
            } while (a!=8);

            Console.WriteLine("8 sayısını " + sayac + ". defada buldum!");
            Console.ReadLine();

           
            
        }
    }
}
