using KutuphaneOtomasyon.DataAccess;
using Microsoft.EntityFrameworkCore;
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
    public partial class KullanicilarForm : Form
    {
        public KullanicilarForm()
        {
            InitializeComponent();
        }

        private void Kullanicilar_Load(object sender, EventArgs e)
        {
            KutuphaneDbContext db = new KutuphaneDbContext();
            var kullanicilar = db.Kullanicilars.ToList();
            kullanicilar_data.DataSource = kullanicilar;

        }
    }
}
