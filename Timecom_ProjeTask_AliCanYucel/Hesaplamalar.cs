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


        private void SQLCalistir(string sql, string islem)
        {

            veritabaniBaglan();

            komut = new SqlCommand(sql, baglanti);
            try
            {
                komut.ExecuteNonQuery();
                MessageBox.Show(islem + " işlemi başarıyla gerçekleşti");
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Personeller personeller = new Personeller();
            personeller.Show();
            this.Hide();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            if (dtgHesaplamalar.SelectedCells.Count > 0)
            {
                int secilenIndeks = dtgHesaplamalar.SelectedCells[0].RowIndex;
                DataGridViewRow secilenSatir = dtgHesaplamalar.Rows[secilenIndeks];
                string silinecekpersonel = Convert.ToString(secilenSatir.Cells["PersonelId"].Value);
                string silinecekMaas = Convert.ToString(secilenSatir.Cells["MaasId"].Value);
                //MessageBox.Show(silinecek);
                string sqlpersonelsil = "DELETE FROM Personeller WHERE PersonelId=" + silinecekpersonel;
                string maassil = "DELETE FROM Maaslar WHERE MaasId=" + silinecekMaas;
                if (sqlpersonelsil != null)
                    SQLCalistir(sqlpersonelsil, "Silme");
                else
                    MessageBox.Show("Silincek Personel Verileri Bulunamadi");
                if(maassil!=null)
                SQLCalistir(maassil, "silme");
                else
                    MessageBox.Show("Maas Tablosunda Silincek Verileriniz Yok");
                verileriGetir();
            }
        } 
        // 
       // maaslar tablosu doldurulacak veriler kullanıcıdan alınacak

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

        private void dtgHesaplamalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
