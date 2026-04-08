using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alıştırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            int hata = 0;
            int toplam = 0;

            for (; ; )
            {
                Console.WriteLine("LÜTFEN SAYI GİRİNİZ");
                sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi < 0 || sayi > 100)
                {
                    Console.WriteLine("HATALI GİRİŞŞ!!!!!");
                    hata = hata + 1;
                    if (hata == 3)
                    {

                        Console.WriteLine("SİKTİRGİT BEYİNSİZ");
                        Console.ReadLine();
                        break;

                    }
                }

                else if (toplam < 0 || toplam > 500)
                {
                    Console.WriteLine("OYUN BİTTİ");
                    break;
                }


                else if (sayi %2== 0)
                {
                    toplam = toplam+sayi;
                }

                else
                {
                    toplam = toplam - sayi;
                }









            }




            Console.WriteLine("SONUÇ =" + toplam);
            Console.ReadLine();


        }
    }
}
