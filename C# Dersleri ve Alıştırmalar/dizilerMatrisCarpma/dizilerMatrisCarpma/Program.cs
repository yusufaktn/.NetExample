using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dizilerMatrisCarpma
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int[,] A = new int[2,3];
            int[,] B = new int[3,2];
            int[,] C = new int[2,2];


            /*
            for(int i=0; i<2; i++)
            {

                for(int j=0; j<2; j++)
                {

                    Console.WriteLine("dizinin {0}x{1} indexini girin :",i,j);
                    A[i,j] =Convert.ToInt32(Console.ReadLine());


                }




            }



            for(int i =0; i<2;i++)
            {

                for (int j=0; j<2;j++)
                {


                    Console.WriteLine("dizinin {0}x{1} indexini girin :", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }


            for(int i =0; i < 2; i++)
            {

                for( int j=0; j < 2; j++)
                {


                    C[i,j] = A[i,j] + B[i,j];


                }
                




            }

            for (int i = 0; i < 2; i++)
            {

                for (int j = 0; j < 2; j++)
                {

                    Console.Write(C[i,j]+" ");
                    


                }

                Console.WriteLine();



            }
            */

            for(int i=0; i<2; i++)
            {


                for(int j=0; j<3; j++)
                {

                    Console.WriteLine("dizinin {0}x{1} indexini girin :", i, j);
                    A[i,j]=Convert.ToInt32(Console.ReadLine());

                }

            }


            for (int i = 0; i < 3; i++)
            {


                for (int j = 0; j < 2; j++)
                {

                    Console.WriteLine("dizinin {0}x{1} indexini girin :", i, j);
                    B[i, j] = Convert.ToInt32(Console.ReadLine());

                }

            }


            for (int i = 0; i < 2; i++)
            {


                for (int j = 0; j < 2; j++)
                {






                }

            }




        }
    }
}
