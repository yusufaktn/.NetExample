using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanlıAlıstırma
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //       ASAL SAYI BULAN PROGRAM        //

            /*

            Console.WriteLine(" bir sayı giriniz :");
            int sayi1 =Convert.ToInt32(Console.ReadLine());
            int x = 1;


            bool asalmi = false;    
          for (int i = 2; i < sayi1; i++)
            {
                if (sayi1 % i == 0)
                {
                    asalmi = false;

                }

                else
                {
                    asalmi = true;

                }


            }

            if (asalmi==false)
            {
                Console.WriteLine("sayınız asal değildir");
            }

            else
            {
                Console.WriteLine("sayınız asaldır");
            }




            Console.ReadLine();*/



            //          RANDOM İLE BİLGİSAYARIN TUTTUĞU SAYIYI BULMA       //

            /*
            Random random = new Random();
            int a = random.Next(0,101);


            for (int i = 0; i < 101; i++)
            {
                Console.WriteLine("bir sayı giriniz");
                int giris1 = Convert.ToInt32(Console.ReadLine());

                if (giris1 > a)
                {
                    Console.WriteLine("sayıyı küçültün");

                }

                else if (giris1 < a)
                {
                    Console.WriteLine("sayıyı büyütün");
                }


                else
                {
                    Console.WriteLine(" tebrikler doğru sayı" + a);
                }

            }



            Console.ReadLine();


            */






            //          DİZİLER             //


            /*

            string[] sehirler = {"istanbul","ankara","bursa",",izmir","kocaeli","eskişehir","kütahya","balıkesir"};
            string[] isim = new string[8];

            string ad;
            for (int i=0; i<isim.Length; i++)
            {
                Console.WriteLine("isim soyisim giriniz :");
                isim[i]=Console.ReadLine();
            }

            Random r =new Random();
            int a=r.Next(isim.Length);



            Random rnd = new Random();
            int b =rnd.Next(sehirler.Length);







            Console.WriteLine("atama yeriniz :" + isim[a] +" "+ sehirler[b]);



            Console.ReadLine();
            */

            /*
            string[] ay = new string[12];

            for (int i = 0; i < ay.Length; i++)
            {
                Console.WriteLine(i+1+"."+"ayı giriniz :");
                ay[i] =Console.ReadLine();

            }

            for (int i = 0;i < ay.Length; i++)
            {
                Console.WriteLine(i + 1 + "." +"ay"+" "+ ay[i]);

            }

            Console.ReadLine();
            */









            //                   ÇOK BOYUTLU DİZİLER - MATRİSLER  VE TOPLAMA                          //




            //evde for ile matris ödvini yap
            //matrislerin çarpımını öğren
            //2x4 tipinde matris toplamı yazdır.




            // Toplama yapabilmek için iki matrisinde aynı tipte olması gereklidir.






            //int[,] amatrisi = new int[2, 3];
            //int[,] bmatrisi = new int[2, 3];
            //int[,] toplam_matrisi = new int[2, 3];




            //for (int i = 0;i<=1;i++)
            //{
            //    for (int k = 0; k <= 2; k++)
            //    {
            //        Console.WriteLine(" A matrisinin {0}x{1} elemanını giriniz :", i, k);
            //        amatrisi[i, k] = Convert.ToInt32(Console.ReadLine());
            //    }



            //}



            //for (int i = 0; i <= 1; i++)
            //{
            //    for(int k = 0;k <= 2; k++)
            //    {
            //        Console.WriteLine(" b matrisinin {0}x{1} elemanını giriniz :", i, k);
            //        bmatrisi[i, k]= Convert.ToInt32(Console.ReadLine());
            //    }

            //}



            //for(int i =0; i <= 1; i++)
            //{

            //    for( int k = 0; k<= 2; k++)
            //    {
            //        toplam_matrisi[i, k] = amatrisi[i,k] + bmatrisi[i,k];

            //    }

            //}


            //for( int i = 0;i <= 1; i++)
            //{
            //    Console.WriteLine();
            //    for(int k=0;k<= 2; k++)
            //    {
            //        Console.Write(toplam_matrisi[i,k]+"  ");
            //    }


            //}
            //Console.ReadLine();





            /* for(int i = 0;i <= 1; i++)
             {

                 for( int k = 0;k<= 2; k++)

                     Console.Write(" {0} ",amatrisi[i, k]);
                     Console.WriteLine();



             }
             Console.WriteLine();

             for (int i = 0; i <= 1; i++)
             {

                 for (int k = 0; k <= 2; k++)

                     Console.Write(" {0} ",bmatrisi[i, k]);
                     Console.WriteLine();



             }

             Console.ReadLine();
            */



            //   GOTO KULLANIMI  //


            //basadon:
            //    Console.WriteLine("pozitif bir sayı giriniz:");
            //    int sayi = Convert.ToInt32(Console.ReadLine());

            //    if (sayi == 0)
            //    {

            //        Console.WriteLine("yanlış giriş!!");
            //        goto basadon;

            //    }
            //    else if (sayi > 0)
            //    {

            //        Console.WriteLine("doğru");

            //    }
            //    else
            //    {

            //        Console.WriteLine("yanlış giriş!!");
            //        goto basadon;

            //    }



            //    Console.ReadLine();





            //      ÜÇ SAYIYI BÜYÜKTEN KÜÇÜĞE İF ELSE KULLANRAK SIRALAMA        //


            //Console.WriteLine("1. sayıyı giriniz:");
            //int sayi1 =Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("2. sayıyı giriniz:");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("3. sayıyı giriniz:");
            //int sayi3 = Convert.ToInt32(Console.ReadLine());

            //int enbuyuk;
            //if (sayi1 > sayi2 && sayi1>sayi3)
            //{
            //    enbuyuk = sayi1;
            //    if(sayi2 > sayi3)
            //    {
            //        Console.WriteLine(enbuyuk+" "+sayi2+" "+sayi3);

            //    }
            //    else
            //    {

            //        Console.WriteLine(enbuyuk + " " + sayi3 + " " + sayi2);
            //    }

            //}
            //else if (sayi2 > sayi1 && sayi2 > sayi3)
            //{

            //    enbuyuk=sayi2;
            //    if(sayi1 > sayi3)
            //    {

            //        Console.WriteLine(enbuyuk+" "+sayi1+" "+sayi3);
            //    }
            //    else
            //    {
            //        Console.WriteLine(enbuyuk + " " +sayi3+" "+sayi1);
            //    }

            //}
            //else if(sayi3 > sayi1 && sayi3> sayi2)
            //{
            //    enbuyuk = sayi3;
            //    if (sayi2 > sayi1)
            //    {

            //        Console.WriteLine(enbuyuk + " " +sayi2+" "+sayi1);
            //    }
            //    else
            //    {

            //        Console.WriteLine(enbuyuk+" "+sayi1+" "+sayi2);
            //    }


            //}
            //Console.ReadLine();






            //                              HAFTANIN GÜNLERİ                            //

            //string[] gunler = new string[7];

            //for(int i =0; i < gunler.Length; i++)
            //{

            //    Console.WriteLine("{0}.günü giriniz :",i+1);
            //    gunler[i] =Console.ReadLine();



            //}


            //for(int i =0; i<gunler.Length; i++)
            //{

            //    Console.WriteLine("haftanın {0}. günü : {1}", i + 1, gunler[i]);

            //}

            //Console.ReadLine();








            //                          MATRİSLER                       //


            //            int[,] amatrisi = new int[2, 2];
            //            int[,] bmatrisi = new int[2, 2];
            //            int[,] cmatrisi = new int[2, 2];



            //            for(int i = 0; i < 2; i++)
            //            {

            //                for(int j = 0; j < 2; j++)
            //                {

            //                    Console.WriteLine("A MATRİSİ  {0}X{1}  değeri gir : ",i,j);
            //                    amatrisi[i,j]=Convert.ToInt32(Console.ReadLine());




            //                }





            //            }


            //            for (int i = 0; i < 2; i++)
            //            {

            //                for (int j = 0; j < 2; j++)
            //                {

            //                    Console.WriteLine("B MATRİSİ  {0}X{1}  değeri gir : ", i, j);
            //                    bmatrisi[i, j] = Convert.ToInt32(Console.ReadLine());




            //                }





            //            }


            //            for (int i = 0; i < 2; i++)
            //            {

            //                for (int j = 0; j < 2; j++)
            //                {


            //                    cmatrisi[i, j] = amatrisi[i, j] + bmatrisi[i, j];




            //                }





            //            }


            //            for (int i = 0; i < 2; i++)
            //            {

            //                for (int j = 0; j < 2; j++)
            //                {

            //                    Console.Write(cmatrisi[i,j]+" ");




            //                }
            //                Console.WriteLine();




            //            }
            //            Console.ReadLine();


















        }
    }
}
