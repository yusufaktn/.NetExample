using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Döngüler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*for (int i = 0; i <= 10; i++)
            {

                Console.WriteLine(i);


            }

            Console.ReadLine();


            */


            /*AŞAĞIDA KULLANICIDAN ALDIĞIMIZ DEĞERLERİN FAKTÖRİYELİNİ HESPALATAN BİR KOD YAZDIM VE EĞER BAŞLANGIÇ DEĞERİNİ BİTİŞ DEĞERİNDEN YÜKSEK GİRERSE ONUN İÇİNDE IF KULLANDIM.*/



            int faktöriyel = 1;


                Console.WriteLine("BAŞLANGIÇ SAYISI GİRNİZ = ");
                var sayi1 = Convert.ToInt32(Console.ReadLine());

                
            Console.WriteLine("BİTİŞ SAYISI GİRNİZ = ");
                var sayi2 = Convert.ToInt32(Console.ReadLine());

                int yedek;

                if (sayi1 > sayi2) { 

               yedek = sayi1; 
                   sayi1 = sayi2;
                    sayi2 = yedek;
                }


                for (int i = sayi1; i <= sayi2; i++)
                {
                    faktöriyel = i * faktöriyel;

                }

                Console.WriteLine("FAKTÖRİYEL HESAPLAMANIZ = " + faktöriyel);

                Console.ReadLine();

            /*    

            int faktöriyel = 1;


            Console.Write(" SAYI GİRNİZ = ");
            var sayi1 = Convert.ToInt32(Console.ReadLine());

           
                              


            for (int i = sayi1; i >=1; i-=1)
            {
                faktöriyel = i * faktöriyel;

            }

            Console.WriteLine("FAKTÖRİYEL HESAPLAMANIZ = " + faktöriyel);

            Console.ReadLine();
           */



          /*  int sayi1, sayi2;
            int i;
           
            int yedek;

            int faktöriyel = 1;


            Console.Write("1. sayıyı giriniz = ");
            sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. sayıyı giriniz = ");
            sayi2 = Convert.ToInt32(Console.ReadLine());


            for (int i = sayi1; , i <= sayi2;  i++)
            {
                faktöriyel = i * sayi1;
            
            }

          
            */
        }
    }
}
