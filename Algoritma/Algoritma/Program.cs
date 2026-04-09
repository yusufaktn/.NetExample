using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritma
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Dizi içindeki sayılara  belirtilen hedefe toplayarak ulaşan en hızlı yöntem

            int[] sayilar = { 1, 10, 9, 2, 4, 5 };

            int hedef = 12;
            int toplam = 0;

            for (int i = 0; i < sayilar.Length; i++)
            {

                int sayi = sayilar[i];

                for (int k = 0; k < sayilar.Length; k++)
                {
                     toplam = sayi + sayilar[k];
                    if (toplam == hedef)
                    {

                        Console.WriteLine(toplam);
                        break;
                    }
                    else
                    {
                        toplam = 0;

                    }
                
                }
                if (toplam == hedef)
                {

                    break;

                }



            }
            Console.ReadLine();






        }
    }
}
