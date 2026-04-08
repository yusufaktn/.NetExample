using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Entity_Siparis
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
            this.StartPosition= FormStartPosition.CenterScreen;
        }


        Entity_UrunEntities1 db = new Entity_UrunEntities1();
        

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {

            lbl_kategorisayi.Text = db.TBL_KATEGORI.Count().ToString();
            lbl_toplamürünsayı.Text = db.TBL_URUN.Count().ToString();

            //(x=>) ifadesi bir "Lambda" ifadesidir yani anonim fonksiyondur burada x TBL_MUSTERI tablosunun içindeki her kaydı temsil eder.
            lbl_aktfmüsteri.Text = db.TBL_MUSTERI.Count(x => x.DURUM == true).ToString();
            lbl_psfmüsteri.Text = db.TBL_MUSTERI.Count(x=>x.DURUM==false).ToString();
            lbl_beyazesya.Text = db.TBL_URUN.Count(x => x.KATEGORI_ID ==1 ).ToString();
            lbl_toplamstok.Text = db.TBL_URUN.Sum(x => x.STOKADET).ToString();
            lbl_kasadakitutar.Text = db.TBL_SIPARIS.Sum(x=>x.TOPLAM_FIYAT).ToString()+"TL";

            //from ile i burada kayıtları temsil ediyor orderby ile desc şekilde sıralıyor ve ilk değerin ürün adını alıyor.Bunuda select ile seçiyoruz.
            lbl_enyüksekfiyat.Text = (from i in db.TBL_URUN orderby i.FIYAT descending select i.URUNAD ).FirstOrDefault();
            lbl_endüsükfiyat.Text = (from i in db.TBL_URUN orderby i.FIYAT ascending select i.URUNAD ).FirstOrDefault();
            lbl_sehirsayisi.Text = (from i in db.TBL_MUSTERI select i.MUSTERI_SEHIR).Distinct().Count().ToString();
            //Burada ise bir prosödür çağırıyoruz bunu sql de sorgumuzu yazıp orda (CREATE PROCEDURE AS ...(sorgumuz)) prosödür oluşturuyor ve VS den çağırıyoruz.
            //bu şekilde orda yazmamız gerekn sorguları rahatça kullanabiliyoruz.
            lbl_enfazlaürünlü_M.Text= db.MARKAGETIR().FirstOrDefault();

        }
    }
}
