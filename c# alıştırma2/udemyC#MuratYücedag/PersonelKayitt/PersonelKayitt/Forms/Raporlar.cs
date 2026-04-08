using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelKayitt.Forms
{
    public partial class Raporlar : Form
    {
        public Raporlar()
        {
            InitializeComponent();
        }

        private void Raporlar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelDataSet.Tbl_Personel);

            this.reportViewer1.RefreshReport();
        }
    }
}
