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
    public partial class İşlemSeç : Form
    {
        public İşlemSeç()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dersİşlemleri dersislem = new Dersİşlemleri();
            dersislem.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Öğrenciİşlemleri ogr_islem = new Öğrenciİşlemleri();
            ogr_islem.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Not_Islemleri notislem = new Not_Islemleri();
            notislem.Show();
            this.Hide();
        }
    }
}
