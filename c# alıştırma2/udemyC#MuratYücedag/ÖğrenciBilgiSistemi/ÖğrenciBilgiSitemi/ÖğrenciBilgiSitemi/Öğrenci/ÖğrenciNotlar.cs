using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ÖğrenciBilgiSitemi
{
    public partial class ÖğrenciNotlar : Form
    {
        public ÖğrenciNotlar()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-1623\\MSSQLSERVER1;Initial Catalog=BonusOkul;Integrated Security=True;");
        public string numara;
        private void ÖğrenciNotlar_Load(object sender, EventArgs e)
        {

            
            con.Open();
            SqlCommand komut = new SqlCommand("Select n.VIZE_NOT,n.FINAL,o.OGRAD+' '+o.OGRSOYAD as ÖğrenciAdSoyad,d.DERSAD  From TBL_NOTLAR n  join TBL_OGR o on\r\nn.OGRID=o.OGRID join TBL_DERSLER d on d.DERSID=n.DERSID where o.OGRID=@a",con);
            komut.Parameters.AddWithValue("@a",numara);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }
    }
}
