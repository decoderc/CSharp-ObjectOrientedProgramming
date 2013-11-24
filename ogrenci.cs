using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace deneme_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int gec;
            string gecs;
            string[] ad = new string[4];
            string[] soyad = new string[4];
            int[] no = new int[4];
            int[] snv1 = new int[4];
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("ad giriniz");
                ad[i] = Console.ReadLine();
                Console.WriteLine("soyad giriniz");
                soyad[i] = Console.ReadLine();
                Console.WriteLine("no giriniz");
                no[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("not giriniz");
                snv1[i] = Convert.ToInt32(Console.ReadLine());

            }
            for (int j = 0; j < 3; j++)
            {

                for (int i = 0; i < 3; i++)
                {
                    if (snv1[i] > snv1[i + 1])
                    {
                        gecs = ad[i];
                        ad[i] = ad[i + 1];
                        ad[i + 1] = gecs;


                        gecs = soyad[i];
                        soyad[i] = soyad[i + 1];
                        soyad[i + 1] = gecs;


                        gec = no[i];
                        no[i] = no[i + 1];
                        no[i + 1] = gec;


                        gec = snv1[i];
                        snv1[i] = snv1[i + 1];
                        snv1[i + 1] = gec;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("ad       soyad       no        sınav");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}      {1}     {2}     {3}", ad[i], soyad[i], no[i], snv1[i]);
            }
            Console.ReadLine();
        }
    }
}
