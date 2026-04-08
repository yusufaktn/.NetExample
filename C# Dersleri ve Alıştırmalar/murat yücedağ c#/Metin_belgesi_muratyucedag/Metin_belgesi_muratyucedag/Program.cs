using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Metin_belgesi_muratyucedag
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dosya için isim giriniz:");   
            string isim =Console.ReadLine();
            
            /* Burada kullanıcıdan bir dosya ismi alıyoruz ve daha sonra bu dosya ismini belirtiğimiz yola oluşturuyor.
             * Böylece her seferinde console açıldığında aynı dosya üzerine yazmıyor.*/

            StreamWriter dosya = new StreamWriter("C:\\Users\\myusu\\OneDrive\\Masaüstü\\notlarım\\"+isim+".txt");
            string veri;
            Console.WriteLine("Buraya Notunuzu Yazınız: ");
            veri = Console.ReadLine();

            dosya.WriteLine(veri);
            dosya.Close();


















        }
    }
}
