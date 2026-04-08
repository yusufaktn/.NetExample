using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace c__vize_alıstırma1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //          FAKTÖRİYEL HESAPLAYAN PROGRAM           //
            /*

            Console.WriteLine("bir sayı giriniz:");
            int sayı1 = Convert.ToInt32(Console.ReadLine());
            int fakto = 1;


            // WHİLE İLE //

            /*
             while (1 < sayı1)
            {

                fakto = fakto * sayı1;
                sayı1--;


            }
            */

            // FOR İLE  //
            /*
            for (int i = 2; i<=sayı1; i++)
            {

                fakto = fakto * i;




            }




            Console.WriteLine(fakto);
            Console.ReadLine();
            */







            //              ASAL SAYI BULAN PROGRAM             //

            /*
            Console.WriteLine("bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int sayi2 = 2;



            while (sayi2<sayi)
            {


                if(sayi %sayi2 == 0 )
                {

                    Console.WriteLine("sayı asal değildir");
                    break;



                }
                
                else if (sayi %sayi ==0  && sayi %1 ==0)
                {
                    Console.WriteLine("sayı asaldır.");
                    break ;
                }

                sayi += 2;

            }




            Console.ReadLine() ;

            */



            //          RANDOM İLE BİLGİSAYARIN TUTTUĞU SAYIYI BULMA            //

            /*

            Random rnd = new Random();
            
            int tut = rnd.Next(0, 101);

            bool dur = true;
            
            while(dur)
            {

                Console.WriteLine("bir sayı giriniz :");
                int sayi =Convert.ToInt32(Console.ReadLine());

                if (sayi > tut)
                {
                    Console.WriteLine("sayıyı küçültün");
                }
                else if (sayi < tut)
                {
                    Console.WriteLine("sayıyı büyütün");
                }
                else
                {
                    Console.WriteLine("sayı doğru");
                    Console.WriteLine("giirlen sayı = "+sayi+" "+" bilgisayarın tuttuğu sayı ="+tut);
                    break;
                }


            }

            Console.ReadLine();


            */


            //      0-10 ARASINDAKİ TUTULAN SAYIYI TAHMİN ETME OYUNU        //


            /*
            Random rnd = new Random();
            int tutulan_sayi = rnd.Next(10);

            Console.WriteLine(" 0-10 arasında bir sayı giriniz :");
            int sayi = Convert.ToInt32(Console.ReadLine()); 

            if(sayi == tutulan_sayi)
            {
                Console.WriteLine("tebrikler!! girilen sayı {0} / tutulan sayı {1}  ",sayi,tutulan_sayi   );

            }

            else
            {
                Console.WriteLine(" KAYBETTİN!! / girilen sayı {0} / tutulan sayı {1}  ", sayi, tutulan_sayi);

            }


            Console.ReadLine();

            */




            // KLAVYEDEN GİRİLEN ÜÇ SAYIDAN  BÜYÜK OLANI HESAPLAYAN PROGRAM //                               //  10 30 12

            /*


            int[] dizi = new int[10];

            for (int i = 0; i < dizi.Length; i++)
            {

                Console.WriteLine(i + 1 + "." + " sayıyı giriniz :");
                dizi[i] = Convert.ToInt32(Console.ReadLine());

            }


            int bos;
            

            for (int i = 0; i < dizi.Length; i++)
            {

                for (int j = i+1; j < dizi.Length; j++)
                {
                    if (dizi[i] < dizi[j])
                    {

                        bos = dizi[i];
                        dizi[i] = dizi[j];
                        dizi[j] = bos;



                    }



                }



            }


            for (int i = 0;i < dizi.Length; i++)
            {

                Console.Write(dizi[i]+" > ");

            }


            Console.WriteLine("en büyük sayı " + dizi[0]);


            Console.ReadLine();






            
            int say = 1567;

            Console.WriteLine("sayınız :"+say);

            Console.ReadLine();

            */


            // matrislerde toplama ü


            int[,] amatrisi = new int[2, 3];
            int[,] bmatrisi = new int[2, 3];
            int[,] cmatrisi = new int[2, 3];


            for (int i = 0; i<2; i++)
            {


                for (int j = 0; j<3; j++)
                {

                    Console.WriteLine("A MATRİSİ  {0}.satırının {1}. indexsini gir :", i + 1, j + 1);
                    amatrisi[i,j]=Convert.ToInt32(Console.ReadLine());

                }


            }

            for (int i = 0; i < 2; i++)
            {


                for (int j = 0; j < 3; j++)
                {

                    Console.WriteLine("B MATRİSİ   {0}.satırının {1}. indexsini gir :", i + 1, j + 1);
                    bmatrisi[i, j] = Convert.ToInt32(Console.ReadLine());

                }


            }


            for (int i = 0; i < 2; i++)
            {


                for (int j = 0; j < 3; j++)
                {


                    cmatrisi[i,j] = amatrisi[i,j] + bmatrisi[i,j];

                }


            }


            Console.WriteLine("C MATRİSİ");

            for (int i = 0; i < 2; i++)
            {


                for (int j = 0; j < 3; j++)
                {

                    Console.Write(cmatrisi[i,j]+" ");

                   


                }
                Console.WriteLine();

            }

            Console.ReadLine();














        }
    }
}
