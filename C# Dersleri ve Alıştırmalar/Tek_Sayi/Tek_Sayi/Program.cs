using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tek_Sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Console.WriteLine("BAŞLANGIÇ SAYISINI GİRİNİZ :");   
            int bas =Convert.ToInt32(Console.ReadLine());   
            */


            Console.WriteLine("BİTİŞ SAYISINI GİRİNİZ :");
            int bit = Convert.ToInt32(Console.ReadLine());


            for (int i = 1; i < bit; i += 2)
            {


                Console.WriteLine(" = " + i);




            }

            for (int i = 1; i < bit; i++)
            {

                if (i % 2 == 0)
                {

                    Console.WriteLine("çift sayılar =" + i);
                    Console.WriteLine();

                }
                else
                {
                    Console.WriteLine("tek sayılar =" + i);
                    Console.WriteLine();

                }


            }



            // HAFTANIN GÜN SAYISINI /

            /*
            Console.WriteLine("KAÇINCI GÜNDEYİZ :");
            string gun = Console.ReadLine();


            switch (gun)
            {

                case "1":
                    Console.WriteLine("pazartesi"); break;

                case "2":
                    Console.WriteLine("salı");
                    break;

                case "3":
                    Console.WriteLine("çarşamba");

                    break;

                case "4":
                    Console.WriteLine("perşembe");
                    break;

                case "5":
                    Console.WriteLine("cuma");
                    break;

                case "6":
                    Console.WriteLine("cumartesi");
                    break;

                case "7":
                    Console.WriteLine("pazar");
                    break;


                default:
                    Console.WriteLine("tanımsız");
                    break;


            }


            */


            // NE HESAPLANACAK //



            Console.WriteLine("1 KARE");
            Console.WriteLine("2 DİKDÖRTGEN");
            Console.WriteLine("3 DAİRE");


            Console.WriteLine();

            Console.WriteLine(" bir işlem seçiniz :");
            string islem = Console.ReadLine();

            switch (islem)
            {

                case "1":
                    Console.WriteLine("bir kenar uzunluğunu giriniz :");
                    int kenar = Convert.ToInt32(Console.ReadLine());
                    int karealan = kenar * kenar;
                    Console.WriteLine("alan :" + karealan);
                    break;


                case "2":

                    Console.WriteLine("kısa kenar");
                    int kısakenar = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("uzun kenar ");

                    int uzunkenar = Convert.ToInt32(Console.ReadLine());

                    int dikalan = kısakenar;
                    Console.WriteLine("alan :" + dikalan);
                    break;


                case "3":
                    Console.WriteLine("yarı çarp :");
                    int çap = Convert.ToInt32(Console.ReadLine());
                    int dairealan = çap * 3;
                    Console.WriteLine(" alan :" + dairealan);
                    break;










            }









            Console.ReadLine();

        }
    }
}
