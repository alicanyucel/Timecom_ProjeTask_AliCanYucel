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
                ucreti =cbxUcreti.SelectedItem.ToString();
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
             // hesap yaparken inte çevir veri tabanına eklerken de kontrol et!
            cbxUcreti.Items.Add("6500");  // hesap yaparken inte çevir veri tabanına eklerken de kontrol et!
            cbxUcreti.Items.Add("7500");  // hesap yaparken inte çevir veri tabanına eklerken de kontrol et!
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

        private void btnPersonelAra_Click(object sender, EventArgs e)
        {
           
            SqlConnection connections = new SqlConnection("Data Source=DESKTOP-ROTCU0Q;Initial Catalog=Timecom;Integrated Security=True");
            if (connections.State == ConnectionState.Closed)
            {
                connections.Open();
            }
            SqlCommand ara = new SqlCommand("select * from Personeller where adi like'%" + txtPersonelAd.Text + "%'", connections);
            SqlDataAdapter da = new SqlDataAdapter(ara);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dtgPersoneller.DataSource = ds.Tables[0];
            connections.Close();
 
        }

        private void btnPersonelDuzenle_Click(object sender, EventArgs e)
        {
            string id =txtPersonelId.Text;
            string personelkodu, adi, soyadi,tcno,cinsiyeti,isebaslamatarihi,engellilik,calismadurumu,ucretdonemi;
            personelkodu = txtPersonelKodu.Text;
            adi = txtPersonelAd.Text;
            soyadi = txtPersonelSoyad.Text;
            tcno = txtPersonelTcNo.Text;
            cinsiyeti = cbxCinsiyet.SelectedItem.ToString();
            isebaslamatarihi = (string)txtIseBaslamaTarihi.Text;
            engellilik = cbxEngellilikDurumu.SelectedItem.ToString();
            calismadurumu = cbxCalismaSekli.SelectedItem.ToString();
            ucretdonemi = cbxUcreti.SelectedItem.ToString();
                if (id != "")
            {
                string sql = "UPDATE Personeller set " +
                 "PersonelKodu='" + personelkodu + "', Adi='" + adi + "',Soyadi='" + soyadi + "'," +
                "TcNo='" + tcno +"',Cinsiyeti='"+ cinsiyeti + "',IseBaslamaTarihi='" +isebaslamatarihi +"',EngellilikDurumu='" + engellilik + "' ,CalismaSekli='" + calismadurumu+"',Ucreti='" + ucretdonemi + "' WHERE PersonelId=" + id;
                SQLCalistir(sql, "Düzeltme");
                verileriGetir();
            }
            else
            {
                MessageBox.Show("Lütfen düzeltilecek kaydı seçiniz");

            }
        }

        private void dtgPersoneller_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgPersoneller_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilenIndeks = dtgPersoneller.SelectedCells[0].RowIndex;
            DataGridViewRow secilenSatir = dtgPersoneller.Rows[secilenIndeks];
            txtPersonelId.Text = Convert.ToString(secilenSatir.Cells["PersonelId"].Value);
            txtPersonelKodu.Text = Convert.ToString(secilenSatir.Cells["PersonelKodu"].Value);
            txtPersonelAd.Text = Convert.ToString(secilenSatir.Cells["Adi"].Value);
            txtPersonelSoyad.Text = Convert.ToString(secilenSatir.Cells["Soyadi"].Value);
            txtPersonelTcNo.Text = Convert.ToString(secilenSatir.Cells["TcNo"].Value);
            cbxCinsiyet.SelectedItem= Convert.ToString(secilenSatir.Cells["Cinsiyeti"].Value);
            txtIseBaslamaTarihi.Text = Convert.ToString(secilenSatir.Cells["IseBaslamaTarihi"].Value);
            cbxEngellilikDurumu.SelectedItem = Convert.ToString(secilenSatir.Cells["EngellilikDurumu"].Value);
            cbxCalismaSekli.SelectedItem = Convert.ToString(secilenSatir.Cells["CalismaSekli"].Value);
            cbxUcreti.SelectedItem =Convert.ToString(secilenSatir.Cells["Ucreti"].Value);
        }
    }
}