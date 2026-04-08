using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilyaForm
{
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        SqlBaglanti SqlBaglanti = new SqlBaglanti();




        private void MusteriEkle_Load(object sender, EventArgs e)
        {

            //this.tbl_KategoriTableAdapter.Fill(this.mobilyaDbDataSet3.Tbl_Kategori);
            SqlBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("Select*From Tbl_Kategori", SqlBaglanti.baglanti());
            SqlDataReader dt = komut.ExecuteReader();
            while (dt.Read())
            {
                cmbbx_Kategori.Items.Add(dt[1].ToString());


            }
            SqlBaglanti.baglanti().Close();




        }

        private void cmb_ÜrünAd_SelectedIndexChanged(object sender, EventArgs e)

        {


        }

        Dictionary<string, decimal> urunFiyat_ad = new Dictionary<string, decimal>();
        private void cmbbx_Kategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_ÜrünAd.Items.Clear();
            cmb_ÜrünAd.Text = "";
            SqlBaglanti.baglanti();
            SqlCommand komut2 = new SqlCommand("select Tbl_Urun.UrunAd ,Tbl_Kategori.KategoriAd,Tbl_Urun.UrunFiyat from Tbl_Urun Inner join Tbl_Kategori on Tbl_Urun.KategoriID=Tbl_Kategori.KategoriID where KategoriAd=@k1", SqlBaglanti.baglanti());
            komut2.Parameters.AddWithValue("@k1", cmbbx_Kategori.SelectedItem.ToString());
            SqlDataReader dt2 = komut2.ExecuteReader();
            while (dt2.Read())
            {

                string urunad = dt2[0].ToString();
                decimal urunfiyat = Convert.ToDecimal(dt2[2]);
                cmb_ÜrünAd.Items.Add(urunad);
                urunFiyat_ad[urunad] = urunfiyat;
            }
            SqlBaglanti.baglanti().Close();
        }

        List<Ürünler> Sepetteki_Ürünler = new List<Ürünler>();
        decimal toplam_fiyat = 0;
        int adet = 1;
        private void button1_Click(object sender, EventArgs e)
        {

            
            string secilen = cmb_ÜrünAd.SelectedItem.ToString();


            if (urunFiyat_ad.ContainsKey(secilen))
            {
                if (txt_ürünAdet.Text != "")
                {
                    adet = Convert.ToInt32(txt_ürünAdet.Text);
                }
                decimal urunfiyat = urunFiyat_ad[secilen];

                Ürünler mevcutürün = Sepetteki_Ürünler.FirstOrDefault(x => x.UrunAd == secilen);

                if (mevcutürün != null)
                {
                    mevcutürün.SepettekiAdet += 1;


                }
                else
                {

                    Ürünler yeniurun = new Ürünler(secilen, urunfiyat, adet);
                    Sepetteki_Ürünler.Add(yeniurun);


                }
                Eklenen_Ürünler.Items.Add($"{secilen}" + " " + "Fiyat :" + " " + $"{urunfiyat}" + " " + $"x{adet}");
                toplam_fiyat = Sepetteki_Ürünler.Sum(u=>u.toplam());




            }
            lbl_toplam_tutar.Text = toplam_fiyat.ToString();
        }
    }
}
