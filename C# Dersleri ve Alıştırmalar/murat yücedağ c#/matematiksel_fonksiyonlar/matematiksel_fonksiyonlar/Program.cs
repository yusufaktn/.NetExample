using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matematiksel_fonksiyonlar
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //      MATEMATİKSEL FONKSİYONLAR       //








            //MUTLAK DEĞER//

            /*
            int sayi;
            Console.Write("sayı giriniz :");
            sayi =Convert.ToInt32(Console.ReadLine());

            Console.Write("mutlak değerli hali:"+Math.Abs(sayi));

            Console.ReadLine();

            */









            //ÜSTE YUVARLAMA//
            /*
            double sayi;
            Console.Write("sayıyı giriniz :");
            sayi=Convert.ToDouble(Console.ReadLine());

            Console.Write("üste yuvarlanmış hali :  "+Math.Ceiling(sayi));
            Console.Read();
            */





            //ALTA YUVARLAMA//
            /*
            double sayi;
            Console.Write("sayıyı giriniz :");
            sayi = Convert.ToDouble(Console.ReadLine());

            Console.Write("alta yuvarlanmış hali :  " + Math.Floor(sayi));
            Console.Read();
            */






            //ÜS ALMA//
            /*
            double sayi;
            Console.Write("sayıyı giriniz :");
            sayi = Convert.ToDouble(Console.ReadLine());

            Console.Write("alta yuvarlanmış hali :  " + Math.Pow(sayi,5));
            Console.Read();
            */



            //KÜÇÜK BÜYÜK SAYIYI BULMA//

            /*
            double sayi1,sayi2,sayi3;
            Console.Write("1.sayıyı giriniz :");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("2.sayıyı giriniz :");
            sayi2 = Convert.ToDouble(Console.ReadLine());


         

            Console.WriteLine("büyük sayı :  " + Math.Max(sayi1,sayi2));
            Console.Write("küçük sayı  :  " + Math.Min(sayi1, sayi2));
            Console.Read();
            */



            DateTime zaman;
            zaman =DateTime.Now;
            int yıl = zaman.Year;
            int ay = zaman.Month;
            int gün = zaman.Day;
            DayOfWeek haftanıngunu =zaman.DayOfWeek;
            /*
            Console.WriteLine("GÜN :{0}",gün);
            Console.WriteLine("AY :{0}", ay);
            Console.WriteLine("YIL :{0}", yıl);
            Console.WriteLine(" HAFTANIN GÜNÜ :{0}", haftanıngunu);
            Console.ReadLine();
            */
            Console.WriteLine("KISA TARİH :{0:d}",zaman);
            Console.WriteLine("UZUN TARİH :{0:D}", zaman);
            Console.WriteLine("TAM TARİH :{0:f}", zaman);
            Console.WriteLine("TAM TARİH 2 :{0:F}", zaman);
            Console.WriteLine("SAYISAL TARİH FORMATI :{0:g}", zaman);
            Console.WriteLine("SAYISAL TARİH FORMATI 2 :{0:G}", zaman);
            Console.WriteLine("AY :{0:m}", zaman);
            Console.WriteLine("BİÇİM :{0:r}", zaman);
            Console.WriteLine("BİÇİM 2:{0:s}", zaman);
            Console.WriteLine("YIL :{0:y}", zaman);
            Console.ReadKey();

        }
    }
}
