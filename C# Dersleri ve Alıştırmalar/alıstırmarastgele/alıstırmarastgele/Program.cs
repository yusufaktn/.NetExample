using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alıstırmarastgele
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0; 
           /*
            
            for (int i = 0; i<5 ; i++)
            {
                Console.WriteLine((i+1)+"."+" SAYIYI GİRİNİZ");
                int sayi1 = Convert.ToInt32(Console.ReadLine());

                 toplam = toplam +sayi1;


            }
            int ort = toplam / 5;

            Console.WriteLine("*************************************************");

            Console.WriteLine(toplam+" / "+ort);
            Console.ReadLine();
           */




            for (int i = 0; i<=100; i+=2)
            {

                Console.WriteLine(i);

            }
            Console.ReadLine();



        }
    }
}
