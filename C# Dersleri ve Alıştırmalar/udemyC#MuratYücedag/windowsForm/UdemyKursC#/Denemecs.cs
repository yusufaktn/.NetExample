using System;
using System.Drawing;
using System.Windows.Forms;

namespace UdemyKursC_
{
    public partial class Denemecs : Form
    {
        private Random random; // Random nesnesi için sınıf seviyesinde bir değişken
        private int rastgeleSayi;

        public Denemecs()
        {
            InitializeComponent();
            random = new Random(); // Random nesnesi oluşturuluyor
        }

        private void YeniRast()
        {
            rastgeleSayi = random.Next(20, 50); // 20 ile 49 arasında rastgele sayı
        }

        private void Denemecs_Load(object sender, EventArgs e)
        {
            YeniRast(); // Form yüklendiğinde rastgele sayıyı oluştur
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;

            // Kullanıcının girdiği değeri kontrol et
            if (!int.TryParse(textBox1.Text, out sayi))
            {
                label2.Visible = true;
                label2.Text = "Lütfen geçerli bir sayı girin!";
                textBox1.Clear();
                textBox1.Focus();
                return;
            }

            if (sayi < rastgeleSayi)
            {
                label2.Visible = true;
                label2.Text = "Daha büyük bir sayı girin";
                textBox1.Clear();
                textBox1.Focus();
            }
            else if (sayi > rastgeleSayi)
            {
                label2.Visible = true;
                label2.Text = "Daha küçük bir sayı girin";
                textBox1.Clear();
                textBox1.Focus();
            }
            else
            {
                label2.Visible = true;
                label2.BackColor = Color.Green;
                label2.Text = "Doğru Cevap!\n Sayı: " + rastgeleSayi;

                // Doğru tahminden sonra yeni rastgele sayı üret
                YeniRast();
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}
