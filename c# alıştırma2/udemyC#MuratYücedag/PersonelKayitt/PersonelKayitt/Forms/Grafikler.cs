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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1623\\MSSQLSERVER1;Initial Catalog=Personel;Integrated Security=True;");

        private void Grafikler_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komut1 = new SqlCommand("select PerSehir, Count(*) from Tbl_Personel Group by Persehir",baglanti);
            SqlDataReader d1 = komut1.ExecuteReader();
            while (d1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(d1[0], d1[1]);
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select PerMeslek, Avg(PerMaas) from Tbl_Personel Group by PerMeslek",baglanti);
            SqlDataReader d2 = komut2.ExecuteReader();
            while (d2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(d2[0], d2[1]);
            }
            baglanti.Close();



        }
    }
}
