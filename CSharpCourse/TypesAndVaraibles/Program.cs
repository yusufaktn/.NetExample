using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVaraibles
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //var number = -102;
            //if (number == 10)
            //{
            //    Console.WriteLine("Number is 10 ");
            //    Console.ReadLine();
            //}

            //else if (number == 20)
            //{
            //    Console.WriteLine("Number is 20");
            //}


            //else
            //{
            //    Console.WriteLine("Number is not 10 or 20");
            //}

            //Console.ReadLine();

            //switch (number)




            //SWİTCH BLOĞU


            //{
            //    case 10:
            //        Console.WriteLine("Number is 10 ");
            //        break;
            //    case 20:
            //        Console.WriteLine("Number is 20");
            //        break;
            //    default:
            //        Console.WriteLine("Number is not 10 or 20");
            //        break;

            //}

            //Console.ReadLine();


            //if (number >= 0 && number < 100)

            //{
            //    Console.WriteLine("Number is between 0-100");

            //}

            //else if (number > 100 && number <= 200)
            //{
            //    Console.WriteLine("Number is between 101-200 ");

            //}
            //else if (number < 0 || number > 200)
            //{
            //    Console.WriteLine("Number is less than 0 greater than 200");

            //}
            //Console.ReadLine();




            //var note1 = 50;
            //var note2 = 51;
            //var ortalama = 0;
            //ortalama = note1 * 40 / 100 + note2 * 60 / 100;



            //{
            //    Console.WriteLine("VİZE NOTUNUZ = " + note1);
            //    Console.WriteLine("FİNAL NOTUNUZ = " + note2);
            //    Console.WriteLine("ORTALAMANIZ = " + ortalama);

            //}

            //if (ortalama < 50 || note2 < 50)
            //{


            //    Console.WriteLine("KALDINIZ");



            //}



            //else
            //{

            //    Console.WriteLine(" GEÇTİNİZ");

            //}



            //if (ortalama < 100 && ortalama >= 85)

            //{
            //    Console.WriteLine(" HARF NOTUNUZ  =  AA ");

            //}




            //else if (ortalama <= 84 && ortalama >= 80)

            //{

            //    Console.WriteLine("HARF NOTUNUZ  =  BA ");




            //}


            //else if (ortalama <= 79 && ortalama >= 75)

            //{

            //    Console.WriteLine(" HARF NOTUNUZ  =  BB ");




            //}



            //else if (ortalama <= 74 && ortalama >= 70)

            //{

            //    Console.WriteLine(" HARF NOTUNUZ  =  CB ");




            //}



            //else if (ortalama <= 69 && ortalama >= 60)

            //{

            //    Console.WriteLine("HARF NOTUNUZ  =  CC ");



            //}





            //else if (ortalama <= 59 && ortalama >= 55)

            //{

            //    Console.WriteLine(" HARF NOTUNUZ  =  DC ");



            //}




            //else if (ortalama <= 54 && ortalama >= 50)

            //{

            //    Console.WriteLine(" HARF NOTUNUZ  =  DD ");



            //}



            //else if (ortalama <= 49 && ortalama >= 40)

            //{

            //    Console.WriteLine("HARF NOTUNUZ  =  FD ");



            //}



            //else if (ortalama <= 39 && ortalama >= 0)

            //{

            //    Console.WriteLine("HARF NOTUNUZ  =  FF ");



            //}

            //Console.ReadLine(); 



            int vize, final, ort, vYuzde, fYuzde;






            Console.Write("VİZE YÜZDESİ GİR =  ");
            vYuzde = Convert.ToInt32(Console.ReadLine());
            fYuzde = 100 - vYuzde;

            Console.Write("VİZE NOTUNU GİRİNİZ : ");
            vize = Convert.ToInt32(Console.ReadLine());

            Console.Write("FİNAL NOTUNU GİRİNİZ: ");
            final = Convert.ToInt32(Console.ReadLine());



            ort = Convert.ToInt32(vize * vYuzde/100 + final * fYuzde/100);


            Console.WriteLine();
            Console.WriteLine("ORTALAMANIZ = "+ ort);
            Console.WriteLine();


            if (ort > 100  ||  ort <0)
            {
                Console.WriteLine("GEÇERSİZ SAYI TEKRAR DENEYİN");
                Console.ReadLine();
            }





            if (ort <= 100 && ort >= 85)

            {
                Console.WriteLine(" HARF NOTUNUZ  =  AA ");

            }




            else if (ort <= 84 && ort >= 80)

            {

                Console.WriteLine("HARF NOTUNUZ  =  BA ");




            }


            else if (ort <= 79 && ort >= 75)

            {

                Console.WriteLine(" HARF NOTUNUZ  =  BB ");




            }



            else if (ort <= 74 && ort >= 70)

            {

                Console.WriteLine(" HARF NOTUNUZ  =  CB ");




            }



            else if (ort <= 69 && ort >= 60)

            {

                Console.WriteLine("HARF NOTUNUZ  =  CC ");



            }





            else if (ort <= 59 && ort >= 55)

            {

                Console.WriteLine(" HARF NOTUNUZ  =  DC - Koşullu Geçer");



            }




            else if (ort <= 54 && ort >= 50)

            {

                Console.WriteLine(" HARF NOTUNUZ  =  DD ");



            }



            else if (ort <= 49 && ort >= 40)

            {

                Console.WriteLine("HARF NOTUNUZ  =  FD ");



            }



            else if (ort <= 39 && ort >= 0)

            {

                Console.WriteLine("HARF NOTUNUZ  =  FF ");



            }





            if (ort < 50 || final < 50)
                Console.WriteLine("KALDINIZ");

            else
                Console.WriteLine("GEÇTİNİZ");






            Console.ReadKey();




























        }
    }
}


