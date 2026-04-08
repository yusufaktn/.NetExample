using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programlama_temeelleri_sınav_sorusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int toplam = 0;
            int hata = 0;

            for (; ; )
            {

            

            Console.WriteLine("BAŞLANGIÇ SAYISINI GİRİNİZ :");

           int sayi1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("BİTİŞ SAYISINI GİRİNİZ :");

            int sayi2 = Convert.ToInt32(Console.ReadLine());


            if(sayi1 ==0 || sayi2 ==13)
            {
                hata = hata + 1;
                Console.WriteLine("HATALI SAYI GİRDİNİZ");
                    if (hata ==5)
                {
                    Console.WriteLine("ÇOK FAZLA YANLIŞ SAYI");
                }
                   
                Console.ReadLine();
            
            
            
            }


            for (int i = sayi1; i <= sayi2; i++)
            {
                if (i %3== 0)
                {
                    toplam=toplam + i;
                }
                else if(i %5== 0)
                {
                    toplam = toplam - i;
                }
                if (toplam >=450 || toplam <= -100)
                {
                    Console.WriteLine("TOPLAM:"+ toplam);
                    break;
                
                }





               

            }

            Console.WriteLine("toplamınız :"+ toplam);

            Console.ReadLine() ;

            }
            */





            /* 0-100 ARASINDA KULLANICININ GİRDİĞİ SAYILARDAN ÇİFT OLANLARI TOPLAMA EKLEYİP TEK OLANLARI TOPLAMDAN ÇIKARAN PROGRAM
             ARALIK DIŞINDA EN FAZLA 3 HATA YAPABİLİR  TOPLAM NEGATİF OLURSA VEYA 500 Ü GEÇERSE PROGRAM BİTSİN.*/


            
            int hak = 3;
            int toplam = 0;

            while (true)
            {

                if (toplam >= 500 || toplam < 0)
                {
                    Console.WriteLine("OYUN BİTTİ TOPLAMINIZ =" + toplam);
                }
              
                
                Console.WriteLine("LÜTFEN 0-100 ARASINDA BİR SAYI GİRİNİZ = ");
                int girilensayi = int.Parse(Console.ReadLine());



                if (girilensayi > 100 || girilensayi < 0)
                {
                    hak = hak - 1;

                    Console.WriteLine("LÜTFEN TEKRAR DENEYİN!!");
                    Console.WriteLine("GİRİŞ HAKKINIZ =" + (hak));

                    if (hak == 0)
                    {
                        Console.WriteLine("GİRİŞ HAKKINIZ BİTMİŞTİR...");
                        Console.ReadLine();
                        break;

                    }



                }


                if (girilensayi %2 ==0 )
                {
                    toplam +=  girilensayi;
                }
                 
                else
                {
                    toplam -= girilensayi;
                }


               





            }


;




























        }
    }
}
