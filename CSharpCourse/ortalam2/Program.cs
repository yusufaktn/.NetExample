using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ortalam2
{
    internal class Program
    {
        static void Main(string[] args)
        {






            int vize, final, ort, ;

            



            

            Console.Write("VİZE NOTUNU GİRİNİZ : ");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("FİNAL NOTUNU GİRİNİZ: ");
            final = Convert.ToInt32(Console.ReadLine());



            ort = Convert.ToInt32   ( vize * 04 / 100 + final * 06 / 100);




            Console.WriteLine();
            Console.WriteLine("ORTALAMANIZ = {0}" + ort);
            Console.WriteLine();





        }
    }
}
