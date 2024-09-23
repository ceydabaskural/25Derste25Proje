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

namespace _15_OgrenciDersKayitSistemi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=OgrenciDersKayitSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void dersListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblDersler", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            //value member: ilişkili altyapıda seçtiğimiz değerin id alanı
            cmbDers.ValueMember = "DersId"; 
            //display member: value member arkada id yi tutarken display member bize id ye ait olan ismi getirmeyi sağlayacak
            cmbDers.DisplayMember = "DersAd";
            cmbDers.DataSource = dt;
        }
        
        void etutListesi()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Id,DersAd,(TblOgretmen.Ad+' '+TblOgretmen.Soyad) as 'Öğretmen',Tarih,Saat,Durum from TblEtut \r\ninner join TblDersler on TblEtut.DersId=TblDersler.DersId\r\ninner join TblOgretmen on TblEtut.OgretmenId=TblOgretmen.OgretmenId", connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dersListesi();
            etutListesi();
        }

        private void cmbDers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seçilen derse ait öğretmen listeleme
            SqlDataAdapter da = new SqlDataAdapter("select OgretmenId,(Ad+' '+Soyad) as 'Öğretmen' from TblOgretmen where BransId=" + cmbDers.SelectedValue, connection);
            //selected value: seçtiğimiz değerin id sine göre
            DataTable d = new DataTable();
            da.Fill(d);
            cmbOgretmen.ValueMember = "OgretmenId";
            cmbOgretmen.DisplayMember = "Öğretmen";
            cmbOgretmen.DataSource = d;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblEtut (DersId,OgretmenId,Tarih,Saat) values (@p1,@p2,@p3,@p4)", connection);
            cmd.Parameters.AddWithValue("@p1", cmbDers.SelectedValue);
            cmd.Parameters.AddWithValue("@p2", cmbOgretmen.SelectedValue);
            cmd.Parameters.AddWithValue("@p3", mskTarih.Text);
            cmd.Parameters.AddWithValue("@p4", mskSaat.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Etüt Oluşturuldu","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            etutListesi();
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen =dataGridView1.SelectedCells[0].RowIndex;

            txtEtutId.Text = dataGridView1.Rows[secilen].Cells[0].ToString();
        }

        private void btnEtütVer_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update TblEtut set OgrenciId=@p1,Durum=@p2 where Id=@p3", connection);
            cmd.Parameters.AddWithValue("@p1", txtOgrenci.Text);
            cmd.Parameters.AddWithValue("@p2", "True");
            cmd.Parameters.AddWithValue("@p3", txtEtutId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Etüt öğrenciye verildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation=openFileDialog1.FileName;
        }

        private void btnOgrEkle_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into TblOgrenci (Ad,Soyad,Fotograf,Sinif,Telefon,Mail) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            cmd.Parameters.AddWithValue("@p1", textBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox2.Text);
            cmd.Parameters.AddWithValue("@p3", pictureBox1.Text);
            cmd.Parameters.AddWithValue("@p4", textBox3.Text);
            cmd.Parameters.AddWithValue("@p5", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p6", textBox5.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Siteme Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDersEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblDersler (DersAd) values (@p1)", connection);
            cmd.Parameters.AddWithValue("@p1", txtDers.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Yeni ders eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            //Ders ekledikten sonra ders listelesin istedim:
            SqlDataAdapter cmd2 = new SqlDataAdapter("select * from TblDersler", connection);
            DataTable dt= new DataTable();
            cmd2.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
        }

        private void btnOgretmenEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblOgretmen (Ad,Soyad,BransId) values (@p1,@p2,@p3)", connection);
            cmd.Parameters.AddWithValue("@p1", txtOgrtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtOgrtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", cmbDersAd.SelectedValue);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Yeni öğretmen eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void cmbDersAd_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblDersler where DersId=" + cmbDers.SelectedValue, connection);
            DataTable d = new DataTable();
            da.Fill(d);
            cmbOgretmen.ValueMember = "DersId";
            cmbOgretmen.DisplayMember = "DersAd";
            cmbOgretmen.DataSource = d;
        }
    }
}
