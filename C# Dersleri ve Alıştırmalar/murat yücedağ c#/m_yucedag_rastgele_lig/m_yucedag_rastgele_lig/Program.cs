using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_yucedag_rastgele_lig
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Rastgele Lig Turnuvamıza Hoşgeldiniz...\n ");
            Console.WriteLine("Katılan tüm takımlara başarılar dileriz.");

            int gs= 0;
            int fb = 0;
            int bjk = 0;
            int ts = 0;
            int hafta = 1;

            int a1, a2, a3;
            int b1, b2, b3;
            int c1, c2, c3;
            int d1, d2, d3;

            Random random = new Random();
          


            if (hafta == 1)
            {

                a1 = random.Next(0, 6);
                b1 = random.Next(0, 6);
                c1 = random.Next(0, 6);
                d1 = random.Next(0, 6);

                Console.WriteLine();
                Console.WriteLine(hafta+". hafta skorları :" );
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("GALATASARAY "+a1+"-"+c1+" BEŞİKTAŞ");
                if (a1 > b1)
                {
                    gs += 3;
                }
                else if(c1 > a1)
                {
                    bjk += 3;
                }
                else
                {
                    gs += 1;
                    bjk += 1;
                }

                Console.WriteLine("FENERBAHÇE " + b1 + "-" + d1 + " TRABZONSPOR");
                hafta++;

                if (b1 > d1)
                {
                    fb += 3;
                }
                else if (d1 > b1)
                {
                    ts += 3;
                }
                else
                {
                    fb += 1;
                    ts += 1;
                }

                Console.ReadLine();


            }


            if (hafta == 2)
            {

                a2 = random.Next(0, 6);
                b2 = random.Next(0, 6);
                c2 = random.Next(0, 6);
                d2 = random.Next(0, 6);

                Console.WriteLine();
                Console.WriteLine(hafta + ". hafta skorları :");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("BEŞİKTAŞ " + c2 + "-" + b2 + " FENERBAHÇE");


                if (c2 > b2)
                {
                    bjk += 3;
                }
                else if (b2 > c2)
                {
                    fb += 3;
                }
                else
                {
                    bjk += 1;
                    fb += 1;
                }
                Console.WriteLine("TRABZONSPOR " + d2 + "-" + a2 + " GALATASARAY");

                if (d2 > a2)
                {
                    ts += 3;
                }
                else if (a2 >d2)
                {
                    gs+= 3;
                }
                else
                {
                    gs += 1;
                    ts += 1;
                }


                hafta++;

                Console.ReadLine() ;

            }



            if (hafta == 3)
            {

                a3 = random.Next(0, 6);
                b3 = random.Next(0, 6);
                c3 = random.Next(0, 6);
                d3 = random.Next(0, 6);

                Console.WriteLine();
                Console.WriteLine(hafta + ". hafta skorları :");
                Console.WriteLine("-------------------------------------");

                Console.WriteLine("FENERBAHÇE " + b3 + "-" + a3 + " GALATASARAY");

                if (b3 > a3)
                {
                    fb += 3;
                }
                else if (a3 > b3)
                {
                   gs += 3;
                }
                else
                {
                    gs += 1;
                    fb += 1;
                }

                Console.WriteLine("TRABZONSPOR " + d3 + "-" + c3 + " BEŞİKTAŞ");

                if (d3 > c3)
                {
                    ts += 3;
                }
                else if (c3 > d3)
                {
                    bjk += 3;
                }
                else
                {
                    ts += 1;
                    bjk += 1;
                }


                hafta++;

                Console.ReadLine();



            }

            if(hafta == 4)
            {

                Console.WriteLine("PUAN TABLOSU") ;
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("GALATASARAY :"+gs+" PUAN");
                Console.WriteLine("FENERBAHÇE :" + fb+ " PUAN");
                Console.WriteLine("TRABZONSPOR :" + ts+ " PUAN");
                Console.WriteLine("BEŞİKTAŞ :" + bjk+ " PUAN");


            }

            
            Console.WriteLine();





















            Console.ReadLine();



        }
    }
}
