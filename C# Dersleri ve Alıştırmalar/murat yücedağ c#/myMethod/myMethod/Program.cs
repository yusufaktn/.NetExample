using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace myMethodgiris
{
     class metotlar
    {

        /*
        private static void veriler()
        {
            Console.WriteLine("MUHMMET YUSUF AKTAN");
            Console.WriteLine("ÖĞRENCİ");
            Console.WriteLine("İKAMET : BURSA");
            Console.WriteLine("OKUL : DUMLUPINAR ÜNİ");
        }

        private static int Topla(int s1,int s2)
        {

            int sonuc = s1 + s2;
            return sonuc;

        }

        private static int Cıkar(int s1, int s2)
        {
           

            int sonuc = s1 - s2;
            return sonuc;

        }

        int bolme(int s1,int s2)
        {

            return s1/s2;
        }
        */


        private static void yazdir(string bilgi)
        {
            for(int i = 0;i<10;i++)
            {

                Console.WriteLine(bilgi);


            }


        }






        static void Main(string[] args)
        {
            /*
            Console.WriteLine("1. sayıtı giriniz :");
            int sayi1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı giriniz :");
            int sayi2 =Convert.ToInt32(Console.ReadLine()); 



            Console.WriteLine("toplam :"+Topla(sayi1, sayi2));
            Console.WriteLine("çıkarma :" + Cıkar(sayi1, sayi2));
           

            metotlar mtr = new metotlar();
            int z = mtr.bolme(sayi1, sayi2);
            Console.WriteLine("bölme :"+z);
            Console.ReadLine();
              */


            Console.WriteLine("METNİ GİRİN :");
            string blg = Console.ReadLine();
            
            yazdir(blg);
            Console.ReadLine();


        }
    }
}
