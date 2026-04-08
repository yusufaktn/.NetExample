using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace murat_yucedag_çokbiçimlilik
{
    internal class Program
    {

        class insan
        {

            public virtual void selamver()
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.Title = " ÇOK BİÇİMLİLİK ÖRNEK";
                Console.WriteLine("MERHABA İNSAN");

            }

        }


        class türk:insan
        {

            public override void selamver()
            {
                Console.WriteLine("ESENLİKLER DİLERİM");

            }


        }
        class ispanyol : insan
        {


            public override void selamver()
            {
               Console.WriteLine("HOLA");
            }

        }


        static void Main(string[] args)
        {

           
           ispanyol ispa = new ispanyol();
            ispa.selamver();
            

            Console.ReadLine();







        }
    }
}
