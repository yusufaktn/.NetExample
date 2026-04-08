using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classs
{
    internal class EV
    {

        /* classlar ile bir çok şey yapabiliriz ilk önce sağ tarafta solution bölümünden projeye sağ tık yapıp add/class diyoruz
         *  daha sonra aşığıdaki  gibi  veri tipine göre değişkenleri belirtiyoruz
         *  method da kullanabiliriz.
         *  daha sonra bunları tek tek çağırıp değer verebiliriz.
         
         
         
         
         
         */



       public string evrengi;
       public  int dairesayi;
        public string evtipi;



        public EV(string _evrengi,int _dairesayisi,string _evtipi)
        {
            
            evrengi= _evrengi;
            dairesayi= _dairesayisi;
            evtipi= _evtipi;

        }

        public void evkonumu()
        {
            Console.WriteLine(" EV KONUMUNUZ = yeşil camii mahallesi / bursa / iznik");

        }


    }
}
