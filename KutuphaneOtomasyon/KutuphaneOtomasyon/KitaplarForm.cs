using KutuphaneOtomasyon.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyon
{
    public partial class KitaplarForm : Form
    {
        public KitaplarForm()
        {
            InitializeComponent();
        }

        private void KitaplarForm_Load(object sender, EventArgs e)
        {

            KutuphaneDbContext db = new KutuphaneDbContext();
            var kitaplar = db.Kitaplars.ToList();
            dataGridView1.DataSource = kitaplar;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
