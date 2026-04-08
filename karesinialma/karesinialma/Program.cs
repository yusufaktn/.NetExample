using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karesinialma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi;
            int hata = 0;
            int toplam = 0;
            while (true)
            {
                Console.Write("BİR SAYI GİRİNİZ =");
                sayi = Convert.ToInt32(Console.ReadLine());


                if (sayi < 0 || sayi > 100)
                {
                    Console.WriteLine("HATALI SAYI GİRDİNİZ");
                    hata = hata + 1;
                    if (hata == 3)
                    {
                        Console.WriteLine("ÜÇ KERE HATALI GİRDİNİZ");
                        continue;


                    }


                }

                else if (toplam < 0 || toplam > 500)
                {

                    Console.WriteLine("OYUN BİTTİ");
                    Console.WriteLine("SONUCUNUZ = " + toplam);
                    break;


                }

                else if (sayi % 2 == 0)
                {

                    toplam = toplam + sayi;


                }

                else
                {
                    toplam -= sayi;




                }

                Console.WriteLine("TOPLAM SONUCU =" + toplam);



            }

            Console.WriteLine("SONUCUNUZ = " + toplam);

            Console.ReadLine();







        }
    }
}
