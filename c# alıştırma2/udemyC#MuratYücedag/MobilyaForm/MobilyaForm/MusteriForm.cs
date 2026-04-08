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
    public partial class MusteriForm : Form 
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        SqlBaglanti sqlBaglanti = new SqlBaglanti();




        string tc, ad, soyad, borc,adres;
        
        private void button2_Click(object sender, EventArgs e)
        {

            sqlBaglanti.baglanti();
            SqlCommand komut = new SqlCommand("Insert into Tbl_Musteri(MusteriAd,MusteriSoyad,MusteriTc,MusteriAdres) values(@1,@2,@3,@4)",sqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("@1",ekle_txtAd.Text);
            komut.Parameters.AddWithValue("@2",ekle_txtSoyad.Text);
            komut.Parameters.AddWithValue("@3",ekle_txtTc.Text);
            komut.Parameters.AddWithValue("@4",ekle_txtAdres.Text);
            sqlBaglanti.baglanti().Close();
            MusteriEkle musteriEkle = new MusteriEkle();
            musteriEkle.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            
            sqlBaglanti.baglanti();            
            SqlCommand komut = new SqlCommand("Select*From Tbl_Musteri Where MusteriAd=@ad and MusteriSoyad=@soyad and MusteriTc=@tc",sqlBaglanti.baglanti());
            komut.Parameters.AddWithValue("@ad",txt_musteriAD.Text);
            komut.Parameters.AddWithValue("@soyad", txt_musteriSOYAD.Text);
            komut.Parameters.AddWithValue("@tc", txt_musteriTC.Text);
            SqlDataReader d1 =  komut.ExecuteReader();
            if (d1.Read())
            {

                ad = d1[1].ToString();
                soyad = d1[2].ToString();
                tc = d1[3].ToString();
                adres = d1[4].ToString();
                borc = d1[5].ToString();
                MüsteriBilgi musteri_bilgi = new MüsteriBilgi(tc, ad, soyad, borc, adres);
                musteri_bilgi.Show();

                DataTable dt = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter($"select Tbl_Odeme.OdemeTarihi,Tbl_Odeme.Odenen_Miktar from Tbl_Musteri inner join Tbl_Odeme on Tbl_Musteri.MusteriID=Tbl_Odeme.MusteriID where MusteriTc={txt_musteriTC.Text}",sqlBaglanti.baglanti());
                
                
                data.Fill(dt);
                musteri_bilgi.DataGrid1(dt);


            }

            else {
                MessageBox.Show("Kişi Bulunamadı.");
            
            }
            sqlBaglanti.baglanti().Close();
            
        }
    }
        
}
