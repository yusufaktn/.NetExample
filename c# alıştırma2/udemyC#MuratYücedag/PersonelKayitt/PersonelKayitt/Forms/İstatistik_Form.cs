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

namespace PersonelKayitt
{
    public partial class İstatistik_Form : Form
    {
        public İstatistik_Form()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1623\\MSSQLSERVER1;Initial Catalog=Personel;Integrated Security=True;");

     
        //Toplam Personsel Sayısı vb.
        private void İstatistik_Form_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("Select count(*) From Tbl_Personel", baglanti);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lbl_toplamKisi.Text = dr1[0].ToString();

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select count(*) From Tbl_Personel Where PerDurum =1", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lbl_toplam_evli.Text = dr2[0].ToString();

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select count(*) From Tbl_Personel Where PerDurum =0", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lbl_toplam_bekar.Text = dr3[0].ToString();

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select Distinct(PerSehir) From Tbl_Personel ", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            int toplam_sehir = 0;
            while (dr4.Read())
            {
                toplam_sehir++;

            }
            lbl_sehir.Text = toplam_sehir.ToString();
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lbl_toplamMaas.Text = dr5[0].ToString();

            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("Select AVG(PerMaas)From Tbl_Personel", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lbl_ortMaas.Text = dr6[0].ToString();

            }
            baglanti.Close();





        }
    }
}
