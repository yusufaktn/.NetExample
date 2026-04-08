
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Entity_Siparis
{
    public partial class AnaForm : Form
    {      
        public AnaForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        

        private void btn_kategori_Click(object sender, EventArgs e)
        {
            FrmKategori frm = new FrmKategori();
            frm.Show();
        }

        private void btn_urun_Click(object sender, EventArgs e)
        {
            FrmUrun frmürün = new FrmUrun();
            frmürün.Show();
        }

        private void btn_ist_Click(object sender, EventArgs e)
        {
            Frmİstatistik ist = new Frmİstatistik();
            ist.Show();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {

            
        }

        private void btn_rapor_Click(object sender, EventArgs e)
        {
             FrmRapor frm = new FrmRapor();
             frm.Show();
        }
    }
}
