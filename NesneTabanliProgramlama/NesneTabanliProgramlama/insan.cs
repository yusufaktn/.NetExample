using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanliProgramlama
{
    public class insan : Canli
    {

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public string Cinsiyet { get; set; }

        public insan(string ad, string soyad, int yas, string cinsiyet) :base ("Homo Sapiens")
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.Yas = yas;
            this.Cinsiyet = cinsiyet;
            Console.WriteLine("İnsan nesnesi oluşturuldu.");

        }


        public void Konus()
        { 
            Console.WriteLine($"{Ad} isimli insan konuşuyor.");
        }







    }
}
