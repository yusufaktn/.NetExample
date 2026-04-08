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
    public partial class ProjectBilgi : Form
    {
        public ProjectBilgi()
        {
            InitializeComponent();
        }


        int soruno = 0;
        int Dogru = 0;
        int Yanlis = 0;

        public void EnableButtonFalse()
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
        }
        public void EnableButtonTrue()
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
        }


        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            soruno++;
            BtnSonraki.Enabled = false;
            
            if (soruno == 1)
            {
                EnableButtonTrue();
                BtnSoruNo.Text = soruno.ToString();
                richTextBox1.Text = "Hangisi Alman araba markasısıdır?";

                BtnA.Text = "Audi";
                BtnB.Text = "Fiat";
                BtnC.Text = "Renult";
                BtnD.Text = "Citroen";
                DogruCevap.Text = "Audi";


            }
            if (soruno == 2)

            {
                EnableButtonTrue();
                BtnSoruNo.Text = soruno.ToString();
                richTextBox1.Text = "Hangisi Ege Bölgesindedir?";

                BtnA.Text = "Bursa";
                BtnB.Text = "İstanbul";
                BtnC.Text = "Anakara";
                BtnD.Text = "Kütahya";
                DogruCevap.Text = "Kütahya";


            }







        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnSonraki.Enabled=true;
           
            
                VerilenCevap.Text = BtnA.Text;
            if (VerilenCevap.Text == DogruCevap.Text)
            {
                Dogru++;
                BtnDogru.Text = Dogru.ToString();
                EnableButtonFalse();
            }


            else
            {
                Yanlis++;
                BtnYanlis.Text = Yanlis.ToString();
                EnableButtonFalse();
            }
                

            

           
            

        }
    }
}
