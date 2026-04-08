using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace not
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            
            
            string[] dersler = new string[10];
           
            int[] not = new int[10];


            for(int i = 0; i < dersler.Length; i++)
            {

                Console.WriteLine((i+1)+"."+"DERSİ GİRİNİZ = ");
                dersler[i] = Console.ReadLine();
                
                
            }

            for(int i = 0;i < not.Length; i++)
            {

                Console.WriteLine(dersler[i]+" "+"NOTUNU GİRİNİZ = ");
                not[i]=Convert.ToInt32(Console.ReadLine());

                
                    
                    
            }
             



        }
    }
}
