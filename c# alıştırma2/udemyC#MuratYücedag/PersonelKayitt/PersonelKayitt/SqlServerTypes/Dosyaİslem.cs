using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonelKayitt.SqlServerTypes
{
    public partial class Dosyaİslem : Form
    {
        public Dosyaİslem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(this);
        }



        string dosyaadi;
        string dosyayolu;
        StreamWriter sw;
        private void button4_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                dosyayolu=folderBrowserDialog1.SelectedPath.ToString();
                textBox1.Text = dosyayolu;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            dosyaadi=textBox2.Text;
            sw = File.CreateText(dosyayolu+"//"+dosyaadi+".txt");
            sw.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            if (openFileDialog1.ShowDialog()==DialogResult.OK) 
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName);
                string satir =sr.ReadLine();
                while (satir!=null)
                {
                    listBox1.Items.Add(satir);  
                    satir = sr.ReadLine();

                }
            }
        }
    }
}
