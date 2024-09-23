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

namespace _13_SifreliVerileriCözme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=IliskiliTablolarileBirlestirme;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblVeriler",connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //Veri Şifreleme


            string ad = txtAd.Text;
            byte[] adDizisi=ASCIIEncoding.ASCII.GetBytes(ad);
            //ToBase64 şifreleme yöntemlerinden biridir.
            string adSifre=Convert.ToBase64String(adDizisi);


            string soyad = txtSoyad.Text;
            byte[] soyadDizisi = ASCIIEncoding.ASCII.GetBytes(soyad);
            string soyadSifre = Convert.ToBase64String(soyadDizisi);


            string mail = txtMail.Text;
            byte[] mailDizisi = ASCIIEncoding.ASCII.GetBytes(mail);
            string mailSifre = Convert.ToBase64String(mailDizisi);


            string sifre = txtSifre.Text;
            byte[] sifreDizisi = ASCIIEncoding.ASCII.GetBytes(sifre);
            string sifreSifre = Convert.ToBase64String(sifreDizisi);


            string hesapNo = txtHesap.Text;
            byte[] hesapDizisi = ASCIIEncoding.ASCII.GetBytes(hesapNo);
            string hesapSifre = Convert.ToBase64String(hesapDizisi);

            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblVeriler (Ad,Soyad,Mail,Sifre,HesapNo) values (@p1,@p2,@p3,@p4,@p5)", connection);
            cmd.Parameters.AddWithValue("@p1", adSifre);
            cmd.Parameters.AddWithValue("@p2", soyadSifre);
            cmd.Parameters.AddWithValue("@p3", mailSifre);
            cmd.Parameters.AddWithValue("@p4", sifreSifre);
            cmd.Parameters.AddWithValue("@p5", hesapSifre);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Veriler Eklendi");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string adCozum=txtAd.Text;
            byte[] adCozumDizi = Convert.FromBase64String(adCozum);
            string adverisi = ASCIIEncoding.ASCII.GetString(adCozumDizi);
        }
    }
}
