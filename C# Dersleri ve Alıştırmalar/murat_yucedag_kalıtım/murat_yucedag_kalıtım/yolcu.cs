using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace murat_yucedag_kalıtım
{
    internal class yolcu
    {

        private string ad;
        private string soyad;
        private int yas;
        private string cinsiyet;




        public string AD
        {

            get { return ad; }
            set { ad = value.ToLower(); }
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper();}
        }

        public int YAS
        {
            get { return yas; }
            set { yas = Math.Abs(value); }
        }

        public string CINSIYET
        {
            get { return cinsiyet; }
            set { cinsiyet = value; }
        }





    }
}
