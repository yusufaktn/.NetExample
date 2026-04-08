using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alıştırma_sınav
{
    internal class Program
    {
        static void Main(string[] args)
        {




            // BİR SAYININ KÜPÜNÜ ALAN PROGRAM //

            /*
            int sayi1;
            int küp;
            int toplam = 0;

            //  Console.WriteLine("BİR SAYI GİRİNİZ");
            // sayi1 = Convert.ToInt32(Console.ReadLine());

              for (int i = 1; i <= 100; i++) {

                  küp = i * i * i;
                  toplam = toplam + küp;


              }





              Console.WriteLine("KÜP SONUÇ :" + toplam);

              Console.ReadLine    ();
            */


















            //GİRİLİEN İKİ SAYIDAN BÜYÜK OLANI HESAPLAYAN PROGRAM//
            /*
            int sayi1;
            int sayi2;

            Console.WriteLine("1. SAYIYI GİRİNİZ");
             sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. SAYIYI GİRİNİZ");
            sayi2 = Convert.ToInt32(Console.ReadLine());



            if (sayi1 > sayi2)
            {

                Console.WriteLine("BÜYÜK SAYI ="+sayi1);


            }

            else
            {
                Console.WriteLine("EN BÜYÜK SAYI = "+ sayi2);
            }
                    



            Console.ReadLine();


            */




















            //İSMİMİZİ 10 KERE EKRANA YAZAN PROGRAM//
            /* var isim = "MUHAMMET YUSUF";


             int i = 1;

             while (i <= 10)
             {
                 Console.WriteLine(isim);
                 i++;

             }

            Console.ReadLine();

             */



            //1 DEN 100 E KADAR OLAN TEK SAYILARI YAZDIRAN PROGRAM//


            /*  for (int i =1;  i<=100;   i++)
              {

                  if (i % 2==0 )
                  {

                  }
                  else
                  {
                      Console.WriteLine(i);

                  }





              }

          Console.ReadLine();

          */























            /*

            //   GİİRLEN FİYATA %18 KDV EKLEYEN PROGRAM//

            Console.WriteLine("FİYAT GİRİNİZ");

            int fiyat = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("KDV SİZ FİYAT :"+fiyat );

            int kdv = fiyat * 18 / 100;
            fiyat = kdv + fiyat;

            Console.WriteLine("KDV DAHİL FİYATINIZ : "+fiyat);
        
        
                Console.ReadLine();
        
        
        */



            /*
            int[] ikisayi = new int[3];

            for (int i = 0; i < ikisayi.Length; i++)
            {
                Console.WriteLine((i+1)+"."+"sayıyı giriniz :");
                ikisayi[i] =Convert.ToInt32(Console.ReadLine());

            }




            for (int i = 0; i < ikisayi.Length;i++)
            {
                int enbuyuk = ikisayi[i];
                
               
            }


            Console.ReadLine();
            */



            //       faktöriyel                //
            int fakto = 1;
            int x = 1;
            Console.WriteLine("faktöriyeli alınacak sayı giriniz :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            /*
            while (x<sayi1)
            {
                fakto = sayi1 * fakto;
                sayi1 -= 1;

            }
            */

            for (int i = 1; i < sayi1; sayi1--)
            {

                fakto = sayi1 * fakto;
               
            }


            Console.WriteLine(fakto);
            Console.ReadLine();


        }


    }
}
