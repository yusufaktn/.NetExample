using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //    DİZİLER (ARRY)    //


            /*
             * Dizileri şöyle tanımlayabiliriz;
             * Örneğin string isim = "ahmet"
             * Normalde sadece değişkene bir değer atabiliyorken  diziler ile bir çok değer atayabiliriz.
             * Örneğin  string[] isimler = {"ahmet","mehmet","yusuf"};
             * Diziler her zaman 0 dan başlar. verdiğimiz değerler index olarak adlandırılır. (örn: ahmet =0.index  mehmet = 1.index)
             */

            /* Aşağıda görüldüğü gibi bir dizi oluşturduk sonra 

            int[] sayilar = new int[4];

            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;
            sayilar[3] = 4;

            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);

            }

            Console.ReadLine();


            */


            /*

            string[] isimler = {"ahmet","mehmet","yusuf" };
            
            for(int i = 0; i < isimler.Length; i++)
            {
                Console.WriteLine(isimler[i]);
            }
            
            
            
           
            Console.ReadLine();
            */






















            /*     DİZİNİN ELEMANLARINI KULLANICIDAN ALMA      */

            /*

            int[] sayilar = new int[5];


            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("SAYILAR DİZİSİNİN"+(i+0)+"."+"ELEMANINI GİRİNİZ =");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());


            }


            for (int i = 0;i < sayilar.Length; i++)
            {
                Console.WriteLine(sayilar[i]);

            }
            

            Console.ReadLine(); 



            */


            /*
            string[] sehirler = new string[4];

            for(int i=0; i<4; i++)
            {

                Console.WriteLine("ŞEHİR GİRİNİZ");
                sehirler[i]= Convert.ToString(Console.ReadLine());


            }

            for(int i=0;i<4; i++)
            {
                Console.WriteLine(sehirler[i]);



            }

            Console.ReadLine();

            */











            /* while (true)
             {

                 int[] sayilar = { 1678, 7890, 6732, 7638, 9835, 8753, 9073 };

                 Console.WriteLine("1678,7890,6732,7638,9835,8753,9073");
                 Console.Write("DOĞRU SAYIYI SEÇİN ÇEKİLİŞİ KAZANIN :");


                 int giris = Convert.ToInt32(Console.ReadLine());

                 if (giris == 6732)
                 {
                     Console.WriteLine("TEBRİKLER ÇEKİLİŞİ KAZANDINIZ!!!");
                     break;
                 }

                 else
                 {
                     Console.WriteLine("tekrar deneyin:(");
                 }
             }
             Console.ReadLine();
            */















            /*       KULLANICIDAN ALINAN  5 ADET SAYININ ORTALAMASINI VE TOPLAMINI BULAN PROGRAM         */



            /*
            int toplam = 0;
            int ort;

            int[] sayilar  =  new int[5];

            for (int i = 0; i < sayilar.Length; i++)
            {

                sayilar[i] = Convert.ToInt32(Console.ReadLine());
                toplam = toplam + sayilar[i];

            }
            ort= toplam/sayilar.Length;
            Console.WriteLine("SAYILAR TOPLAMI ="+toplam);
            Console.WriteLine("SAYİLAR ORTALAMASI =" +ort);
            Console.ReadLine();
            
            */


















            //    KULLANICININ GİRDİĞİ KELİMEDE SESSİZ VE SESLİ HARFLERİN SAYISINI BULAN PROGRAM //



            
             int sessizharf;
             int sesliharsayisi = 0;


             char[] sesharf = { 'a','e','ı','i','o','ö','u','ü'};


             Console.WriteLine("BİR KELİME GİRİNİZ :");

             string kelime =Convert.ToString(Console.ReadLine());


             for (int x = 0; x <sesharf.Length-1; x++)

             {

                 for (int y = 0; y<kelime.Length -1; y++)
                 {

                     if (sesharf[x] == kelime[y])
                     {
                         sesliharsayisi++;   
                     }


                 }

             }

             sessizharf = kelime.Length-sesliharsayisi;

             Console.WriteLine("SESLİ HARF SAYISI ="+sesliharsayisi);
             Console.WriteLine("SESSİZ HARF SAYISI ="+sessizharf);



             Console.ReadLine();

             



            /*
            int[] sayilar = {1,2,3};


            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();

            */



















            //     3 ADET ÖĞRENCİNİN KULLANICININ GİRDİĞİ NOTLARU VE ORTLAMALARI GÖSTEREN PROGRAM      //









            /*
            
            string[] ogrenci = new string[3];

            int[] not1 = new int[3];
            int[] not2 = new int[3];
            int[] ort = new int[3];


            for (int i = 0; i < ogrenci.Length; i++)
            {

                Console.Clear();

                Console.Write((i + 1) + "." + "ÖĞRENCİ ADINI GİRİNİZ :");

                ogrenci[i] = Console.ReadLine();


                Console.Write((i + 1) + ". " + "ÖĞRENCİ 1. NOTU GİRİNİZ :");
                not1[i] = Convert.ToInt32(Console.ReadLine());


                Console.Write((i + 1) + ". " + "ÖĞRENCİ 2. NOTUNU GİRİNİZ :");
                not2[i] = Convert.ToInt32(Console.ReadLine());

                ort[i] = (not1[i] + not2[i]) / 2;





            }


            for (int i = 0; i < ogrenci.Length; i++)
            {
                Console.Clear();
                Console.WriteLine((i + 1) + "." + "ÖĞRENCİ ADI =" + ogrenci[i]);

                Console.WriteLine((i + 1) + "." + "ÖĞRENCİNİN 1. NOTU = " + not1[i]);
                Console.WriteLine((i + 1) + "." + "ÖĞRENCİNİN 2. NOTU = " + not2[i]);
                Console.WriteLine((i + 1) + "." + "ÖĞRENCİNİN ORTALAMASI = " + ort[i]);

                Console.WriteLine();
                
                Console.ReadLine();



            }
            */


























            //   KULLANICININ GİRDİĞİ DEĞER DİZİDE VARMI  //


            /*
            int[] sayilar = { 10,10,56,67,38,84,56,56,23,98,12,45,98 };
            int adet = 0;
            

            Console.WriteLine("bir sayı giriniz: ");
            int sayi= Convert.ToInt32(Console.ReadLine());



            foreach (int i in sayilar)
            {

                if(i==sayi)
                {
                    adet++;
                }



                else
                {
                    Console.WriteLine(" GİRDİĞİNİZ SAYI BULUNAMIYOR!!!");
                    break;
                }





            }

            
           



            Console.WriteLine(" girdiğiniz sayı adeti = "+adet);

            Console.ReadLine();


            */




























            //   KULLANICIDAN ALINAN SAYILAR ÜZERİNDE BELİRLİ İŞLEMLER YAPMA     //


            /*
             *  KULLANICIDAN 10 ADET İNT DEĞER AL VE ŞUNLARI YAP:
             *  kaç adet tek kaç adet çift eleman olduğunu
             *  tek değerlerin toplamı , çift değerlerin toplamı
             *  son olarak kontrol yapsın çift değerlerin toplamı tek değerlerden büyükse çift değerlerin toplamı büyüktür yazsın
             *  eğer tek büyükse tek değerlerin toplamı bütüktür yazsın.
              
             
             
             
             
             */




            int[] sayilar= new int[10];
            int ciftsayiadet= 0;
            int ciftDegerToplam= 0;
            int teksayiadet= 0;
            int tekDegerToplam= 0;


            for (int i = 0; i < sayilar.Length; i++)
            {



                Console.WriteLine(i+1+"."+"SAYIYI GİRİNİZ : ");
                sayilar[i] =Convert.ToInt32(Console.ReadLine());





            }


            for (int i = 0;i < sayilar.Length;i++)
            {


                if (sayilar[i] %2  == 0)
                {

                    ciftsayiadet++;
                    ciftDegerToplam = ciftDegerToplam + sayilar[i];

                }

                else
                {

                    teksayiadet++;
                    tekDegerToplam= tekDegerToplam+ sayilar[i];

                }



            }

            Console.WriteLine();

            if (ciftDegerToplam > tekDegerToplam)
            {
                Console.WriteLine(" çift değerlerin toplamı büyüktür.....");

            }

            else
            {
                Console.WriteLine(" tek değerlerin toplamı büyüktür......");
            }

            Console.WriteLine("**************************************************************");

            Console.WriteLine("çift adet sayısı = "+ciftsayiadet+"                    "+"tek sadet sayısı = "+teksayiadet);

            Console.WriteLine("***************************************************************");

            Console.WriteLine("çift değerlerin toplamı = "+ciftDegerToplam+"             "+" tek değerlerin toplamı ="+tekDegerToplam);



            Console.ReadLine();

















        }
    }
}
