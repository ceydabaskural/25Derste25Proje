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

namespace _18_PetrolStokTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=PetrolStokTakipSistemi;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void Listeleme()
        {
            //Kurşunsuz 95
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from TblBenzin where PetrolTur='Kurşunsuz95'", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lbl1.Text = reader[3].ToString();
                progressBar1.Value = int.Parse(reader[4].ToString());
                lbl95.Text = reader[5].ToString();
            }
            connection.Close();


            //Kurşunsuz 97
            connection.Open();
            SqlCommand cmd1 = new SqlCommand("select * from TblBenzin where PetrolTur='Kurşunsuz97'", connection);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                lbl2.Text = reader1[3].ToString();
                progressBar2.Value = int.Parse(reader1[4].ToString());
                lbl97.Text = reader1[5].ToString();
            }
            connection.Close();


            //EuroDizel10
            connection.Open();
            SqlCommand cmd2 = new SqlCommand("select * from TblBenzin where PetrolTur='EuroDizel10'", connection);
            SqlDataReader reader2 = cmd2.ExecuteReader();
            while (reader2.Read())
            {
                lbl3.Text = reader2[3].ToString();
                progressBar3.Value = int.Parse(reader2[4].ToString());
                lblEuro.Text = reader2[5].ToString();
            }
            connection.Close();


            //YeniProDizel
            connection.Open();
            SqlCommand cmd3 = new SqlCommand("select * from TblBenzin where PetrolTur='YeniProDizel'", connection);
            SqlDataReader reader3 = cmd3.ExecuteReader();
            while (reader3.Read())
            {
                lbl4.Text = reader3[3].ToString();
                progressBar4.Value = int.Parse(reader3[4].ToString());
                lblYeniPro.Text = reader3[5].ToString();
            }
            connection.Close();


            //Gaz
            connection.Open();
            SqlCommand cmd4 = new SqlCommand("select * from TblBenzin where PetrolTur='Gaz'", connection);
            SqlDataReader reader4 = cmd4.ExecuteReader();
            while (reader4.Read())
            {
                lbl5.Text = reader4[3].ToString();
                progressBar5.Value = int.Parse(reader4[4].ToString());
                lblGaz.Text = reader4[5].ToString();
            }
            connection.Close();

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Listeleme();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(lbl95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar=kursunsuz95*litre;
            txt95.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97, litre, tutar;
            kursunsuz97 = Convert.ToDouble(lbl97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            txt97.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel, litre, tutar;
            eurodizel = Convert.ToDouble(lblEuro.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = eurodizel * litre;
            txtEuro.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double prodizel, litre, tutar;
            prodizel = Convert.ToDouble(lblYeniPro.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = prodizel * litre;
            txtYeni.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(lblGaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            txtGaz.Text = tutar.ToString();
        }

        private void btnDepo_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value != 0)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("insert into TblHareker (Plaka,BenzinTuru,Litre,Fiyat) values (@p1,@p2,@p3,@p4)", connection);
                cmd.Parameters.AddWithValue("@p1", txtPlaka.Text);
                cmd.Parameters.AddWithValue("@p2", "Kurşunsuz 95");
                cmd.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@p4", decimal.Parse(lbl1.Text));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Satış Yapıldı");


                connection.Open();
                SqlCommand cmd2 = new SqlCommand("update TblKasa set Miktar=Miktar+@p1", connection);
                cmd2.Parameters.AddWithValue("@p1", decimal.Parse(txt.Text);
                cmd2.Parameters.AddWithValue("@p2", "Kurşunsuz 95");
                cmd.Parameters.AddWithValue("@p3", numericUpDown1.Value);
                cmd.Parameters.AddWithValue("@p4", decimal.Parse(lbl1.Text));
                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Satış Yapıldı");

            }
        }
    }
}
