using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace murat_yucedag_kalıtım
{
    internal class Program
    {
        static void Main(string[] args)
        {

                                        //              KALITIM             //

            // Bu örnekte görüldüğü gibi yolcu  ve ucak adında iki sınıf oluşturduk.Eğer ucak sınıfından
            // bir nesne çağırırken  yolcu sınıfındaki erişim belirleyici ve değişkenleri uçak sınıfından çağırmak istiyorsak kalıtım kullanıyoruz.



            ucak uck = new ucak();
            uck.MARKA = "türk hava yolları";
            uck.KALKIS = " bursa havalimanı";
            uck.VARIS = "istanbul-sabihagökçen";
            uck.AD = "Yusuf";
            uck.SOYAD = "aktan";
            uck.YAS = 22;
            uck.CINSIYET = "erkek";

            Console.WriteLine("HAVA YOLU ŞİRKETİ : "+uck.MARKA);
            Console.WriteLine("KALKIŞ NOKTASI : "+uck.KALKIS);
            Console.WriteLine("VARIŞ NOKTASI : " + uck.VARIS);
            Console.WriteLine("YOLCU ADI : " + uck.AD);
            Console.WriteLine("YOLCU SOYADI : "+uck.SOYAD);
            Console.WriteLine("YOLCU YAŞI : " + uck.YAS);
            Console.WriteLine("YOLCU CİNSİYETİ : " + uck.CINSIYET);

           Console.ReadLine();








        }
    }
}
