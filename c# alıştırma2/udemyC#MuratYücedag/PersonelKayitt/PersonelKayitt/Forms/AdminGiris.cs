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

namespace PersonelKayitt.Forms
{
    public partial class AdminGiris : Form
    {
        public AdminGiris()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1623\\MSSQLSERVER1;Initial Catalog=Personel;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Yönetici Where KullaniciAd=@a1 and KullaniciParola=@a2",baglanti);
            komut.Parameters.AddWithValue("@a1",txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@a2", txtKullaniciParola.Text);
            SqlDataReader dt = komut.ExecuteReader();

            //Eğer komuttan gelen sonuçta bir karşılık varsa if içindekileri yap. 
            if (dt.Read())
            {
                AnaFrom frm = new AnaFrom();
                frm.Show();
                this.Hide();

            }
            else
            {
                txtKullaniciAdi.Clear();
                txtKullaniciParola.Clear();
                MessageBox.Show("Hatalı Giriş");
            }

            baglanti.Close();



        }
    }
}
