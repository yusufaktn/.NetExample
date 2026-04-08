using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace m_yucedag_matematik_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("************************");
            Console.Title = "MATEMATİK İŞLEMLERİ";

            Console.WriteLine("1- ARİTMATİK DÖRT İŞLEM\n2- ÜS ALMA\n3- KÖK ALMA\n ");
            Console.WriteLine();

            while (true)
            {


                Console.WriteLine("Bir işlem seçiniz :");
                string islem = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(islem))
                {
                    Console.WriteLine("boş değer girilmez");
                    continue;
                    

                }
                if (islem != "1" && islem!="2" && islem !="3"){

                    Console.WriteLine("geçersiz seçenek!!!\nTekrar gir :");
                    continue;

                }
                if (islem == "1")
                {
                    Console.WriteLine("1.Sayıyı giriniz");
                    int sayi1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("2.Sayıyı giriniz :");
                    int sayi2 = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine();
                    Console.WriteLine("Toplam =" + (sayi1 + sayi2));
                    Console.WriteLine("Fark =" + (sayi1 - sayi2));
                    Console.WriteLine("Bölme =" + (sayi1 / sayi2));
                    Console.WriteLine("Çarpma =" + (sayi1 * sayi2));



                }
                else if (islem == "2")
                {

                    Console.WriteLine("Üssü alınacak sayıyı giriniz:");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Üs girin");
                    int üs = Convert.ToInt32(Console.ReadLine());


                    Console.WriteLine();
                    Console.WriteLine("Sonuç :" + Math.Pow(sayi, üs));


                }
                else if (islem == "3")
                {

                    Console.WriteLine("Kökü alınacak sayıyı giriniz :");
                    int sayi = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Sonuç :" + Math.Sqrt(sayi));

                }

                Console.ReadLine();
            }




        }
    }
}
