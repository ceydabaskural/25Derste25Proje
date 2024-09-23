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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=DbBankaTest;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form3 frm= new Form3();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd= new SqlCommand("select * from TblKisiler where HesapNo=@p1 and Sifre=@p2",connection);
            cmd.Parameters.AddWithValue("@p1", mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read()) //yani hesapno=@p1 e ve şifre=@p2 ye eşitse dedik
            {
                Form2 fr= new Form2();
                fr.hesap=mskHesapNo.Text
                fr.Show();
            }
            else
            {
                MessageBox.Show("Hatalı hesap no ya da şifre ! ", "Uyarı",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
