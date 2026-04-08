using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsülleme
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /* private olarak erişim belirleyici kullandığımızda buna class dışından ulaşamayız fakat buna ulaşmammız gerektiğinde bu durumda kapsüllemeye ihtiyaç duyuyoruz. */

            //geter seter metotlar
            //property ile


            ogrenci ogrenci1 = new ogrenci();
          
            ogrenci1.setisim("enes");
           string giris= ogrenci1.getisim();

            Console.WriteLine(giris);
            Console.ReadLine();
        }
    }
}
