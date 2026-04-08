using murat_yucedağ_classandkapsulleme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace murat_yucedağ_class
{
    internal class Program

    {


        







        static void Main(string[] args)
        {
            //araba 

            Console.WriteLine(" araba fiyatı girin :");
            int fıyat =Convert.ToInt32(Console.ReadLine());





            araba arbsınıf = new araba();

            arbsınıf.RENGI = "kırmızı";
            arbsınıf.FYAT = fıyat;


            // NORMAL PUBLİC KULLANIM
            /*
            arbsınıf.model = "WOLSVAGEN PASSAT 1.6 TDİ";
            arbsınıf.vites = "yarı-otomatik";
            arbsınıf.plaka = "16 ASN 036";
            */




            Console.WriteLine("araba rengi ="+arbsınıf.RENGI);
            Console.WriteLine("araba fiyatı =" + arbsınıf.FYAT);







            //bina

            Console.WriteLine("BİNA KONUMUNU GİRİN :");
            string knm = Console.ReadLine();


            bina bina1 = new bina();
            bina1.konum =knm;
            bina1.AD = "İŞLER APT.";

            Console.WriteLine("bina konumu :"+bina1.konum);
            Console.WriteLine("bina adı :"+bina1.AD);




            // personel

            personel prs = new personel();
            prs.TC = "28636368462";



            Console.WriteLine("personel tc ="+prs.TC);




            Console.ReadLine();






        }
    }
}
