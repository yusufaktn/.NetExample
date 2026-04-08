using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdemyKursC_
{
    public partial class SinemaBiletKayıt : Form
    {
        public SinemaBiletKayıt()
        {
            InitializeComponent();
        }

        int misirfiyat = 50;
        int kolafiyat = 30;
        int sufiyat = 15;
        int biletfiyat = 100;
        int toplam = 0;
        int kasatoplam = 0;


        int misirstock = 4;
        int kolastock = 5;
        int sustock = 3;
        int biletstock = 2;



        private void button1_Click(object sender, EventArgs e)
        {
            int misir = Convert.ToInt16(MisirAdet.Text);
            int kola = Convert.ToInt16(KolaAdet.Text);
            int su = Convert.ToInt16(SuAdet.Text);
            int bilet = Convert.ToInt16(BiletAdet.Text);

            int misirtoplam = misir * misirfiyat;
            int kolatoplam = kola * kolafiyat;
            int sutoplam = su * sufiyat;
            int bilettoplam = bilet * biletfiyat;

            toplam = misirtoplam + bilettoplam + kolatoplam + sutoplam;
            kasatoplam = kasatoplam + toplam;

            label14.Text = toplam.ToString();
            label16.Text = kasatoplam.ToString();


            misirstock = misirstock - misir;
            if (misirstock == 0) 
            {
                MessageBox.Show("Mısır Stoğu Tükendi !!");
            }
            kolastock = kolastock - kola;
            if (kolastock == 0)
            {
                MessageBox.Show("Kola Stoğu Tükendi !!");
            }
            sustock = sustock - su;
            if (sustock == 0)
            {
                MessageBox.Show("Su Stoğu Tükendi !!");
            }
            biletstock = biletstock - bilet;
            if (biletstock == 0)
            {
                MessageBox.Show("Bilet Stoğu Tükendi !!");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MisirAdet.Text = "";
            KolaAdet.Text = "";
            SuAdet.Text = "";
            BiletAdet.Text = "";
            toplam = 0;
            label14.Text=toplam.ToString();
            MisirAdet.Focus();
        }
    }
}
