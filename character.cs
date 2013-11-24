using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a = "deneme";
            //Console.WriteLine(a[2]);

            //string a = new string('s',5);
            //Console.WriteLine(a);

            //string a = "deneme"; // bu ascii kodu ve karakter sayısı bulmamızı sağlayacak kelime. 
            //Console.WriteLine((byte)a[2]); //karaktere ait aski kodu belirtir.
            //Console.WriteLine((char)110); //aski kodun kaç karakter olduğunu belirtir.
            //Console.WriteLine(a.Length); //kaç karakter olduğunu belirtir.

            //string ad = "Ercan YAĞMUR";
            //Console.WriteLine("{0} bey isminiz {1} karakterden oluşmaktadır",ad,ad.Length);

            //int a = 5;
            //Console.WriteLine(typeof(int));

            string ad = "ercan yağmur";
            object obj = ad;
            Console.WriteLine(obj.GetType().ToString());

          
        }
    }
}
