using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace yemek_sipariş_hesabı
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            yemekler yemekler = new yemekler();
            içecekler içecekler =new içecekler();
            tatlılar tatlılar =new tatlılar();



            /*



            Console.WriteLine("             Merhaba Hoş Geldiniz           ");
            Console.WriteLine("********************************************");
            Console.WriteLine("           Menü listemiz aşağıdadır.        ");
            Console.WriteLine();
            Console.WriteLine("**************************************************");
            Console.WriteLine("**                 YEMEKLER                     **");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            yemekler.yemeklistele();
            Console.WriteLine();

            Console.WriteLine("**************************************************");
            Console.WriteLine("**                 ÇORBALAR                     **");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            yemekler.corbalistele();
            Console.WriteLine();



            Console.WriteLine("**************************************************");
            Console.WriteLine("**                 TATLILAR                     **");
            Console.WriteLine("**************************************************");
            Console.WriteLine();
            yemekler.tatlilistele();
            Console.WriteLine();
            */



            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine("                                    ***          HOŞGELDİNİZ           ***                                  ");
            Console.WriteLine("************************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine("EKLEMEK İSTEDİĞNİZ KATEGORİYİ SEÇİN:\n1)YEMEKLER\n2)İÇECEKLER\n3)TATLILAR");
            
            string secim =Console.ReadLine();
            int toplam= 0;

            if (secim =="1")
            {

                Console.Clear();
                Console.WriteLine("*************************");
                Console.WriteLine("**     YEMEKLER        **");
                Console.WriteLine("*************************");
                yemekler.yemeklistele();

                Console.WriteLine();
                



                Console.WriteLine();
                Console.WriteLine("Eklemek istediğniz ürünün numarasını yazıp enter'a basınız:");

                


            }
            else if (secim == "2")
            {
                Console.Clear();
                Console.WriteLine("*************************");
                Console.WriteLine("**     ÇORBALAR        **");
                Console.WriteLine("*************************");
                yemekler.corbalistele();






            }
            else if (secim =="3")
            {
                Console.Clear();
                Console.WriteLine("*************************");
                Console.WriteLine("**      İÇECEKLER      **");
                Console.WriteLine("*************************");
                içecekler.iceceklistele();

            }
            else if (secim =="4")
            {
                Console.Clear();
                Console.WriteLine("*************************");
                Console.WriteLine("**     TATLILAR        **");
                Console.WriteLine("*************************");
                tatlılar.tatlilistele();

            }
            

















            Console.ReadLine();






        }
    }
}
