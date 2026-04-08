using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N_KatmanlıMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_listele_Click(object sender, EventArgs e)
        {

            List<EntityPersonel> personel = LogicPersonel.LL_PersonelListesi();
            dataGridView1.DataSource= personel;



        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.AD= textBox2.Text;
            ent.SOYAD= textBox3.Text;
            ent.SEHIR= textBox4.Text;
            ent.GOREV= textBox5.Text;
            ent.MAAS =int.Parse( textBox6.Text);

            LogicPersonel.LL_PersonelEkle(ent);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.ID= int.Parse(textBox1.Text);


            LogicPersonel.LL_PersonelSil(ent);

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {

            EntityPersonel ent = new EntityPersonel();
            ent.ID= int.Parse(textBox1.Text);
            ent.AD = textBox2.Text;
            ent.SOYAD = textBox3.Text;
            ent.SEHIR = textBox4.Text;
            ent.GOREV = textBox5.Text;
            ent.MAAS = int.Parse(textBox6.Text);
            LogicPersonel.LL_PersonelGüncelle(ent);
        }
    }
}
