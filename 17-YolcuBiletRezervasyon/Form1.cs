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

namespace _17_YolcuBiletRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=BiletRezervasyonveKayit;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            mskTc.Text = "";
            txtMail.Text = "";
            mskTel.Text = "";
            cmbCinsiyet.Text = "";
            txtKaptanNo.Text = "";
            txtAdSoyad.Text = "";
            mskTelefonKaptan.Text = "";
        }

        void seferListesi()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from TblSeferBilgi", connection); 
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblYolcuBilgi (Ad,Soyad,Telefon,Tc,Cinsiyet,Mail) values (@p1,@p2,@p3,@p4,@p5,@p6)",connection);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskTel.Text);
            cmd.Parameters.AddWithValue("@p4", mskTc.Text);
            cmd.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);
            cmd.Parameters.AddWithValue("@p6", txtMail.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Yolcu Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnKaptan_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblKaptan (KaptanNo,AdSoyad,Telefon) values (@p1,@p2,@p3)", connection);
            cmd.Parameters.AddWithValue("@p1", txtKaptanNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtAdSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskTelefonKaptan.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kaptan Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }

        private void btnSefer_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into TblSeferBilgi (Kalkis,Varis,Tarih,saat,kaptan,fiyat) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            sqlCommand.Parameters.AddWithValue("@p1",txtKalkis.Text);
            sqlCommand.Parameters.AddWithValue("@p2",txtVaris.Text);
            sqlCommand.Parameters.AddWithValue("@p3",mskTarih.Text);
            sqlCommand.Parameters.AddWithValue("@p4",mskSaat.Text);
            sqlCommand.Parameters.AddWithValue("@p5",mskKaptan.Text);
            sqlCommand.Parameters.AddWithValue("@p6",txtFiyat.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Sefer Bilgisi Sisteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            temizle();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            seferListesi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtSeferNo.Text = dataGridView1.Rows[secilen].Cells[0].ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtKoltukNo.Text = "9";
        }

        private void btnRezervasyon_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblSeferDetay (SeferNo,YolcuTc,Koltuk) values (@p1,@p2,@p3)", connection);
            cmd.Parameters.AddWithValue("@p1", txtSeferNo.Text);
            cmd.Parameters.AddWithValue("@p2", mskTc.Text);
            cmd.Parameters.AddWithValue("@p3", txtKoltukNo.Text);
            cmd.ExecuteNonQuery();
            connection.Close(); 
            MessageBox.Show("Rezervasyon Oluşturuldu", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
        }
    }
}
