using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Siparis
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Entity_UrunEntities1 db = new Entity_UrunEntities1();
        private void button1_Click(object sender, EventArgs e)
        {
            //Listeleme işlemi
            var  kategori = db.TBL_KATEGORI.ToList();
            dataGridView1.DataSource= kategori;
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            //Tabloya yeni bir alan ekleme yani insert işlemi

            TBL_KATEGORI t = new TBL_KATEGORI();
            t.KATEGORI_AD=txt_kategoriAD.Text;
            db.TBL_KATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi...");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            //Kategori tablosundan veri silme işlemi

            var kategori = db.TBL_KATEGORI.Find(Convert.ToInt32(txt_kategoriID.Text));//Find methotu txt_kategoriID den gelen değeri TBL_KATEGORI içinde buluyor ve bunu kategori değişkenine atıyor.
            db.TBL_KATEGORI.Remove(kategori);
            db.SaveChanges();
            MessageBox.Show("Kategori Silindi");
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            var kategori = db.TBL_KATEGORI.Find(Convert.ToInt32(txt_kategoriID.Text));
            kategori.KATEGORI_AD= txt_kategoriAD.Text;
            db.SaveChanges();
            MessageBox.Show("Günceleme Tamam");
        }
    }
}
