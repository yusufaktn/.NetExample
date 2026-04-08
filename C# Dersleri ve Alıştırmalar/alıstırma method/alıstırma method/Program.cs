using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alıstırma_method
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write(" 1. sayıyı griniz =");
            int birincigirilen =int.Parse(Console.ReadLine());

            Console.Write("2.sayıyı griniz =");
            int ikincigirilen = int.Parse(Console.ReadLine());


            sayi2(birincigirilen, ikincigirilen);


            Console.ReadLine(); 


        }




        static void sayi(int x) 
        {

            if (x%2 == 0)
            {

                Console.WriteLine("SAYINIZ ÇİFTTİR ");

            }
            
            else
            {
                Console.WriteLine("SAYINIZ TEKTİR ");
            }





        }


        static void sayi2(int a,int b)
        {

            if(a>b)
            {
                Console.WriteLine(a + " " + "BÜYÜKTÜR.");

            }
            else
            {
                Console.WriteLine(b+" "+"BÜYÜKTÜR.");

            }



        }










    }
}
