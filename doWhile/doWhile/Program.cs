using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace doWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int a = 0 ;
             int toplam = 0;
             do
             {

                 toplam = toplam + a;
                 a += 2;


             } while (a<=100);

             Console.WriteLine("sonuç = " +toplam);
             Console.ReadLine();
            */

            /*break ve continue anahtar kelimelrini anlatalım.
             Break = yazıldığı döngüyü verilen karar yapsısına göre tamamen kırar.
            Continue = Bu anahtar kelime ise döngüyü bir defaya mahsus kırar .
            ÖRENEKLER AŞAĞIDA
             
                        
             */

            /*   for (int i = 0; i < 100; i++)
               {


                   if (i == 50)
                   {


                       break;

                   }


                   Console.WriteLine(i);

                   //Bu örnekte normalde ekrana 1 den 100 kadar olan sayıları yazması gerekirken i , 50 ye eşit olduğunda döngüyü kır dediğimiz için 49 a kadar yzacaktır.
                   //Eğer contiune yazsaydık i 50 ye eşit olduğunda 50 sayısını yazmaz ondan sonraki sayılardan devam ederdi.Çünkü döngüyü bir sefere mahsus kırdı.


               }
               Console.ReadLine();

               */

            //YAŞIMIZI HESAPLAYAN PROGRAM
            /*int dogumT;
            int simdikiZ = 2023;
            int yas = 0;
            while (true)
            {
                Console.WriteLine("DOĞUM TARİHİNİZİ GİRİNİZ");
                dogumT = Convert.ToInt32(Console.ReadLine());

                yas = simdikiZ - dogumT;
                Console.WriteLine("YAŞINIZ :" + yas);
                Console.ReadLine();
                
            
            }

            */
            /*
            int sayi1;
            int sayi2;
            int sayi3;

            while (true)
            {
                Console.WriteLine("1. SAYI GİRİNİZ");
                sayi1 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("2. SAYI GİRİNİZ");
                sayi2 = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("3. SAYI GİRİNİZ");
                sayi3 = Convert.ToInt32(Console.ReadLine());


                if (sayi1 > sayi2 & sayi1 > sayi3)
                {
                    Console.WriteLine("EN BÜYÜK SAYI " + sayi1);
                }

                else if (sayi2 > sayi3 & sayi2 > sayi1)
                {
                    Console.WriteLine("EN BÜYÜK SAYI " + sayi2);
                }

                else
                {
                    Console.WriteLine("EN BÜYÜK SAYI  " + sayi3);
                }


                Console.ReadLine();

            */



            //VERİLEN SAYININ KÜPÜNÜ BULAN PROGRAM//


            int sayi1;
            int küp;
            int küp2;


            Console.WriteLine("SAYI GİRİNİZ=");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            küp = sayi1 * sayi1* sayi1;
            

            Console.WriteLine("KÜP SONUÇ ="+küp);
            Console.ReadLine();

                






            

        }
    }
}