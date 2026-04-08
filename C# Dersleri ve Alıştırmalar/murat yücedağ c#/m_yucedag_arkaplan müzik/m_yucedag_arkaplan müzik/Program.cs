using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace m_yucedag_arkaplan_müzik
{
    internal class Program
    {
        static void Main(string[] args)
        {


            SoundPlayer ses = new SoundPlayer();
            string yol = @"C:\\Users\\myusu\\OneDrive\\Masaüstü\\Ümit Yaşar - Sabaha Kadar (Official 4K Lyric Video).wav";
            ses.SoundLocation = yol;
           




            Random random = new Random();

           int   rastgele = random.Next(0,100);

            int sayac = 0;

            while (true)
            {
                sayac++;
                Console.WriteLine("Sayı gir:");
                int sayi =Convert.ToInt32(Console.ReadLine());

                if (sayi >100 )
                {
                    Console.WriteLine("Sadece 0-100 arası sayı");
                    continue;
                }

                if (sayi<rastgele )
                {
                    Console.WriteLine();
                    Console.WriteLine("Sayıyı büyütün");

                }
                else if (sayi>rastgele)
                {
                    Console.WriteLine();
                    Console.WriteLine("Sayıyı küçültün");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Tebrikler doğru cevap!!!");
                    Console.WriteLine("{0} denemede buldunuz.",sayac) ;
                    
                    ses.Play();
                    break;

                }
                


            }



            Console.ReadLine();











        }
    }
}
