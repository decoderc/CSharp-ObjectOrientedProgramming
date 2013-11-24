using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace uygulama6
{
    class Program
    {
        static void Main(string[] args)
        {
            int b, y;
            char c;
            double idealkilo = 0;
            Console.WriteLine("boyunuzu (cm), yaşınızı, cinsiyetinizi (K/E) giriniz :");
            b = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToChar(Console.ReadLine().ToUpper());
            if (c=='K')
            {
                idealkilo = ((b - 100) + (y / 10)) * 0.8;
            }   
            else if (c=='E')
            {
                idealkilo = ((b - 100) + (y / 10)) * 0.9;
            }
            
            else
	        {
                Console.WriteLine("yanlış girdiniz!!");
	        }
            Console.WriteLine("ideal kilonuz :" + idealkilo);
            Console.ReadKey();
            
            


        }
    }
}
