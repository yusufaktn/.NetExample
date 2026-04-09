namespace KutuphaneOtomasyon
{
    public partial class KutuphaneOtomasyon : Form
    {
        public KutuphaneOtomasyon()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KullanicilarForm kullanicilar = new KullanicilarForm();
            kullanicilar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           KitaplarForm kitaplar = new KitaplarForm();
            kitaplar.Show();
        }
    }
}
