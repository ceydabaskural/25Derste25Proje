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

namespace _14_BankaSimulasyonu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblKisiler (Ad,Soyad,Tc,Telefon,HesapNo,Sifre) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskTc.Text);
            cmd.Parameters.AddWithValue("@p4", mskTelefon.Text);
            cmd.Parameters.AddWithValue("@p5", mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p6", txtSifre.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int sayi=random.Next(100000,1000000);
            mskHesapNo.Text=sayi.ToString();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
