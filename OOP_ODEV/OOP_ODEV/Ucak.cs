using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ODEV
{
    public class Ucak
    {
        private string  _model;
        private string _renk;
        private int _yolcuKapasitesi;
        private List<Yolcu>_yolcular;

        public Ucak(string model, string renk, int yolcuKapasitesi)
        {
            _model = model;
            _renk = renk;
            _yolcuKapasitesi = yolcuKapasitesi;
            
        }

        private void YolcuEkle(Yolcu yolcu)
        {
            if (_yolcular.Count < _yolcuKapasitesi)
            {
                _yolcular.Add(yolcu);
            }
            else
            {
                Console.WriteLine("Uçak dolu");
            }
        }

        private void YolcuCikar(Yolcu yolcu)
        {
            if (_yolcular.Contains(yolcu))
            {
                _yolcular.Remove(yolcu);
            }
            else
            {
                Console.WriteLine("Yolcu bulunamadı");
            }
        }

        private void YolcuListele()
        {
            foreach (var yolcu in _yolcular)
            {
                Console.WriteLine(yolcu);
            }
        }


    }
}
