using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖğrenciBilgiSitemi.Akademisyen
{
    public partial class Dersİşlemleri : Form
    {
        public Dersİşlemleri()
        {
            InitializeComponent();
        }
        public void Temizle()
        {
            txt_DersAd.Clear();
            txt_Id.Clear();


        }
        public void MesajGöster(string deger)
        {
            MessageBox.Show(deger);



        }

        DataSet1TableAdapters.TBL_DERSLERTableAdapter ds = new DataSet1TableAdapters.TBL_DERSLERTableAdapter();
        private void Dersİşlemleri_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ds.GetDerslerTablosu();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.DersEkle(txt_DersAd.Text);
            Temizle();
            MesajGöster("Ders Eklendi");
        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.GetDerslerTablosu();
        }


        private void btn_sil_Click(object sender, EventArgs e)
        {
            ds.DersSil(byte.Parse(txt_Id.Text));
            Temizle();
            MesajGöster("Ders Silindi");
        }

        private void btn_güncelle_Click_1(object sender, EventArgs e)
        {
            ds.DersGüncelle(txt_DersAd.Text, byte.Parse(txt_Id.Text));
            Temizle();
            MesajGöster("Ders Güncellendi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_DersAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
