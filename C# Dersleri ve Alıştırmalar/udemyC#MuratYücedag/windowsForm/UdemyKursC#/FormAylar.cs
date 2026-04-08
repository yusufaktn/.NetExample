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
    public partial class FormAylar : Form
    {
        public FormAylar()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {

            int ay = Convert.ToInt16(textBox1.Text);

            if (ay > 12 || ay<1)
            {
                MessageBox.Show("Hatalı Giriş!!");
                textBox1.Clear();

            }


            switch (ay)
            {

                case 1:
                    label2.Text = "Ocak";
                    textBox1.Clear();
                    break;
                case 2:
                    label2.Text = "Şubat";
                    textBox1.Clear();
                    break;
                case 3:
                    label2.Text = "Mart";
                    textBox1.Clear();
                    break;
                case 4:
                    label2.Text = "Nisan";
                    textBox1.Clear();
                    break;
                case 5:
                    label2.Text = "Mayıs";
                    textBox1.Clear();
                    break;
                case 6:
                    label2.Text = "Haziran";
                    textBox1.Clear();
                    break;
                case 7:
                    label2.Text = "Temmuz";
                    textBox1.Clear();
                    break;
                case 8:
                    label2.Text = "Ağustos"; textBox1.Clear();

                    break;
                case 9:
                    label2.Text = "Eylül"; textBox1.Clear();
                    break;
                case 10:
                    label2.Text = "Ekim"; textBox1.Clear();
                    break;
                case 11:
                    label2.Text = "Kasım"; textBox1.Clear();
                    break;
                case 12:
                    label2.Text = "Aralık"; textBox1.Clear();
                    break;




            }




        }
    }
}
