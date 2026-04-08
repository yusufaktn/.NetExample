using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace murat_yucedağ_class
{
    internal class personel
    {


        private string tc;
        private string name;
        private int age;


        public string TC
        {
            get
            {
                tc = tc.Substring(0,4)+"*******";
                return tc;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || value.Length !=11)
                {

                    Console.WriteLine("TC no boş ve 11 karakterden az veya fazla olamaz.");

                }
                else
                {
                        tc = value;

                }
            }
        }





    }
}
