using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace C__Form_ödev
{
    public partial class AnaForm : MaterialForm
    {

        readonly MaterialSkin.MaterialSkinManager skinManager;
        public AnaForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey900,
            MaterialSkin.Primary.BlueGrey900,
            MaterialSkin.Primary.BlueGrey900,
            MaterialSkin.Accent.LightBlue200,
            MaterialSkin.TextShade.WHITE);
            HideTabHeaders();
        }

        private void HideTabHeaders()
        {
            // TabControl sekmelerini gizle
            materialTabControl1.Appearance = TabAppearance.FlatButtons;
            materialTabControl1.ItemSize = new Size(0, 1);
            materialTabControl1.SizeMode = TabSizeMode.Fixed;
        }


        Entity_UrunEntities db = new Entity_UrunEntities();
        //  URUNLER FORM  //
        //Urunler Sekmesine Tıklanıldığında Comboboxa Veri Gönderme//
        private void AnaForm_Load(object sender, EventArgs e)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("tr-TR");
            this.tBL_URUNTableAdapter.Fill(this.entity_UrunDataSet.TBL_URUN);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();

            var kategori = (from i in db.TBL_KATEGORI
                            select new
                            {
                                i.KATEGORI_ID,
                                i.KATEGORI_AD
                            }).ToList();

            cmb_kategori.ValueMember = "KATEGORI_ID";
            cmb_kategori.DisplayMember = "KATEGORI_AD";
            cmb_kategori.DataSource = kategori;


            var satislarmüsteri = (from i in db.TBL_MUSTERI
                                   select new
                                   {

                                       i.MUSTERI_ID,
                                       MUSTERI_FULLNAME = i.MUSTERI_AD + " " + i.MUSTERI_SOYAD

                                   }).ToList();

            cmb_satisMüsteri.ValueMember = "MUSTERI_ID";
            cmb_satisMüsteri.DisplayMember = "MUSTERI_FULLNAME";
            cmb_satisMüsteri.DataSource = satislarmüsteri;




            var satislarUrun = (from i in db.TBL_URUN
                                select new
                                {
                                    i.URUNID,
                                    i.URUNAD,
                                    i.FIYAT 

                                }).ToList();

            cmb_ürünSec.ValueMember = "URUNID";
            cmb_ürünSec.DisplayMember = "URUNAD";
            cmb_ürünSec.DataSource = satislarUrun;




        }


        //Ekle//
        private void btn_ekle_Click(object sender, EventArgs e)
        {
            TBL_URUN tbl_urun = new TBL_URUN();
            tbl_urun.URUNAD = txt_ürünad.Text;
            tbl_urun.URUNMARKA = txt_marka.Text;
            tbl_urun.STOKADET = int.Parse(txt_stok.Text);
            tbl_urun.FIYAT = int.Parse(txt_fiyat.Text);
            tbl_urun.DURUM = true;
            tbl_urun.KATEGORI_ID = byte.Parse(cmb_kategori.SelectedValue.ToString());
            db.TBL_URUN.Add(tbl_urun);
            db.SaveChanges();

            MessageBox.Show("Ürün Eklendi");


        }
        //Listele//
        private void btn_listele_Click(object sender, EventArgs e)
        {
            var listele = (from i in db.TBL_URUN
                           select new
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

        //Verilere Tıklanıldığında İlgili Yerleri Doldurma//

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ürünad.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_marka.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_kategori.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_stok.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txt_durum.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txt_fiyat.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }


        //Guncelle//
        private void btn_güncelle_Click(object sender, EventArgs e)
        {


            var i = db.TBL_URUN.Find(int.Parse(txt_id.Text));
            i.URUNAD = txt_ürünad.Text;
            i.URUNMARKA = txt_marka.Text;
            i.STOKADET = int.Parse(txt_stok.Text);
            i.FIYAT = decimal.Parse(txt_fiyat.Text);
            i.DURUM = true;
            i.KATEGORI_ID = byte.Parse(cmb_kategori.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi");
        }

        //Sil//
        private void btn_sil_Click(object sender, EventArgs e)
        {
            var i = db.TBL_URUN.Find(int.Parse(txt_id.Text));
            db.TBL_URUN.Remove(i);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi");
        }

        //Temizle//
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_id.Clear();
            txt_ürünad.Clear();
            txt_marka.Clear();
            txt_stok.Clear();
            txt_fiyat.Clear();
            txt_durum.Clear();
        }


        //İSTATİSTİK//

        private void Frmİstatistik_Load(object sender, EventArgs e)
        {

            lbl_kategorisayi.Text = db.TBL_KATEGORI.Count().ToString();
            lbl_toplamürünsayı.Text = db.TBL_URUN.Count().ToString();

            //(x=>) ifadesi bir "Lambda" ifadesidir yani anonim fonksiyondur burada x TBL_MUSTERI tablosunun içindeki her kaydı temsil eder.
            lbl_aktfmüsteri.Text = db.TBL_MUSTERI.Count(x => x.DURUM == true).ToString();
            lbl_psfmüsteri.Text = db.TBL_MUSTERI.Count(x => x.DURUM == false).ToString();
            lbl_beyazesya.Text = db.TBL_URUN.Count(x => x.KATEGORI_ID == 1).ToString();
            lbl_toplamstok.Text = db.TBL_URUN.Sum(x => x.STOKADET).ToString();
            lbl_kasadakitutar.Text = db.TBL_SIPARIS.Sum(x => x.TOPLAM_FIYAT).ToString() + "TL";

            //from ile i burada kayıtları temsil ediyor orderby ile desc şekilde sıralıyor ve ilk değerin ürün adını alıyor.Bunuda select ile seçiyoruz.
            lbl_enyüksekfiyat.Text = (from i in db.TBL_URUN orderby i.FIYAT descending select i.URUNAD).FirstOrDefault();
            lbl_endüsükfiyat.Text = (from i in db.TBL_URUN orderby i.FIYAT ascending select i.URUNAD).FirstOrDefault();
            lbl_sehirsayisi.Text = (from i in db.TBL_MUSTERI select i.MUSTERI_SEHIR).Distinct().Count().ToString();
            //Burada ise bir prosödür çağırıyoruz bunu sql de sorgumuzu yazıp orda (CREATE PROCEDURE AS ...(sorgumuz)) prosödür oluşturuyor ve VS den çağırıyoruz.
            //bu şekilde orda yazmamız gerekn sorguları rahatça kullanabiliyoruz.
            lbl_enfazlaürünlü_M.Text = db.MARKAGETIR().FirstOrDefault();

        }


        //Sipariş
        public class ListBoxItem
        {
            public int ID { get; set; } // Ürün ID'si
            public string DisplayText { get; set; } // Kullanıcıya görünecek metin
            public int Quantity { get; set; } // Ürün miktarı

            public override string ToString()
            {
                return DisplayText; // ListBox'ta sadece DisplayText görünecek
            }
        }


        decimal toplamf = 0;
        public void btn_listeyeEKle_Click(object sender, EventArgs e)
        {
            bool urunBulundu = false;
            var secilenurun = cmb_ürünSec.Text;
            var urun = (dynamic)cmb_ürünSec.SelectedItem;
            int urun_ıd = urun.URUNID;
            var fiiyat = ((dynamic)urun).FIYAT;
           

            for (int i = 0; i < Liste.Items.Count; i++)
            {



               // string mevcutUrun = Liste.Items[i].ToString();

                if (Liste.Items[i] is ListBoxItem mevcutUrun && mevcutUrun.ID == urun_ıd)
                {

                    mevcutUrun.Quantity++;
                    mevcutUrun.DisplayText = $"{secilenurun}   x{mevcutUrun.Quantity}";
                    Liste.Items[i] = mevcutUrun;
                    urunBulundu = true;
                   
                    

                    toplamf += fiiyat;

                    break;

                }




            }

            if (!urunBulundu)
            {

                var yeniurun = new ListBoxItem
                {
                    ID = urun_ıd,
                    DisplayText = $"{secilenurun}",
                    Quantity = 1,

                };
                Liste.Items.Add(yeniurun);
            }
            lbl_toplamfiyat.Visible = true;
            lbl_toplamfiyat.Text = toplamf.ToString("N0") + "TL";



        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Liste.Items.Count; i++)
            {

                if (Liste.Items[i] is ListBoxItem mevcutUrun)
                {
                    var yenisiparis = new TBL_SIPARIS
                    {
                        MUSTERI_ID = byte.Parse(cmb_satisMüsteri.SelectedValue.ToString()),
                        URUN_ID =mevcutUrun.ID,
                        ADET = (short)mevcutUrun.Quantity,
                        TOPLAM_FIYAT = toplamf


                    };
                    db.TBL_SIPARIS.Add(yenisiparis);
                    db.SaveChanges();


                }







            }
        }

        //MÜŞTERİLER//
        public void btn_müsteriListele_Click(object sender, EventArgs e)
        {
            var liste = db.TBL_MUSTERI.ToList();
            dataGridView2.DataSource = liste;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ıd.Text = dataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_ad.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_soyad.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_sehir.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_drm.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();


        }

        private void btn_ekleMüs_Click(object sender, EventArgs e)
        {
            db.TBL_MUSTERI.Add(new TBL_MUSTERI
            {
                MUSTERI_AD = txt_ad.Text,
                MUSTERI_SOYAD = txt_soyad.Text,
                MUSTERI_SEHIR = txt_sehir.Text,
                DURUM = true
            });
            db.SaveChanges();
        }

        private void btn_güncelleMüs_Click(object sender, EventArgs e)
        {
            TBL_MUSTERI tbl_musteri = new TBL_MUSTERI();
            var musteri = db.TBL_MUSTERI.Find(int.Parse(txt_ıd.Text));
            musteri.MUSTERI_AD = txt_ad.Text;
            musteri.MUSTERI_SOYAD = txt_soyad.Text;
            musteri.MUSTERI_SEHIR = txt_sehir.Text;
            musteri.DURUM = bool.Parse(txt_drm.Text);
            db.SaveChanges();
            btn_müsteriListele_Click(sender,e);

        }

        private void btn_silMüs_Click(object sender, EventArgs e)
        {
          DialogResult result = MessageBox.Show("Müşteriyi Silmek İstediğinize Emin misiniz ?","Onay",MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                TBL_MUSTERI tBL_MUSTERI = new TBL_MUSTERI();
                var musteri = db.TBL_MUSTERI.Find(int.Parse(txt_ıd.Text));
                db.TBL_MUSTERI.Remove(musteri);
                db.SaveChanges();
                btn_müsteriListele_Click(sender, e);
                
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi");
            }

        }

        private void btn_temizleMüs_Click(object sender, EventArgs e)
        {

            txt_ıd.Clear();
            txt_ad.Clear();
            txt_soyad.Clear();
            txt_sehir.Clear();
            txt_drm.Clear();

        }
    }
}
