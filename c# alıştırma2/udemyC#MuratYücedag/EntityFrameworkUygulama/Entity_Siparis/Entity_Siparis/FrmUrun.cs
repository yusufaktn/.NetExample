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
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        Entity_UrunEntities1 db = new Entity_UrunEntities1();

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            TBL_URUN tBL_URUN = new TBL_URUN();
            tBL_URUN.URUNAD= txt_ürünad.Text;
            tBL_URUN.URUNMARKA=txt_marka.Text;
            tBL_URUN.STOKADET=int.Parse(txt_stok.Text);
            tBL_URUN.FIYAT=decimal.Parse(txt_fiyat.Text);
            tBL_URUN.DURUM = true;
            tBL_URUN.KATEGORI_ID = byte.Parse(cmb_kategori.SelectedValue.ToString());
            db.TBL_URUN.Add(tBL_URUN);
            db.SaveChanges();
            MessageBox.Show("Ürün Eklendi...");

        }
       

        private void btn_listele_Click(object sender, EventArgs e)
        {
            // from foreach döngüsü gibi düşünebiliriz bir değerimiz var bu "i" ve db.TBL_URUN içinde dolaşıyor.

            var listele = (from i in db.TBL_URUN select new
            {
                           i.URUNID,
                           i.URUNAD,
                           i.URUNMARKA,
                           i.TBL_KATEGORI.KATEGORI_AD,
                           i.STOKADET,
                           i.DURUM,
                           i.FIYAT,



            }).ToList();
            dataGridView1.DataSource = listele;
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            var i= db.TBL_URUN.Find(int.Parse(txt_id.Text));
            db.TBL_URUN.Remove(i);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");

        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_ürünad.Clear();
            txt_marka.Clear();
            txt_stok.Clear  ();
            txt_fiyat.Clear();
            txt_durum.Clear();
            

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            var i = db.TBL_URUN.Find(int.Parse(txt_id.Text));
            i.URUNAD=txt_ürünad.Text;
            i.URUNMARKA=txt_marka.Text;
            i.STOKADET = int.Parse(txt_stok.Text);
            i.FIYAT = decimal.Parse(txt_fiyat.Text);
            i.DURUM=true;
            i.KATEGORI_ID= byte.Parse(cmb_kategori.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ürünad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_marka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_kategori.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_durum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_fiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            var kategori = (from i in db.TBL_KATEGORI
                            select new { 
                                i.KATEGORI_ID, 
                                i.KATEGORI_AD 
                            
                            }).ToList();
            cmb_kategori.ValueMember = "KATEGORI_ID";
            cmb_kategori.DisplayMember = "KATEGORI_AD";
            cmb_kategori.DataSource = kategori;
        }
    }
}
