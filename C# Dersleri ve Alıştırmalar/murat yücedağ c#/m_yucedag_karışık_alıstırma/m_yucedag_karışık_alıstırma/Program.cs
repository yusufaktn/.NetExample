using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_yucedag_karışık_alıstırma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*

            öğrenci ogr = new öğrenci();

            ogr.ID = 1;
            ogr.name = "yusuf";
            ogr.surname = "aktan";
            ogr.cıty = "bursa";
            ogr.school = "DPÜ";
            ogr.okul_ogretmen_sayi = 2; 



            Console.WriteLine("öğrenci id :"+ogr.ID);
            Console.WriteLine("öğrenci ismi :"+ogr.name);
            Console.WriteLine("öğrenci soyadı :"+ogr.surname);
            Console.WriteLine("öğrenci şehiri :"+ogr.cıty);
            Console.WriteLine("öğrenci okulu :"+ogr.school);

            Console.ReadLine();
            */






            /*
            AlanHesaplama alan = new AlanHesaplama();

            Console.WriteLine("daire alanı :"+alan.Dairealan(4));
            Console.WriteLine("kare alanı :"+alan.karealan(5));
            Console.WriteLine("dikdörtgen alanı :"+alan.dikdörtgenalan(5,3));

            Console.ReadLine();
            */





            araba araba = new araba();
            araba.arabamarka = "BMW";
            araba.arabamodel = 2016;
            araba.arabatipi = "sedan";
            araba.arabakapı_sayi = 4;
            araba.renk = "kırmızı";
            araba.araba_km = 120000;


            araba araba2 = new araba();
            araba2.arabamarka = "AUDİ";
            araba2.arabamodel = 2009;


            Console.WriteLine("araba markası :"+araba.arabamarka);
            Console.WriteLine("araba model :"+araba.arabamodel);
            Console.WriteLine("araba tip :"+araba.arabatipi);
            Console.WriteLine("araba kapı sayısı :" + araba.arabakapı_sayi);
            Console.WriteLine("araba killometre :"+araba.araba_km);
            Console.WriteLine("araba rengi:"+araba.renk);
            

            Console.ReadLine();


            /* nesne tanımla methot tanımla*/

             



































        }
    }
}
