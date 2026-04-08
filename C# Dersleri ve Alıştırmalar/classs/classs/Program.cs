using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*YAPICI METHOT KULLANIIMI*/
            /*
            araba araba1 = new araba();

            araba1.arabamodel = "renult";
            araba1.arabarenk = "KIRMIZI";
            araba1.kapısayisi = 4;

            araba1.kapıkitle();
            araba1.motorcalistir();

           
            Console.WriteLine("arabanın modeli = "+araba1.arabamodel);

            Console.ReadLine();
            */

            EV iznik = new EV("mavi",4,"dublex");
            /*
            iznik.evtipi = "dublex";
            iznik.evrengi = "mavi";
            iznik.dairesayi = 6;
            */
            iznik.evkonumu();

            /*
            Console.WriteLine("EVİN RENGİ= "+iznik.evrengi);
            Console.WriteLine("EVİN tipi= "+iznik.evtipi);
            */
            Console.WriteLine("ev renginiz= "+iznik.evrengi);
            Console.WriteLine("daire sayısı= "+iznik.dairesayi);
            Console.WriteLine("ev tipi= "+iznik.evtipi);
            
            
            
            
            Console.ReadLine();
        }
    }
}
