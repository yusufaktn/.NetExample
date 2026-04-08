using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormToplamaÇıkarma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtSayi1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {

            int sayi1, sayi2, toplam;
            sayi1=Convert.ToInt32(txtSayi1.Text);
            sayi2=Convert.ToInt32(txtSayi2.Text);
            toplam = (sayi1+sayi2);

            lblSonuc.Text = toplam.ToString();



        }
    }
}
