namespace UdemyKursC_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text + " " + textBox2.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "Muhammet Yusuf Aktan";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = "Bilgisayar Programcýlýðý";
        }

        private void label3_Click(object sender, EventArgs e)
        {
            label3.Text = "2.Sýnýf";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Bursa/Ýznik";
            label2.Text = "Kütahya";
            label3.Text = "Eskiþehir";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox5.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox6.Text);
        }
    }
}
