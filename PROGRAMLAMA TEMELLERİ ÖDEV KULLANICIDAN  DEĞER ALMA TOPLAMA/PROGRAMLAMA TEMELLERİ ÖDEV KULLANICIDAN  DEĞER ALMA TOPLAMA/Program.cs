using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGRAMLAMA_TEMELLERİ_ÖDEV_KULLANICIDAN__DEĞER_ALMA_TOPLAMA
{
    internal class Program
    {
        static void Main(string[] args)
        {

          int  toplam = 0;

            Console.Write(" LÜTFEN BİRİNCİ SAYIYI GİRİNİZ = ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("LÜTFEN İKİNCİ SAYIYI GİRİNİZ = ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            toplam = sayi1 + sayi2;
            Console.Write("SONUCUNUZ = " +toplam );



            Console.ReadLine();



        }
    }
}
