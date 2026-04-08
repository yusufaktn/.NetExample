using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yıldızlarla_Sekil_Cizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //      YILDIZLAR İLE ŞEKİL ÇİZME PROGRAMI      //




            /*
            for(int i=1; i < 10; i++)
            {


                for (int j= 0; j <i; j++)
                {

                    Console.Write("*");


                }

                Console.WriteLine();


            }
            Console.ReadLine();
            */








            // TERS HALİ //

            /*
            for (int i = 1; i < 10; i++)
            {


                for (int j = 10; j > i; j--)
                {

                    Console.Write("*");


                }

                Console.WriteLine();


            }
            Console.ReadLine();
            */




            //      KARE ÇİZME      //

            /*
            Console.WriteLine("KENAR SAYISINI GİRİNİZ :");
            int kare;
            kare=Convert.ToInt32(Console.ReadLine());
            for (int i = 0;i < kare;i++)
            {

                Console.Write("* ");

            }




                                                                                // SOL KENAR //
                                                                                //YANLIŞ KULLANIM//
            Console.WriteLine("");
            for(int j = 0; j < kare-2; j++)
            {


                Console.Write("*");

                //  ARADAKİ BOŞLUKLAR
                for(int x=0; x < kare-2; x++)
                {
                    Console.Write("  ");
                }

                //  SAĞ KENAR
                Console.Write(" *");
                Console.WriteLine();




            }


          


            // ALT //

            for (int i = 0; i < kare; i++)
            {

                Console.Write("* ");

            }

            Console.Read();

            */
            /*
            int kenar = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= kenar; i++)
            {
                for (int j = 1; j <= kenar; j++)
                {
                    if (i == 1 || i == kenar || j == 1 || j == kenar)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
            */





                                                                 //      BAKLAVA DİLİMİ OLUŞTURMA        //



            Console.WriteLine("SAYI GİRİNİZ :");
            int sayi =Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i <= sayi; i++)
            {

                for (int j = sayi;j > i; j--)
                {

                    Console.Write(" ");

                }
                for(int x=1; x<=i;x++)
                {


                    Console.Write("*"+" ");

                }
                Console.WriteLine();

                

            }


            for (int y = 1; y <= sayi; y++)
            {

                for(int x = 1; x<=y; x++)
                {
                    Console.Write(" ");
                }

                for(int m= sayi; m>y; m--)
                {
                    Console.Write('*'+" "); 

                }
                Console.WriteLine() ;

            }

            


            Console.ReadLine();






























        }
    }
}
