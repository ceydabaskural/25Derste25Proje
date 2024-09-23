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

namespace _11_MesajTest
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string numara;

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=IliskiliTablolarileBirlestirme;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void gelenKutusu()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblMesajlar where Alici=" + numara, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void gidenKutusu()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from TblMesajlar where Gonderen=" + numara, connection);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView1.DataSource = dt2;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lblNumara.Text = numara;

            gelenKutusu();

            gidenKutusu();

            //Ad Soyad Çekme
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Ad,Soyad TblKisiler where Numara=" + numara, connection);
            SqlDataReader dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + "" + dr[1];
            }
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblMesajlar (Gonderen,Alici,Baslik,Icerik) values(@p1,@p2,@p3,@p4)", connection);
            cmd.Parameters.AddWithValue("@p1", numara);
            cmd.Parameters.AddWithValue("@p2", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p3", textBox1.Text);
            cmd.Parameters.AddWithValue("@p4", richTextBox1.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Mesajınız iletildi.");
            gidenKutusu();
        }
    }
}
