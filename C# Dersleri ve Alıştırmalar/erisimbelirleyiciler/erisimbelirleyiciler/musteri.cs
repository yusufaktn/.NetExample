using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisimbelirleyiciler
{
    internal class musteri
    {

        public string musteriName;
        public string musterisurname;
        public int musterisalary;
        private string musterigender;

        /*
        public void musteriinfo() 
        {
            Console.WriteLine("MÜŞTERİNİN İSMİ ="+musteriName);
            Console.WriteLine("MÜŞTERİNİN SOYİSMİ ="+musterisurname);
            Console.WriteLine("MÜŞTERİ MAAŞI ="+musterisalary);
            Console.WriteLine("MÜŞTERİ CİNSİYETİ ="+musterigender);
        
        
        
        
        
        }
        */

        public musteri(string musteriad, string musterisoyad, int musterimaas)
        {
            
            musteriName = musteriad;
            musterisurname = musterisoyad;
            musterisalary = musterimaas;



        }


        public void bilgiac()
        {
            Console.WriteLine(" müşteri ismi ="+musteriName);
            Console.WriteLine("müşteri soyadı ="+musterisurname);
        }

    }
}
