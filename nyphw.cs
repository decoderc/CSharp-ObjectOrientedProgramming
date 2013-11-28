using System;
using System.Linq;

namespace Uzay
{
    public class A//Harfler üzerinde işlem yapacak olan bir sınıf oluşturuldu.
    {
        private string EngAlfabe = "abcdefghijklmnopqrstuvwxyz";
        private A[] dizi;
        private string[] Data;
        private bool isDelete;
        public A()
        {
            dizi = new A[26];
            isDelete = false;
            Data = new string[0];
        }
        public void Silinecek()
        {
            Data = new string[0];
            isDelete = true;
        }
        public void Eklenecek(string Anlam)
        {
            string[] Copy = Data.ToArray();
            Data = new string[Copy.Length + 1];
            for (int i = 0; i < Copy.Length; i++)
            {
                Data[i] = Copy[i];
            }
            Data[Data.Length - 1] = Anlam;
        }
        public string[] Mesaj()
        {
            string[] hata = new string[1];

            if (isDelete)
            {
                hata[0] = "[bu kelime daha once silinmis]";
                return hata;
            }
            else
            {
                if (Data.Length == 0)
                {

                    hata[0] = "[kelime bulunamadi]";
                    return hata;
                }
                else
                    return Data;
            }
        }
        public A EkleBul(char a)
        {
            if (dizi[EngAlfabe.IndexOf(a)] == null)
                dizi[EngAlfabe.IndexOf(a)] = new A();
            return dizi[EngAlfabe.IndexOf(a)];
        }
    }
    public class KelimeAgaci
    {
        private A Root;

        public KelimeAgaci()
        {
            Root = new A();
        }
        private A Bul(string Eng)
        {
            A yeniA;
            yeniA = Root;
            foreach (char i in Eng)
            {
                yeniA = yeniA.EkleBul(i);
            }
            return yeniA;
        }
        public void KelimeEkle(string Eng, string Tr)
        {
            A yeniA = Bul(Eng);
            yeniA.Eklenecek(Tr);
        }
        public string AnlamBul(string Eng)
        {
            string[] anlam;
            string sonuc = "";
            A yeniA = Bul(Eng);
            anlam = yeniA.Mesaj();
            for (int i = 0; i < anlam.Length; i++)
            {
                sonuc += anlam[i];
                if ((anlam.Length > 1) && (i < anlam.Length - 1))
                    sonuc += "; ";
            }
            return sonuc;
        }
        public void KelimeSil(string Eng)
        {
            A yeniA = Bul(Eng);
            yeniA.Silinecek();
        }
    }
    public class Sinif
    {
        static void Main()
        {
            KelimeAgaci sozluk = new KelimeAgaci();
            sozluk.KelimeEkle("legal", "yasal");
            sozluk.KelimeEkle("leg", "bacak");
            sozluk.KelimeEkle("a", "bir");
            sozluk.KelimeEkle("legend", "efsane");
            sozluk.KelimeEkle("leg", "dik kenar");
            Console.WriteLine("leg : {0}", sozluk.AnlamBul("leg"));
            Console.WriteLine("bell : {0}", sozluk.AnlamBul("bell"));
            Console.WriteLine("a : {0}", sozluk.AnlamBul("a"));
            Console.WriteLine("legend : {0}", sozluk.AnlamBul("legend"));
            Console.WriteLine("legal : {0}", sozluk.AnlamBul("legal"));
            sozluk.KelimeSil("legal");
            Console.WriteLine("legal : {0}", sozluk.AnlamBul("legal"));
            Console.ReadLine();
        }
    }
}




