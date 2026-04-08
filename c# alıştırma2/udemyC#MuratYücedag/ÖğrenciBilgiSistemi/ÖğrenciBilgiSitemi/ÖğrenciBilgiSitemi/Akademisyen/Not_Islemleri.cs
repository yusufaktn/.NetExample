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

namespace ÖğrenciBilgiSitemi.Akademisyen
{
    public partial class Not_Islemleri : Form
    {
        public Not_Islemleri()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1623\\MSSQLSERVER1;Initial Catalog=BonusOkul;Integrated Security=True;");
        private void Not_Islemleri_Load(object sender, EventArgs e)
        {

            con.Open();

            SqlCommand komut = new SqlCommand("Select *From TBL_DERSLER",con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DisplayMember = "DERSAD";
            comboBox1.ValueMember = "DERSID";
            comboBox1.DataSource= dt;


            con.Close();





        }
        DataSet1TableAdapters.TBL_NOTLARTableAdapter dersler = new DataSet1TableAdapters.TBL_NOTLARTableAdapter();
        private void button1_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dersler.ÖğrenciNotGetir(Convert.ToInt32(txt_ögrenciID.Text));



        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //txt_ögrenciID.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_vizenot.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_final.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            lbl_ortalama.Text= dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            lbl_durum.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();




        }

        private void btn_notekle_Click(object sender, EventArgs e)
        {


           dersler.ÖğrenciNotEkle(int.Parse(txt_ögrenciID.Text),byte.Parse(comboBox1.SelectedValue.ToString()),int.Parse(txt_vizenot.Text), int.Parse(txt_final.Text));
        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            //dersler.ÖğrenciGüncelleNot();
        }

        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            int vize;
            int final;
            double ort;

            vize = int.Parse(txt_vizenot.Text);
            final =int.Parse(txt_final.Text);

            ort = (vize * 40) / 100 + (final * 60) / 100;

            lbl_ortalama.Text = ort.ToString();


        }
    }
}
