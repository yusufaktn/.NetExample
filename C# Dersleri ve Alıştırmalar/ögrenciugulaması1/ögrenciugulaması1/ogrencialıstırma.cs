using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ögrenciugulaması1
{
    public class ogrencialıstırma
    {
        private int ogrenciNo;
        private string isim;
        private string soyisim;
        public string okulismi;
        private int vize1;
        private int vize2;
        private int final;


        public ogrencialıstırma(int ogrencino_, string isim_, string soyisim_, int vize1_, int vize2_, int final_,string okulismi_)
        {
            ogrenciNo = ogrencino_;
            isim = isim_;
            soyisim = soyisim_;
            vize1 = vize1_;
            vize2 = vize2_;
            final = final_;




        }


        public void  bilgigoster()
        {

            Console.WriteLine(ogrenciNo);
            Console.WriteLine(isim);
            Console.WriteLine(soyisim);
            Console.WriteLine(vize1);
            Console.WriteLine(vize2);
            Console.WriteLine(final);
        }

        public void ortalamabul()
        {

            int ortalama;

            ortalama = vize1 * 20 / 100 + vize2 * 20 / 100 + final * 60 / 100;

            Console.WriteLine("ortalaması = "+ortalama);    
        }
        public void okulgetir()
        {
            Console.WriteLine("okulu = "+okulismi);
        }
    }
}
