using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*   ATm uygulması 
             *   1 -Bakiye Görüntüleme
             *   2-Para Çekme
             *   3-Para yatırma
             *   q-ATM den çıkış yapma
            
            */




            int bakiye = 10000;
           
            Console.WriteLine("LÜTFEN YAPMAK İSTEDİĞNİZ İŞLEMİ SEÇİN");
            string secim = Console.ReadLine();


            if (secim == "1")
            {


                Console.WriteLine("BAKİYENİZ " + bakiye);

            }



            else if (secim == "2")
            {

                Console.WriteLine("NE KADAR PARA ÇEKMEK İSTERSİNİZ");

                int Cekilcek_Tutar = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("KALAN TUTAR = " + (bakiye - Cekilcek_Tutar));


                if (bakiye - Cekilcek_Tutar <= 0)
                {

                    Console.WriteLine("BAKİYE YETERSİZ");



                }


            }
            else if (secim == "3")
            {

                Console.WriteLine(" YATRIMAK İSTEDİĞNİZ TUTTARI SEÇİN");
                int Yatırılan_Tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("YENİ BAKİYENİZ =  " + (bakiye + Yatırılan_Tutar));

            }

            else if (secim == "q")
            {
                Console.WriteLine("GÜLE GÜLE YİNE BEKLERİZ");




            }
           


            else if (secim =="4")
            {

                Console.WriteLine("KİME PARA GÖNDERMEK İSTERSİNİZ");
                int Gonderilecek_kisi = Convert.ToInt32(Console.ReadLine());
                if (Gonderilecek_kisi == 15) 
                {

                    Console.WriteLine("MUHAMMET YUSUF AKTAN A PARA GÖNDERİLİYOR");
                    Console.ReadLine();
                }

            }





            else


            {



                Console.WriteLine("LÜTFEN GEÇERLİ BİR DEĞER GİRİNİZ");



            }

            Console.ReadLine    ();

































        }
    }
}
