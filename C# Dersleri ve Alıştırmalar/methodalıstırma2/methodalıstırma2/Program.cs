using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodalıstırma2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("BİR SAYI GİRİNİZ =");
            int sayi1 = int.Parse(Console.ReadLine());
            int deger = karealma(sayi1);

            if (deger > 35)
            {

                Console.WriteLine("DEĞERİNİZ 35'TEN BÜYÜKTÜR!");
            }
            else
            {
                Console.WriteLine("DEĞERNİZ 35'TEN KÜÇÜKTÜR!");
            }


            Console.ReadLine();


            */
            /*
            Console.WriteLine(" lütfen bir sayı girniz =");
            int verilensayi = Convert.ToInt32(Console.ReadLine());

            bul(verilensayi);

            Console.ReadLine();
            */

            Console.WriteLine("1. sayıyı giriniz =");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("2. sayıyı giriniz =");
            int sayi2 = int.Parse(Console.ReadLine());

            buyukbulma(sayi1,sayi2);
            Console.ReadLine();


        }


        /*
        static int karealma(int a)
        {

            return a * a;
        }

            */

        /*
        static void bul(int x)
        {


            if (x % 2 == 0)
            {
                Console.WriteLine("sayınız çifttir");
            }
            else
            {
                Console.WriteLine("sayınız tektir");
            }
        }

        */

        static void buyukbulma(int sayi1, int sayi2)
        {
            
            if (sayi1 > sayi2)
            {
                Console.WriteLine(sayi1+" "+"BÜYÜKTÜR");
            }
            else if (sayi1 == sayi2)
            {
                Console.WriteLine("SAYILAR EŞİTTİR");
            }

            else
            {
                Console.WriteLine(sayi2+" "+"BÜYÜKTÜR");
            }

        }



    }



}
