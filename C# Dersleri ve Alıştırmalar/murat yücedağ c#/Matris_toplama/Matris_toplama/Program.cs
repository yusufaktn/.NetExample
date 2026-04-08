using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matris_toplama
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //      ÖDEV   :  matris toplama 2x4 tipinde matris        //

            /*

            int[,] matris1 = { {10,20,30,40} , {20,30,40,20} };
            int[,] matris2 = { {20,30,50,60} , {20,30,60,80} };
           
            int[,] toplam_matris = new int  [2, 4];



            for (int i = 0; i <=1; i++)
            {

                for (int j = 0; j <=3; j++)
                {
                    toplam_matris[i,j] = matris1[i,j]+ matris2[i,j];
                }


            }



            for (int i = 0;i <=1; i++)
            {
                Console.WriteLine(" ");
                for (int j = 0;j <=3; j++)
                {

                    Console.Write( toplam_matris[i,j]+"   ");
                    

                }



            }
            Console.ReadLine();
           
             
             */





            int satir, sutun;

            Console.WriteLine(" satır sayısını giriniz :");
            satir = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(" sütun sayısını giriniz :");
            sutun = Convert.ToInt16(Console.ReadLine());

            int[,]matris1 =new int[satir, sutun];

            Console.WriteLine();
            for (int i = 0; i < satir; i++)
            {
                for(int j = 0; j < sutun; j++)
                {

                    Console.WriteLine(" {0}x{1} değerini giriniz : ",i+1,j+1);
                    
                    matris1[i,j]= Convert.ToInt16(Console.ReadLine());

                    Console.WriteLine();
                }

            }

            Console.WriteLine();


            for(int k=0; k < satir; k++)
            {


                for (int l = 0; l < sutun; l++)
                {
                    Console.Write(matris1[k,l]+"  ");

                }
                Console.WriteLine();

            }
            
            Console.WriteLine() ;

            //   TRANSPOZE
            // satır ve sütun sayıları aynı olması gerekiyor.
            //Eğer matrisi transpoze etmek istiyorsak bu örn:3x3 olmalıdır 3x2 olarak belirtirsek program hata verecektir.
            //Çünkü satır ve sütün sayısı değişir ve program hata verir.


            for (int m=0; m < satir; m++)
            {
                for(int n=0; n < sutun; n++)
                {
                    Console.Write(matris1[n,m]+" ");  
                }
                Console.WriteLine() ;
            }


            Console.ReadLine();












        }
    }
}
