using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrisler_alıstırma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int satir, sutun;
           
           
            int[,] amatrisi = new int[2,3];
            int[,] bmatrisi = new int[3,2];
            int[,] cmatrisi = new int[2,2];




            for(int i = 0; i< 2; i++)
            {
                
                for(int j = 0; j< 3; j++)
                {
                    Console.WriteLine("A MATRİSİ {0}x{1} dizisini giriniz :",i,j);
                    amatrisi[i,j]=int.Parse(Console.ReadLine());

                }

            }


            for(int k= 0; k< 3; k++)
            {

                for(int l = 0;l< 2; l++)
                {

                    Console.WriteLine("B MATRİSİ {0}x{1} dizisini giriniz :", k, l);
                    
                    bmatrisi[k,l]=int.Parse(Console.ReadLine());


                }

                


            }



            for (int m = 0; m < 2; m++)
            {
                
                for (int n = 0; n < 2; n++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                       cmatrisi[m, n] = amatrisi[m, k] * bmatrisi[k, m];

                    }
                    


                }

            }


            Console.WriteLine("*****A MATRİSİ*****");    

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(amatrisi[i,j]+" ");

                }
                Console.WriteLine();

            }



            Console.WriteLine() ;

            Console.WriteLine("***** B MATRİSİ*****");

            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 2; j++)
                {
                    Console.Write(bmatrisi[i, j] + " ");

                }
                Console.WriteLine();

            }



            Console.WriteLine();





            Console.WriteLine("*****C MATRİSİ*****");




            for (int n = 0; n< 2; n++)
            {

                for (int k = 0; k< 2; k++)
                {

                    Console.Write(cmatrisi[n,k]+" ");
                }
                Console.WriteLine();

            }

            Console.ReadLine();






        }
    }
}
