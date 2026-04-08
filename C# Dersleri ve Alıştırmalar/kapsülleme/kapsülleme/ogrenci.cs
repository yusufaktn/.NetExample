using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kapsülleme
{
    public class ogrenci
    {

        private string isim = "enes";

        /*burada isim değişkenini private ile belirttik daha sonra buna erişmek için get ve set methotlarını
         kullandık set ile atama yaptık get ile geri döndürdük ve bu değeri tutup ekrana yazdırdık.*/
        public void  setisim(string isim_)
        {
            isim = isim_;
            

        }

        public string getisim()
        {
            return isim;
        }






    }
}
