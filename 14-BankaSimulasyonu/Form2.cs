using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_BankaSimulasyonu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        public string hesap;
        private void Form2_Load(object sender, EventArgs e)
        {
            lblHesap.Text = hesap;


            connection.Open();
            SqlCommand cmd= new SqlCommand("select * from TblKisiler where HesapNo=@p1",connection);
            cmd.Parameters.AddWithValue("@p1", hesap);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[1] + "" + dr[2];//eğer bir satırda tırnak(") kullandıysan tostring deyip stringe dönüştürmeye gerek yok zaten string olmuş oluyor
                lblTc.Text = dr[3].ToString();
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Gönderilen Hesabın Para Artışı
            connection.Open();
            SqlCommand cmd = new SqlCommand("update TblHesap set Bakiye=Bakiye+@p1 where HesapNo=@p2", connection);
            cmd.Parameters.AddWithValue("@p1", decimal.Parse(txtTutar.Text));
            cmd.Parameters.AddWithValue("@p2", hesap);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("İşlem Gerçekleşti");

            //Gönderen Hesabın Para Azalışı
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("update TblHesap set Bakiye=Bakiye-@k1 where HesapNo=@k2", connection);
            cmd2.Parameters.AddWithValue("@k1", decimal.Parse(txtTutar.Text));
            cmd2.Parameters.AddWithValue("@k2", hesap);
            cmd2.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("İşlem Gerçekleşti");


            //Hareket Tablosu

        }
    }
}
