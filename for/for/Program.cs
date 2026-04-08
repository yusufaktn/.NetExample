using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  For döngüsü ile aşağıda olduğu gibi sıfırdan yüze kadar sayıları yazdırabiliriz
            //  i ' ye 1 değerini atayıp i 100 küçük eşit olana kadar i ' yi 1 arttırmasını söyledik.
            /* for (int i = 1; i <= 100; i++)
             {

             Console.WriteLine(i);





             }

             Console.WriteLine("TEBRİKLER");
             Console.ReadLine();

             */

           int  fakto = 1;
           
            Console.WriteLine("LÜTFEN FAKTÖRİYELİ HESAPLANACAK SAYI GİRİNİZ");

            int sayi1 =Convert.ToInt32(Console.ReadLine());

            for (int i = sayi1;  i>=1;   i -= 1)
            {


                fakto = i * fakto;




            }


            Console.WriteLine("SONUÇ= "+ fakto);
            Console.ReadLine();







        } 
    }
}
