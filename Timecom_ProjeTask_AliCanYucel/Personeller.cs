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
    public partial class Personeller : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public Personeller()
        {
            InitializeComponent();
        }
        public void verileriGetir()
        {
            veritabaniBaglan();
            DataTable dt = new DataTable();
            SqlDataAdapter adaptor = new SqlDataAdapter("SELECT * FROM Personeller", con);
            adaptor.Fill(dt);
            dtgPersoneller.DataSource = dt;
            con.Close();
        }
        public void veritabaniBaglan()
        {
            try
            {
                string baglanti = @"Data Source=DESKTOP-ROTCU0Q;Initial Catalog=Timecom;Trusted_Connection=True;";
                con = new SqlConnection(baglanti);
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
            }
            catch
            {
                MessageBox.Show("Veritabanına bağlantı kurulamadı");
            }

        }
        public void SQLCalistir(string sql, string islem)
        {

            veritabaniBaglan();

            cmd = new SqlCommand(sql, con);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(islem + " işlemi başarıyla gerçekleşti");
            }
            catch (SqlException hata)
            {
                MessageBox.Show(hata.Message.ToString());
            }
        }

        public void griddoldur()
        {
            con = new SqlConnection("server=DESKTOP-ROTCU0Q; Initial Catalog=Timecom;Integrated Security=True");
            da = new SqlDataAdapter("Select * From Personeller", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Personeller");
            dtgPersoneller.DataSource = ds.Tables["Personeller"];
            con.Close();
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
            try
            {
                string personelkodu, adi, soyadi, tcno, cinsiyeti, isebaslama, engellilikdurumu, calismasekli, ucreti;
                personelkodu = txtPersonelKodu.Text;
                adi = txtPersonelAd.Text;
                soyadi = txtPersonelSoyad.Text;
                tcno = txtPersonelTcNo.Text;
                cinsiyeti = cbxCinsiyet.SelectedItem.ToString();
                isebaslama = txtIseBaslamaTarihi.Text;
                engellilikdurumu = cbxEngellilikDurumu.SelectedItem.ToString();
                calismasekli = cbxCalismaSekli.SelectedItem.ToString();
                ucreti = cbxUcreti.SelectedItem.ToString();
                string sql = "INSERT INTO Personeller(PersonelKodu,Adi,Soyadi,TcNo,Cinsiyeti,IseBaslamaTarihi,EngellilikDurumu,CalismaSekli,Ucreti)" +
                     " VALUES('" + personelkodu + "','" + adi + "','" + soyadi + "','" + tcno + "','" + cinsiyeti + "','" + isebaslama + "','" + engellilikdurumu + "','" + calismasekli + "','" + ucreti + "')";
                // MessageBox.Show(sql); 
                SQLCalistir(sql, "Ekleme");
                verileriGetir();
                griddoldur();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void cbxCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Personeller_Load(object sender, EventArgs e)
        {
            this.dtgPersoneller.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            // net maas hesapları yapılacak
            cbxEngellilikDurumu.Items.Add("normal");
            cbxEngellilikDurumu.Items.Add("1.Derece Engelli");
            cbxEngellilikDurumu.Items.Add("2.Derece Engelli");
            cbxCinsiyet.Items.Add("e");
            cbxCinsiyet.Items.Add("k");
            cbxCalismaSekli.Items.Add("aylık");
            cbxCalismaSekli.Items.Add("gunluk");
            cbxCalismaSekli.Items.Add("saatlik");
            cbxUcreti.Items.Add("2021"); // 2021 YILI İÇİN 4250 alacam
            cbxUcreti.Items.Add("2022"); // 2022 YILI İÇİN 5500 alacam
            verileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dtgPersoneller.SelectedCells.Count > 0)
            {
                int secilenIndeks = dtgPersoneller.SelectedCells[0].RowIndex;
                DataGridViewRow secilenSatir = dtgPersoneller.Rows[secilenIndeks];
                string silinecek = Convert.ToString(secilenSatir.Cells["PersonelId"].Value);
                string sql = "DELETE FROM Personeller WHERE PersonelId=" + silinecek;
                SQLCalistir(sql, "Silme");
                verileriGetir();
            }
        }
    }
}