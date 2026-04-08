using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m.yucedag_method1
{
    internal class Program
    {






        private static void veriler()
        {
            Console.WriteLine("muhammet yusuf aktan");
            Console.WriteLine("tc :28636368462");
            Console.WriteLine("okul : dumlupınar üniversitesi");
            Console.WriteLine("şehir : bursa");
            Console.WriteLine(DateTime.Now);
        }

        // klavyeden ekrana bir methot girin bize o mesajı ekrana 10 kere yazdırsın(methot kullanarak)


        private static void ekran()
        {
            Console.WriteLine("bir mesa giriniz :");
            string mesaj = Console.ReadLine();

            int i = 0;
            while (i< 10)
            {
                Console.WriteLine(mesaj);
                i++;
            }
            Console.ReadLine();
             
            
        }


        private static int kup(int sayi)
        {

            int kupu = sayi * sayi * sayi;
            return kupu;


        }
        private static int topla(int sayi, int  sayi2)
        {

            int toplam = sayi +sayi2;
            return toplam;

        }




        static void Main(string[] args)
        {
                                            //          METHOTLAR       //
           
            // Methotlar bizi kod fazlalığından kuratır.

            // ERişim belirleyici + static + türü +  metot adı

            // erişim belirleyiciler =  public(dışarıdan erişim var)   private(dışardan erişim yok)
            // static
            //türü =methotun geriye değer döndüreceği alan(void= içi boş geriye değer döndürmeyen)
            //void geçersiz içi boş anlamına gelir


            //veriler();
            

            //ekran();

 



            Console.WriteLine("bir sayı gir :"); ;
            int s =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" küpü :" + kup(s));
            

            Console.WriteLine("2. sayı gir");
            int s2 = Convert.ToInt32(Console.ReadLine());   
            Console.WriteLine("toplam :"+topla(s,s2));

            Console.ReadLine();

        }
    }
}
