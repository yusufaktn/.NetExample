using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace m_yucedag_bilgi_yarısması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("YARIŞMAYA HOŞ GELDİNİZ!!");
            Console.Title = "BİLGİ YARIŞMASI";


            Console.WriteLine("ADINIZI GİRİNİZ :");
            string ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("SOYAD GİRİNİZ :");
            string soyad = Convert.ToString(Console.ReadLine());

            Console.WriteLine("**********************************************");

            Console.WriteLine("* BAŞLAMAK İÇİN ENTER TUŞUNA BASIN *");
            Console.WriteLine("*Her yanıttan sonra enter tuşuna basmayı unutmayın!!");
            Console.WriteLine("*Cevapları büyük harflerle verin!!");

            Console.WriteLine("**********************************************");


            int dogru = 0;
            int yanlis = 0;
            int para = 0;



            Console.WriteLine("Soru-1  HANGİSİ GOOGLE TARAFINDAN GELİŞTİRİLEN BİR YAPAY ZEKA MODELİDİR ?");
            Console.WriteLine(" A)ChatGPT\n B)GEMİNİ\n C)SORA\n D)DEVIN AI\n Cevabınız:");
            string c1 = Console.ReadLine();
          
            if (c1 == "B")
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("Tebrikler cevabınız doğru");
                para += 1000;
                dogru += 1;
                Console.Clear();

            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine("Cevabınız yanlış");
                yanlis += 1;
                Console.Clear();


            }
            Console.WriteLine("Sonraki soruyu görmek  için entere basın");
            string s1 = Console.ReadLine();


            Console.WriteLine("Soru-2  TÜRKİYENİN BAŞKENTİ HANGİ ŞEHİRDİR ?");
            Console.WriteLine(" A)BURSA\n B)İZMİR\n C)TEKİRDAĞ\n D)ANKARA\n Cevabınız:");
            string c2 =Console.ReadLine();

            if(c2 == "D")
            {
                
                Console.WriteLine("Tebrikler cevabınız doğru");
                para += 1000;
                dogru += 1;

            }
            else
            {
              
                Console.WriteLine("Cevabınız yanlış");
                yanlis += 1;
            }

            Console.WriteLine("Sonraki soruyu görmek  için entere basın");
            string s2 = Console.ReadLine();




            Console.WriteLine("Soru-3  HANGİSİ MARMARA BÖLGESİNDE OLAN BİR ŞEHİRDİR ?");
            Console.WriteLine(" A)BURSA\n B)İZMİR\n C)AĞRI\n D)UŞAK\n Cevabınız:");
            string c3 = Console.ReadLine();

            if (c3 == "A")
            {
               
                Console.WriteLine("Tebrikler cevabınız doğru");
                para += 1000;
                dogru += 1;


            }
            else
            {
                
                Console.WriteLine("Cevabınız yanlış");
                yanlis += 1;



            }
            Console.WriteLine("Sonraki soruyu görmek  için entere basın");
            string s3 = Console.ReadLine();




            Console.WriteLine("Soru-4  HANGİSİ EGE BÖLGESİNDE OLAN BİR ŞEHİRDİR ?");
            Console.WriteLine(" A)BURSA\n B)KONYA\n C)KÜTAHYA\n D)HATAY\n Cevabınız:");
            string c4 = Console.ReadLine();

            if (c4 == "C")
            {
                
                Console.WriteLine("Tebrikler cevabınız doğru");
                para += 1000;
                dogru += 1;


            }
            else
            {
               
                Console.WriteLine("Cevabınız yanlış");
                yanlis += 1;



            }
            Console.WriteLine("Sonraki soruyu görmek  için entere basın");
            string s4 = Console.ReadLine();




            Console.WriteLine("Soru-5  HANGİSİ BİR BİLGİSAYAR MARKASI DEĞİLDİR? ?");
            Console.WriteLine(" A)AUDİ\n B)LENOVO\n C)HP\n D)ASUS\n Cevabınız:");
            string c5 = Console.ReadLine();

            if (c5 == "A")
            {
               
                Console.WriteLine("Tebrikler cevabınız doğru");
                para += 1000;
                dogru += 1;


            }
            else
            {
                

                Console.WriteLine("Cevabınız yanlış");
                yanlis += 1;



            }
            Console.WriteLine("Sonuçları  görmek  için entere basın");
            string s5 = Console.ReadLine();




            Console.WriteLine("ADINIZ :"+ad);
            Console.WriteLine("SOYADINIZ :" + soyad);
            Console.WriteLine("DOĞRU CEVAP SAYISI: "+dogru);
            Console.WriteLine("YANLIŞ CEVAP SAYISI: "+yanlis);
            Console.WriteLine("PARANIZ:"+para+" TL");




            Console.ReadLine();


        }
    }
}
