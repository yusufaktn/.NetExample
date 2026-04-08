using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ögrenciugulaması1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            ögrenci ogrenci1 = new ögrenci(202351501065, "MUHAMMET YUSUF", "AKTAN", "DUMLUPINAR ÜNİVERSİTESİ", 65, 73, 50);

            Console.WriteLine(" lütfen yapmak istediğiniz işlemi seçiniz");
            Console.WriteLine("  ");
            Console.WriteLine("1- öğrenci bilgileri göster ");
            Console.WriteLine("2- öğrenci ortalaması  göster ");
            Console.WriteLine("3- öğrenci okulunu  öğren ");
            Console.WriteLine("4- çıkış yap");


            
            bool kontrol = true;
            while (kontrol)
            {

                Console.WriteLine(" ");
                string girilensecenek = Console.ReadLine();

                /* if (girilensecenek == 1)
                 {

                     ogrenci1.bilgigoster();


                 }

                 else if (girilensecenek == 2)
                 {
                     ogrenci1.ortalamasibul();
                 }


                 else if ( girilensecenek == 3)
                 {

                     ogrenci1.okulgetir();
                 }

                 else
                 {
                     Console.WriteLine("çıkış yapılıyor...");

                 }
                
            
            */

            /*programımızı if else kullanarak yapmıştık şimdi de switch case yapısı kullaanark yaptık 
                  ayrıca bunu bir döngüye aldık böylece tekrar tekrar programı başlatmaya gereği duyamadık.*/
            /* switch (girilensecenek)
                {
                    case "1":
                    
                        ogrenci1.bilgigoster();
                        break;

                    case "2":
                        ogrenci1.ortalamasibul();
                        break;

                    case "3":
                        ogrenci1.okulgetir();
                        break;

                    case "4":
                        Console.WriteLine("çıkış yapılıyor...");
                        kontrol = false;
                        break;

                }
            }
            
            Console.ReadLine();

            */




            ogrencialıstırma ogrenci2 = new ogrencialıstırma(1, "yusuf", "aktan", 45, 67, 50, "dumlupınar üniversitesi");



            while (true)
            {
                Console.WriteLine("hoş geldiniz yapmak istediğiniz işlemi seçin");
                int girilendeger = Convert.ToInt32(Console.ReadLine());

                switch (girilendeger)
                {

                    case 1:
                        ogrenci2.bilgigoster();
                        break;

                    case 2:
                        ogrenci2.ortalamabul();
                        break;

                    case 3:
                        ogrenci2.okulgetir();
                        break;

                }

                Console.ReadLine();

            }

           





        }
    }
}
