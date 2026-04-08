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
    public partial class Form3DortIslem : Form
    {
        public Form3DortIslem()
        {
            InitializeComponent();
        }
        int sayi1;
        int sayi2;
        int sonuc = 0;

        private void Form3DortIslem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);

            sonuc = sayi1 + sayi2;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            label.Text = sonuc.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);

            sonuc = sayi1 - sayi2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);

            sonuc = sayi1 * sayi2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sayi1 = Convert.ToInt16(textBox1.Text);
            sayi2 = Convert.ToInt16(textBox2.Text);

            sonuc = sayi1 / sayi2;
        }
    }
}
