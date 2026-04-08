using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int id;
        private string ad;
        private string soyad;
        private string sehir;
        private string gorev;
        private int maas;

        public int ID { get => id; set => id = value; }
        public string AD { get => ad; set => ad = value; }
        public string SOYAD { get => soyad; set => soyad = value; }
        public string SEHIR { get => sehir; set => sehir = value; }
        public string GOREV { get => gorev; set => gorev= value; }
        public int MAAS { get => maas; set => maas = value; }
    }
}
