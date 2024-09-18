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

namespace _05_FilmArsivim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection=new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=FilmArsivi;Integrated Security=True;TrustServerCertificate=True");

        void filmler()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select Ad,Link from TblFilmler",connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            filmler();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into TblFilmler (Ad,Kategori,Link) values (@p1,@p2,@p3)", connection);
            sqlCommand.Parameters.AddWithValue("@p1", txtAd.Text);
            sqlCommand.Parameters.AddWithValue("@p2", txtKategori.Text);
            sqlCommand.Parameters.AddWithValue("@p3", txtLink.Text);
            sqlCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Film listenize eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            string link = dataGridView1.Rows[secilen].Cells[3].Value.ToString();

            webBrowser1.Navigate(link);
        }

        private void btnHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu proje Ceyda Başkural tarafından 16.09.2024 - 12:16 saatinde uygulandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRenk_Click(object sender, EventArgs e)
        {
            Color[] colors = { Color.AliceBlue, Color.Bisque, Color.DarkBlue, Color.Fuchsia };
            
            Random rnd = new Random();
            int sayi = rnd.Next(0, colors.Length);

            this.BackColor = colors[sayi];
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
