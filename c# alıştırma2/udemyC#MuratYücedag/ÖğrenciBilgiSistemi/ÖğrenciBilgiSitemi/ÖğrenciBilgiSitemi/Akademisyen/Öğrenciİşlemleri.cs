using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖğrenciBilgiSitemi.Akademisyen
{
    public partial class Öğrenciİşlemleri : Form
    {
        public Öğrenciİşlemleri()
        {
            InitializeComponent();
        }

        




        DataSet1TableAdapters.TBL_OGRableAdapter dt = new DataSet1TableAdapters.TBL_OGRableAdapter();
        private void Öğrenciİşlemleri_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dt.GetÖğrenci_Tabosu();  



        }

        private void btn_Listele_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dt.GetÖğrenci_Tabosu();

        }

        string cinsiyet;
        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            if (rd_btn_erkek.Checked)
            {
               cinsiyet = "Erkek";


            }
            else if (rd_btn_kadın.Checked)
            {

                cinsiyet = "Kadın";

            }



            dt.ÖğrenciGüncelle(txt_öğrencAd.Text,txt_öğrenciSoyad.Text,cinsiyet,byte.Parse(txt_Id.Text));
            MessageBox.Show("Öğrenci Güncellendi");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {

            if (rd_btn_erkek.Checked)
            {
                cinsiyet = "Erkek";


            }
            else if (rd_btn_kadın.Checked)
            {

                cinsiyet = "Kadın";

            }

            dt.ÖğrenciEkle(txt_öğrencAd.Text,txt_öğrenciSoyad.Text,cinsiyet);
            MessageBox.Show("Öğrenci Eklendi");
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dt.ÖğrenciSil(byte.Parse(txt_Id.Text));
            MessageBox.Show("Öğrenci Silindi");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_öğrencAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_öğrenciSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string durum = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();


            if (durum == "Erkek")
            {
                rd_btn_erkek.Checked = true;


            }
            if(durum=="Kız"){ 
            
            rd_btn_kadın.Checked = true;
            }

        }
    }
}
