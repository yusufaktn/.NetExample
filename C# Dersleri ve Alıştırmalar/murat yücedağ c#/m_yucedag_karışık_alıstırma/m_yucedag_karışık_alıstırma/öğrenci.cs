using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_yucedag_karışık_alıstırma
{
    internal class öğrenci:okul
    {

        private int id; 
        public string name;
        public string surname;
        public string cıty;
        public string school;
        



        public int ID
        {
            get
            {
                return id;
            }
            set
            {

                id = value;
            }
        }


    }
}
