using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timecom_ProjeTask_AliCanYucel
{
    public partial class Hesaplamalar : Form
    {
        string baglantiStr;
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataAdapter adaptor;

        public Hesaplamalar()
        {
            InitializeComponent();
        }
        public void veritabaniBaglan()
        {
            try
            {
                baglantiStr = @"Data Source=DESKTOP-ROTCU0Q;Initial Catalog=Timecom;Trusted_Connection=True;";
                baglanti = new SqlConnection(baglantiStr);
                if (baglanti.State == ConnectionState.Open)
                    baglanti.Close();
                baglanti.Open();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlantı kurulamadı");
            }
        }
        public void verileriGetir()
        {
            // burda 2 tablonun tek bir gridde gozukmesi için personeller ve maaslar tablosunu
            // full outher joın ile birleştirdim
            veritabaniBaglan();
            DataTable dt = new DataTable();
            adaptor = new SqlDataAdapter("SELECT * FROM Personeller FULL OUTER JOIN  Maaslar on(Personeller.PersonelId=Maaslar.MaasId)", baglanti);
            adaptor.Fill(dt);
            dtgHesaplamalar.DataSource = dt;
            baglanti.Close();
        }


        private void btnGeri_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void Hesaplamalar_Load(object sender, EventArgs e)
        {

        }

        private void btnAnaSayfa_Click(object sender, EventArgs e)
        {
            Firmalar firmalar = new Firmalar();
            firmalar.Show();
            this.Hide();
        }

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
            // iki ablonun tek gridde gozukmesi için personller ve maaşalr tablosu full joinle birleştirilecek
            verileriGetir();    

        }
    }
}
