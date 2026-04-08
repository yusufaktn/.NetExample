using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerAlıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /* DİZİ ELEMANLARINI KULLANICIDAN ALMA  */
            /*
            string[] sehirler = new string[2];


            for (int i = 0; i < sehirler.Length; i++) 
            {

                Console.WriteLine(i+1+"."+ "ŞEHİRİ GİRİNİZ");
                sehirler[i] = Console.ReadLine();

            }

            /*   FOREACH DÖNGÜSÜ SADECE BİR DİZİNİN İÇİNDE DOLAŞMAK İÇİN KULLANILIR  KULLANICIDAN DEĞER ALMAK İÇİN KULLANILMAZ  */


            /*
            foreach (string i in sehirler)
            {
               
              
                Console.WriteLine(i);

                


            }
             
            Console.ReadLine();
            */





            /*         KULLANICIDAN ALINAN  3 ADET SAYININ ORTALAMASINI VE TOPLAMINI BULAN PROGRAM  EĞER TOPLAMI 50'Yİ GEÇERSE HATA VERSİN         */


            /*
            int toplam = 0;



            int[] sayilar = new int[3]; 


            for (int i = 0; i < sayilar.Length; i++)
            {

                Console.WriteLine((i+1)+"."+"SAYIYI GİRİNİZ = ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());

                 toplam  = sayilar[i] + toplam;
               
                
                if (toplam > 50)
                {
                    Console.WriteLine(" TOPLAMINIZ 50 DEN BÜYÜKTÜR!!!");
                    break;

                }


            }


            int ort = toplam/sayilar.Length;


            Console.WriteLine("**********************************************");
            Console.Write("SAYILARIN  TOPLAMI= "+toplam);
            Console.WriteLine("     SAYILARIN ORTALMASI= "+ort);

            Console.ReadLine();

            */


            /*   ÇEKİLİŞ PROGRAMI    */






            string[] katilimci = new string[5];
            string kazanan = "";
            string exkazanan = "\0";
            int j = 0;


            for (int i = 0; i < katilimci.Length; i++)
            {

                Console.WriteLine((i + 1) + "." + "KATILIMCIYI GİRİNİZ = ");
                katilimci[i] = Console.ReadLine();


            }

            while (true)
            {
                j = 0;
                Random rastgele = new Random();
                int kazanankisi = rastgele.Next(katilimci.Length);

                kazanan = katilimci[kazanankisi];

                string[] guncel = new string[katilimci.Length-1];
                for (int i = 0; i < katilimci.Length; i++)
                {
                    if (kazanankisi == i)
                    {
                        continue;
                    }
                    else
                    {
                        guncel[j] = katilimci[i];
                        j++;
                    }
                }
                katilimci = guncel;

                


                Console.WriteLine("***************************************************");
                Console.WriteLine("tebrikler kazanan kişi = " + kazanan); 
                

                if (katilimci.Length == 0)
                    Console.WriteLine("seçenek kalmadı !!!!!!!");

                Console.ReadLine();


            }

























        }
    }
}
