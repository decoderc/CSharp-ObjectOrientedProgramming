using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogru,puan;
            Console.Write("doğru cevap sayısını giriniz : ");
            dogru = Convert.ToInt32(Console.ReadLine());
            puan = dogru * 5;
            if (puan>=90)
            {
                Console.Write("puanınız : " + puan + " harf notunuz A");
                Console.ReadKey();
            }
            else if (puan>=80 )
            {
                Console.Write("puanınız : " + puan + " harf notunuz B");
                Console.ReadKey();
            }
            else if (puan>=70 && puan<80)
            {
                Console.Write("puanınız : " + puan + " harf notunuz C");
                Console.ReadKey();
            }
        }
    }
}
