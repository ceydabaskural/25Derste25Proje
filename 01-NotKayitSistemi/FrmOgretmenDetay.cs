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

namespace _01_NotKayitSistemi
{
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=DbNotKayit;Integrated Security=True;TrustServerCertificate=True");
        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.TblDers' table. You can move, or remove it, as needed.
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);


            //Geçti Kaldı Sayısı Hesaplama:
            connection.Open();
            SqlCommand komut = new SqlCommand("Select Count(Durum) From TblDers where Durum='True' Group By Durum", connection);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblGecen.Text = dr[0].ToString();
            }
            dr.Close();

            SqlCommand komut2 = new SqlCommand("Select Count(Durum) From TblDers where Durum='False' Group By Durum", connection);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblKalan.Text = dr2[0].ToString();
            }

            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblDers (OgrenciNumara,OgrenciAd,OgrenciSoyad) values (@p1,@p2,@p3)", connection);
            cmd.Parameters.AddWithValue("@p1", mskNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtAd.Text);
            cmd.Parameters.AddWithValue("@p3", txtSoyad.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Sisteme Eklendi");
            //Aşağıdaki kod otomatik doldurma komutu
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double ortalama, s1, s2, s3;
            string durum;
            s1 = Convert.ToDouble(txtS1.Text);
            s2 = Convert.ToDouble(txtS2.Text);
            s3 = Convert.ToDouble(txtS3.Text);

            ortalama = (s1 + s2 + s3) / 3;
            lblOrt.Text = ortalama.ToString();

            if (ortalama >= 50)
            {
                durum = "True";
            }
            else
            {
                durum = "False";
            }

            connection.Open();
            SqlCommand cmd = new SqlCommand("update TblDers set OgrS1=@p1,OgrS2=@p2,OgrS3=@p3,Ortalama=@p4,Durum=@p5 where OgrenciNumara=@p6", connection);
            cmd.Parameters.AddWithValue("@p1", txtS1.Text);
            cmd.Parameters.AddWithValue("@p2", txtS2.Text);
            cmd.Parameters.AddWithValue("@p3", txtS3.Text);
            cmd.Parameters.AddWithValue("@p4", decimal.Parse(lblOrt.Text));
            cmd.Parameters.AddWithValue("@p5", durum);
            cmd.Parameters.AddWithValue("@p6", mskNo.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Öğrenci Notları Güncellendi");
            //Aşağıdaki kod otomatik doldurma komutu
            this.tblDersTableAdapter.Fill(this.dbNotKayitDataSet.TblDers);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            mskNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            txtS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            lblOrt.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();

        }
    }
}

