using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timecom_ProjeTask_AliCanYucel
{
    public partial class Personeller : Form
    {
        public Personeller()
        {
            InitializeComponent();
        }

        private void btnGeriGel_Click(object sender, EventArgs e)
        {
            Firmalar frm = new Firmalar();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hesaplamalar hesaplamalar = new Hesaplamalar();
            hesaplamalar.Show();
            this.Hide();
        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Firmalar frm = new Firmalar();
            frm.Show();
            this.Hide();

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            // Kayıtlar Eklenecek
        }
    }
}
