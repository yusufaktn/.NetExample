using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MobilyaForm
{
    public partial class MüsteriBilgi : Form
    {
        public MüsteriBilgi(string tc, string ad,string soyad,string borc,string adres )
        {
            InitializeComponent();
            lbl_tc.Text = tc;
            lbl_ad.Text = ad;
            lbl_soyad.Text = soyad;
            lbl_borc.Text = borc;
            lbl_adres.Text = adres;
            
        }
       public  void DataGrid1(DataTable data_v)
        {

           dataGridView1.DataSource = data_v;


        }

        private void MüsteriBilgi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mobilyaDbDataSet2.Tbl_Odeme' table. You can move, or remove it, as needed.
            this.tbl_OdemeTableAdapter.Fill(this.mobilyaDbDataSet2.Tbl_Odeme);

        }
    }
}
