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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection=new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=IliskiliTablolarileBirlestirme;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from TblKisiler where Numara=@p1 and Sifre=@p2", connection);
            cmd.Parameters.AddWithValue("@p1", maskedTextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", textBox1.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                Form2 frm= new Form2();
                frm.numara = maskedTextBox1.Text;
                frm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Bilgi");
            }
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
