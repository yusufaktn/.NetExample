using PersonelKayitt.Forms;
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
    public partial class AnaFrom : Form
    {

        public void Temizle()
        {
            PerAd.Clear();
            PerSoyad.Clear();
            PerSehir.Text = "";
            PerMeslek.Clear();
            PerMaas.Clear();
            rd_bekar.Checked = false;
            rd_evli.Checked = false;
        }

        public AnaFrom()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelDataSet.Tbl_Personel);
        }


        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-1623\\MSSQLSERVER1;Initial Catalog=Personel;Integrated Security=True;");
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand($"insert into Tbl_Personel(PerAd,PerSoyad,PerSehir,PerMaas,PerMeslek,PerDurum) values(@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", PerAd.Text);
            komut.Parameters.AddWithValue("@p2", PerSoyad.Text);
            komut.Parameters.AddWithValue("@p3", PerSehir.Text);
            komut.Parameters.AddWithValue("@p4", PerMaas.Text);
            komut.Parameters.AddWithValue("@p5", PerMeslek.Text);
            komut.Parameters.AddWithValue("@p6", durum_bilgi);
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Kayıt Yapıldı");
        }

        int durum_bilgi;
        private void rd_evli_CheckedChanged(object sender, EventArgs e)
        {
            durum_bilgi = 1;
        }

        private void rd_bekar_CheckedChanged(object sender, EventArgs e)
        {
            durum_bilgi = 0;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }


        int PersonelID;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            PersonelID = Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);
            
            PerAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            PerSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            PerSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            PerMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            PerMeslek.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            string bilgi = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            if (bilgi == "True")
            {
                rd_evli.Checked = true;
            }
            if (bilgi == "False")
            {
                rd_bekar.Checked = true;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Delete From Tbl_Personel Where PerId =@ıd",baglanti);
            komut.Parameters.AddWithValue("@ıd",PersonelID);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            


        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Personel Set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerMeslek=@a5,PerDurum=@a6 Where PerId=@ıd",baglanti);
            komut.Parameters.AddWithValue("@ıd",PersonelID);
            komut.Parameters.AddWithValue("@a1",PerAd.Text);
            komut.Parameters.AddWithValue("@a2",PerSoyad.Text);
            komut.Parameters.AddWithValue("@a3", PerSehir.Text);
            komut.Parameters.AddWithValue("@a4", PerMaas.Text);
            komut.Parameters.AddWithValue("@a5", PerMeslek.Text);
            komut.Parameters.AddWithValue("@a6", durum_bilgi);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncellendi");

        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            İstatistik_Form frm = new İstatistik_Form();
            frm.Show();

        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Grafikler frmg = new Grafikler();
            frmg.Show();
        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            Raporlar rpr = new Raporlar();
            rpr.Show();
        }
    }
}
