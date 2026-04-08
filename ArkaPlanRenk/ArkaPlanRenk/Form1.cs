using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArkaPlanRenk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /*Eğer aşağıdaki gibi kırımızı butana tıklantığında arka plan rengini kırmızı yap dersek ilerde butonu değiştirdiğimizde mesela
          butonu mor yapmak istediğimizde arka plam rengini kırmızı yap dediğimiz için yine kırmızı yapacaktır.
          Fakat diğer butonlardaki gibi biz hangi rengi atarsak o butona arka plan rengini de o renk yapacaktır.*/
          
          
          
         
        private void btnKirmizi_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void btnMavi_Click(object sender, EventArgs e)
        {
            this.BackColor= btnMavi.BackColor;
        }

        private void btnYesil_Click(object sender, EventArgs e)
        {
            this.BackColor = btnYesil.BackColor;
        }

        private void btnSari_Click(object sender, EventArgs e)
        {
            this.BackColor = btnSari.BackColor;
        }
    }
}
