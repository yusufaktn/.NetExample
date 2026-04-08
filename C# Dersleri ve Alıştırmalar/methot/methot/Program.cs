using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methot
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // parametresiz -Geriye değer döndürmeyen metot tanımlama//


            /*
             Console.WriteLine(" KARESİ ALINACAK SAYI GİRİNİZ :");           
             int   karesisalinacaksayi = Convert.ToInt32(Console.ReadLine());
 
             int karedeger     = kare(karesisalinacaksayi );

            if(karedeger>25 )
            {
                Console.WriteLine( "karesi alınan sayı 25 ten büyüktür." );

            }

            else
            {
                Console.WriteLine("karesi alınan sayı 25 ten küçüktür."  );
            }

                Console.ReadLine();
            */

            /* int deger = carpma(-5,6);

           if (deger > 0)
           {
               Console.WriteLine("sayınız pozitiftir");
           }


           else 
           {

               Console.WriteLine("sayınız negatiftir");

           }


           Console.ReadLine();

               */




            Console.WriteLine("BİR SAYI GİRİNİZ =");
            int girilensayi = Convert.ToInt32(Console.ReadLine());

            Sayi(girilensayi);


            Console.ReadLine();










        }


        static void selamver() 
        {
            // METOTU ÇAĞIRMAZSAK METOT ÇALIŞMAZ ÇALIŞMASI İÇİN ÇAĞIRMAMIZ GEREKİR.
            Console.WriteLine(" MERHABA DÜNYA ");
            Console.ReadLine();
        
        
        }
         

        static void toplama()
        {

            int toplam = 0;

            Console.WriteLine("1. SAYIYI GİRİNİZ :");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2. SAYIYI GİRİNİZ :");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;

            Console.WriteLine("TOPLAMINIZ :" +toplam);

             Console.ReadLine() ;


        }


        static  void adsoyad ( string isim, string soyisim)
        {

            Console.WriteLine(" isim soyisim :"+isim+" "+soyisim);

        }




        static int carpma(int sayi1  , int sayi2)
        {


            //Burada void metotunu belirtmiyoruz çünkü geriye değer döndürmek istiyoruz.
            //return ederek aşağıdaki hesaplanan değer yukarıdaki carpma metotuna gitti ve ordan da değerin içine atayıp if ile koşul belirttik ve ekrana yazdırdık.


            int sonuc  = sayi1 * sayi2;

            
            return sonuc;


        }



        /*
        static int kare(int a)
        {

            return a * a;
        }  
        */


        static int Sayi(int a)
        {

            if( a%2 == 0)
            {

                Console.WriteLine("SAYINIZ ÇİFTTİR..");
            }



            else
            {
                Console.WriteLine("sayınız tektir...");
            }
            
        }





    }
}
