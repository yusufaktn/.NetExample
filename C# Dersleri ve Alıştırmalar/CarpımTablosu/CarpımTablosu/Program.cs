using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpımTablosu
{
    internal class Program
    {
        static void Main(string[] args)
        {



            /*
            for (int i = 1; i <=10;  i++)  
            {

                for(int j = 1; j <=10; j++)
                {
                    Console.WriteLine(i+"x"+j+"="+(i*j));
                    
                }
               


            }

            Console.ReadLine();

            */


            //           KULLANICI GİRİŞ SAYFASI UYGULAMASI           //

            /* int hata = 0;

             while (true)
             {

                 Console.WriteLine("KULLANICI ADINI GİRİNİZ");

                 string kullaniciAdi = Console.ReadLine();


                 Console.WriteLine("şifrenizi giriniz");

                 string sifre = Console.ReadLine();

                 if(kullaniciAdi =="MUHAMMET YUSUF AKTAN" && sifre =="1234") 
                 { 
                 Console.WriteLine("Tebrikler Başarılı Giriş Yaptınız");
                     break;
                 }

                 else
                 {
                     Console.WriteLine("tekrar deneyiniz");
                     hata = hata +1;
                     if (hata == 3)
                     {
                         Console.WriteLine("çok fazla hata");
                         Console.ReadLine();
                         break;
                     }



                 }

             }

             Console.ReadLine();


             */



            //  Kullanıcıdan bir sayı alacağız ve 0 dan başlayıp aldığımız sayıya kadar toplayacağız.  Daha sonra girdiğimiz sayıya böleceğiz eğer ortalama 50 den büyükse 50 den büyük yazsın depilse 50 den küçük yazsın.



            Console.WriteLine("BİR SAYI GİRİNİZ");

            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
           int ort;


            for (int i = 1; i <= sayi; i++)
            {
                toplam = toplam + i;


            }

            ort = toplam / sayi;


            if (ort < 50)
            {
                Console.WriteLine("ORTALAMANIZ 50 ' DEN KÜÇÜKTÜR");

            }

            else
            {
                Console.WriteLine("ORTALMANIZ 50'DEN BÜYÜKTÜR");
            }
            Console.WriteLine("ORTALAMANIZ ="+ort);
            Console.ReadLine();





























        }
    }
}
