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
    public partial class FrmRapor : Form
    {
        public FrmRapor()
        {
            InitializeComponent();
        }

        private void FrmRapor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'entity_UrunDataSet.TBL_URUN' table. You can move, or remove it, as needed.
            this.tBL_URUNTableAdapter.Fill(this.entity_UrunDataSet.TBL_URUN);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
