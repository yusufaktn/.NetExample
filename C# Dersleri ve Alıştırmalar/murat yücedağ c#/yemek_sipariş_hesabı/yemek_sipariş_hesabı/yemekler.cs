using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yemek_sipariş_hesabı
{
    internal class yemekler
    {


        public string[] corbalar = { "Domates Çorbası", "Mercimek Çorbası", "Tarhana Çorbası" };
        public string[] suluyemekler = {"PATATES YEMEĞİ","PATLICAN MUSAKKA","TAVUK SOTE","KURU FASULYE","NOHUT" };
        

        
        public void yemeklistele()
        {

            int sira = 1;
            foreach (string str in suluyemekler)
            {
                Console.WriteLine(sira + "-" + " " + str + "");
                sira++;


            }


        }

        public void corbalistele()
        {
            int sira = 1;
            foreach (string str in corbalar)
            {
                Console.WriteLine(sira+"-"+" " + str + "");
                sira++;
            }


        }


       




    }
}
