using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_yucedag_karışık_alıstırma
{
    internal class AlanHesaplama

    {

        public double Dairealan(double yarıcap)
        {
            double pi = 3.14;
            double dalan = yarıcap * yarıcap * pi;
            return dalan;

        }

        public double karealan(double kenar)
        {
            double k_alan =kenar * kenar;
            return k_alan;


        }


        public double dikdörtgenalan(double kisakenar ,double uzunkenar)
        {
            double dd_alan = kisakenar * uzunkenar;
            return dd_alan;



        }




       


    }
}
