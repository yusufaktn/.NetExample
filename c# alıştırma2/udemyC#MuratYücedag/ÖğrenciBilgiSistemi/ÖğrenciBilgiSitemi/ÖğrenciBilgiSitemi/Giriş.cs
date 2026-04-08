using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ÖğrenciBilgiSitemi
{
    public partial class Giriş : Form
    {
        public Giriş()
        {
            InitializeComponent();
        }

        private void picture_ogr_Click(object sender, EventArgs e)
        {
            ÖğrenciGiriş ogr = new ÖğrenciGiriş();
            ogr.Show();
            this.Hide();


        }

        private void picture_akademisyen_Click(object sender, EventArgs e)
        {
            AkademisyenGiriş akgiris =new  AkademisyenGiriş();
           akgiris.Show();
            this.Hide();
        }
    }
}
