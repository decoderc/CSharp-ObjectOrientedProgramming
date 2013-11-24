using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, i, sonuc; //Burda a, i diye 2 tane döngü için değişken tanımlandı.
            a = 1; //a nın başlangıç değeri 1
            sonuc = 0;
            while (a <= 10)
            {
                i = 1;
                while (i <= 10)
                {
                    sonuc = a * i;
                    Console.WriteLine(a + "x" + i + "=" + sonuc);
                    i++;
                }
                Console.WriteLine("---------------");
                a++;
            }
            Console.ReadLine();
        }
    }
}
