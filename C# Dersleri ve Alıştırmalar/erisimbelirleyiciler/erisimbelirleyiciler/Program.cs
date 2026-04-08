using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace erisimbelirleyiciler
{
    internal class Program
    {
        static void Main(string[] args)
        {


            /*ERİŞİM BELİRLEYİCİLER BİR ŞEYE ERİŞMEK İÇİN KOYDUĞUMUZ KISITLAMALARDIR
             * PUBLİC VE PRİVATE*/
                                      
            /*Görülüdğü gibi müşteri cinsiyeti(musterigender) da bize bir hata verdi çünkü erişim belirleyicisini class
             içerisinde private olarak belirttik bu şu anlama geliyor public halka açık dış dünyaya açık demektir yani class dışından 
            buraya ulaşabilriz demektir 
            Fakat private olarak belirttiğimizde  bunu dış dünyaya kapatırız yani sadece class içerisinden değer atayabiliriz.*/

           /* musteri musteri1 = new musteri();

            musteri1.musteriName = "muhammet yusuf ";
            musteri1.musterisurname = "aktan";
            musteri1.musterisalary = 15000;
            musteri1.musterigender;

            musteri1.musteriinfo();
             Console.ReadLine    ();
             */


            musteri musteri1 = new musteri("muhammet yusuf","aktan",15000);

            musteri1. bilgiac();
           
            Console.ReadLine();
            
        }




    }
}
