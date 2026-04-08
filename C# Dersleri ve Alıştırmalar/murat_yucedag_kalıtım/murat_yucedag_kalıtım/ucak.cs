using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace murat_yucedag_kalıtım
{
    internal class ucak:yolcu
    {

        // yukarıdaki gibi   ucak:yolcu   olarak belirttiğimizde yolcu sınıfındaki değikenleri ve erişim belirleyicileri ucak sınıfına aktarmış olduk.



        private string marka;
        private string kalkis;
        private string varis;


        public string MARKA
        {
            get
            {
                return marka;

            }


            set
            {
                marka = value.ToUpper();

            }
        }


        public string KALKIS
        {

            get
            {
                return kalkis;
            }
            set
            {
                kalkis = value.ToUpper();
            }
        }

        public string VARIS
        {

            get
            {
                return varis;
            }
            set
            {

               varis = value.ToUpper();

            }
        }









    }
}
