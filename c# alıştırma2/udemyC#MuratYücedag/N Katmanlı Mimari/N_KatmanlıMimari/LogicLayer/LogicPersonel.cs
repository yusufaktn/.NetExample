using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {

        public static List<EntityPersonel> LL_PersonelListesi()
        {
            return DALPersonel.PersonelListesi();
        }


        public static int LL_PersonelEkle(EntityPersonel p)
        {

            if (p.AD != "" && p.SOYAD != "")
            {
                return DALPersonel.PersonelEkle(p);
            }
            else
            {
                return -1;
            }

        }

        public static int LL_PersonelSil(EntityPersonel p)
        {
            return DALPersonel.PersonelSil(p);
        }



        public static int LL_PersonelGüncelle(EntityPersonel p)
        {

            return DALPersonel.PersonelGüncelle(p);

        }








    }
}
