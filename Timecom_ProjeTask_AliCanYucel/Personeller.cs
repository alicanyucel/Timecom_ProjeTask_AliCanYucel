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

        private void cbxCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            // combobox int turunden değer dönüyor gelen veriyi int bir değişkende karşılamalıyız
            // net maas hesapları yapılacak
            cbxEngellilikDurumu.Items.Add("normal");
            cbxEngellilikDurumu.Items.Add("1.Derece Engelli");
            cbxEngellilikDurumu.Items.Add("2.Derece Engelli");
            cbxCinsiyet.Items.Add("erkek");
            cbxCinsiyet.Items.Add("kadin");
            cbxCalismaSekli.Items.Add("aylık");
            cbxCalismaSekli.Items.Add("gunluk");
            cbxCalismaSekli.Items.Add("saatlik");
        }
    }
}
