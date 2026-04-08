using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yemek_sipariş_hesabı
{
    internal class tatlılar
    {

        public string[] tatlilar = { "Baklava", "Kadayıf", "Şekerpare", "Traliçe", "Magnolya" };



        public void tatlilistele()
        {
            int sira = 1;
            foreach (string str in tatlilar)
            {
                Console.WriteLine(sira + "-" + " " + str);
                sira++;

            }


        }

    }
}
