using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NesneTabanliProgramlama
{
    public class Canli
    {
        public string Tür { get; set; }



        public Canli(string tür)
        {
            this.Tür = tür;
           
        }

        public void YasamaSuresi(int yil)
        {
            Console.WriteLine($"{Tür} canlısının yaşam süresi {yil} yıldır.");
        }

        public virtual void  BilgiGoster()
        {
            Console.WriteLine($"Bu bir {Tür} canlısıdır.");
        }
        

        

        
        
    }
}
