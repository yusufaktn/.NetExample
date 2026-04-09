using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV
{
    public class Yolcu
    {
        private string _ad;
        private string _soyad;
        private string _koltukno;

        public Yolcu(string ad, string soyad, string koltukno)
        {
            _ad = ad;
            _soyad = soyad;
            _koltukno =koltukno ;
        }

        public void YolcuBilgileri()
        {
            Console.WriteLine("Ad: {0} Soyad: {1} Koltuk No: {2}", _ad, _soyad, _koltukno);
        }


    }
}
