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
    public partial class ÖğrenciGiriş : Form
    {
        public ÖğrenciGiriş()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            ÖğrenciNotlar ogr_not = new ÖğrenciNotlar();
            ogr_not.numara = txt_ogrencino.Text;
            ogr_not.Show();
            this.Hide();


        }
    }
}
