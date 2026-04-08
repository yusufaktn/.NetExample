using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace murat_yucedağ_classandkapsulleme
{
    internal class araba
    {



        //KAPSÜLLEME 

        //Bu kavram, bir sınıfın veri alanlarını (fields) ve bu alanlara erişim yöntemlerini (methods) bir arada gruplama ve bu alanların doğrudan erişimini kısıtlama işlemidir.
        //Başka bir deyişle, sınıfın içeriğini gizleyerek sadece belirlenmiş yöntemler aracılığıyla verilere erişime izin verir.

        //private sadece bulunan  class tan erişilebilen başka class tan erişlemeyen veya belirlenmiş yöntemler ile erişilebilen (örn :get,set)







        private string renk;
        private int fiyat;
        private string model;
        private string vites;
        private string plaka;



        public string RENGI
        {
            get
            {
                return renk;
            }

            set
            {
                renk = value;

            }


        }

        public int FYAT
        {
            get
            {
                return fiyat;

            }

            set
            {
                if(value<1000000)
                {
                    Console.WriteLine(" piayasa fiyatının altında olamaz");
                    do
                    {
                        Console.WriteLine("yeni fiyat giriniz :");
                        int yenifiyat =Convert.ToInt32(Console.ReadLine());
                        if(yenifiyat>= 1000000)
                        {
                            fiyat = yenifiyat;
                            break;

                        }
                        Console.WriteLine("tekrar yeni fiyat girin !!!");

                    }while(true);

                }

                else
                {
                    fiyat = value;
                }
                
            }

        }




















        
















    }
}
