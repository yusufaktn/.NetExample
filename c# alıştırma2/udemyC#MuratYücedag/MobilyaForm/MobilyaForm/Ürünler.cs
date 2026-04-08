using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilyaForm
{
    internal class Ürünler
    {
        public string UrunAd { get; set; }
        public decimal Fiyat { get; set; }
        public int SepettekiAdet { get; set; }
        
        public Ürünler(string urunad ,decimal fiyat ,int adet )
        {
            UrunAd = urunad;
            Fiyat = fiyat;
            SepettekiAdet = adet;
        }

        public decimal toplam()
        {
            return SepettekiAdet * Fiyat;
        }

       
    }
}
