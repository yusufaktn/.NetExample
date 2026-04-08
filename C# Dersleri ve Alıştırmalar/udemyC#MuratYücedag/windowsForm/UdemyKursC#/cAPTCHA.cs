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
    public partial class cAPTCHA : Form
    {
        public cAPTCHA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            string[] sembol1 = { "M","Y","A"};
            string[] sembol2 = { "%", "$", "#" };

            int s1 = rnd.Next(0,sembol1.Length);
            int s2 = rnd.Next(0,sembol2.Length);
            label1.Text = sembol1[s1] + sembol2[s2];

        }
    }
}
