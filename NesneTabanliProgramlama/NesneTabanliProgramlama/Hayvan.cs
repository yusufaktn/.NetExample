using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanliProgramlama
{
    public class Hayvan:Canli
    {
        public string Ad { get; set; }
        
        
        public Hayvan(string ad, string tür):base(tür)
        {
            this.Ad = ad;
        }

        public void SesCikar()
        {
            Console.WriteLine($"{Ad} ses çıkarıyor");
        }

    }
}
