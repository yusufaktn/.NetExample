using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yemek_sipariş_hesabı
{
    internal class içecekler
    {


        public string[] icecekler = {"ÇAY","ORALET","NESCAFE","KUŞBURNU","KİVİ","KARADUT","MEYVESUYU","SU" };


        public void iceceklistele()
        {
            int sira = 1;

            foreach (string s in icecekler)
            {

                Console.WriteLine(sira+" "+"-"+s+" ");
                sira++;


            }




        }















    }
}
