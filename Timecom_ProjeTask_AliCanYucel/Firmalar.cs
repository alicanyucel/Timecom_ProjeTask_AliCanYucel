using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Timecom_ProjeTask_AliCanYucel
{
    public partial class Firmalar : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        public Firmalar()
        {
            InitializeComponent();
        }
        public void verileriGetir()
        {
            veritabaniBaglan();
            DataTable dt = new DataTable();
          SqlDataAdapter  adaptor = new SqlDataAdapter("SELECT * FROM Firmalar", con);
            adaptor.Fill(dt);
            dtgFirmalar.DataSource = dt;
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

        private void Firmalar_Load(object sender, EventArgs e)
        {
            verileriGetir();
        }

       public void griddoldur()
        {
           con = new SqlConnection("server=DESKTOP-ROTCU0Q; Initial Catalog=Timecom;Integrated Security=True");
           da = new SqlDataAdapter("Select * From Firmalar", con);
           ds = new DataSet();
           con.Open();
           da.Fill(ds, "firmalar");
           dtgFirmalar.DataSource = ds.Tables["firmalar"];
           con.Close();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            try
            {
                string firmaadisoyadi,firmakodu;
                firmakodu= txtFirmaKodu.Text;
                firmaadisoyadi = txtFirmaAdiSoyadi.Text;
                if (firmakodu =="")
                {
                    MessageBox.Show("firma kodu ve firma adi alanını doldurmalisiniz");

                }
                else if(firmaadisoyadi=="")
                {
                    MessageBox.Show("firma kodu ve firma adi alanını doldurmalisiniz");
                }
                else
                {
                    string sql = "INSERT INTO Firmalar(FirmaKodu,FirmaAdi)" +
                         " VALUES('" + firmakodu + "','" + firmaadisoyadi + "')";
                    // MessageBox.Show(sql); 
                    SQLCalistir(sql, "Ekleme");
                    verileriGetir();
                    griddoldur();
                }
                   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void txtCadde_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult sonuc;
            sonuc = MessageBox.Show("Çıkmak İstediğinizden Emin misiniz ?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (sonuc == DialogResult.No)
            {
                
            }
            if (sonuc == DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
        }

        private void cbxAdresNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {

        }

        private void chckbxFirmalar_CheckedChanged(object sender, EventArgs e)
        {
            Personeller prsn = new Personeller();
            prsn.Show();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            verileriGetir();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dtgFirmalar.SelectedCells.Count > 0)
            {
                int secilenIndeks = dtgFirmalar.SelectedCells[0].RowIndex;
                DataGridViewRow secilenSatir = dtgFirmalar.Rows[secilenIndeks];
                string silinecek = Convert.ToString(secilenSatir.Cells["FirmaId"].Value);
                
                string sql = "DELETE FROM Firmalar WHERE FirmaId=" + silinecek;
                SQLCalistir(sql, "Silme");
                
                verileriGetir();
            }
    }

        private void button33_Click_1(object sender, EventArgs e)
        {
            txtFirmaKodu.Text = "";
            txtFirmaAdiSoyadi.Text = "";
           
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string id = txtFirmaId.Text;
            string firmaisim,firmakodu;
            firmaisim = txtFirmaAdiSoyadi.Text;
            firmakodu = txtFirmaKodu.Text;
            if (firmakodu != "")
            {
                string sql = "UPDATE Firmalar set " +
                 "FirmaAdi='" + firmaisim+ "', FirmaKodu='" +firmakodu + "' WHERE FirmaId=" + id;
                SQLCalistir(sql, "Düzeltme");
                verileriGetir();
            }
            else
            {
                MessageBox.Show("Lütfen düzeltilecek kaydı seçiniz");

            }
        }

        private void dtgFirmalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtgFirmalar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int secilenIndeks = dtgFirmalar.SelectedCells[0].RowIndex;
            DataGridViewRow secilenSatir = dtgFirmalar.Rows[secilenIndeks];
            txtFirmaKodu.Text = Convert.ToString(secilenSatir.Cells["FirmaKodu"].Value);
            txtFirmaAdiSoyadi.Text = Convert.ToString(secilenSatir.Cells["FirmaAdi"].Value);
            

        }
    }
    }
