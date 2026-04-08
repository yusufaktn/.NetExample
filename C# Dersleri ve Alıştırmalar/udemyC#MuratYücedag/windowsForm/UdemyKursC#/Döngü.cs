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
    public partial class Döngü : Form
    {
        public Döngü()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int baslangic = Convert.ToInt32(textBox1.Text);
            int bitis = Convert.ToInt32(textBox2.Text);
            int toplam = 0;


            for (int i = baslangic; i <= bitis; i++)
            {

                toplam = toplam + i;

            }

            label5.Text = toplam.ToString();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int baslangic = Convert.ToInt32(textBox4.Text);
            int bitis = Convert.ToInt32(textBox3.Text);

            for (int i = baslangic; i <= bitis; i++)
            {

                if (i % 3 == 0)
                {
                    listBox1.Items.Add(i.ToString());


                }


            }


        }
    }
}
