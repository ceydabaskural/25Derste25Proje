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

namespace _16_TriggerKullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=IliskiliTablolarileBirlestirme;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");


        void Listele()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from TblKitaplar", connection);
            DataTable dt=new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void sayac()
        {
            //connection.open dememizin sebebi şu bu sefer dataadapter kullanıp datagride yazdırmayacağımız için label a yazdıracağımız için kullandık
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select * from TblSayac", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                lblKitap.Text = reader[0].ToString();
            }
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblKitaplar (Ad,Yazar,Sayfa,Yayinevi,Tur) values (@p1,@p2,@p3,@p4,@p5)", connection);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtYazar.Text);
            cmd.Parameters.AddWithValue("@p3", txtSayfa.Text);
            cmd.Parameters.AddWithValue("@p4", txtYayinevi.Text);
            cmd.Parameters.AddWithValue("@p5", txtTür.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap sisteme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();
            sayac();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSayfa.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtYayinevi.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtTür.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete from TblKitaplar where Id=@p1", connection);
            cmd.Parameters.AddWithValue("@p1", txtId.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Kitap Sistemden Silindi");
            Listele();
            sayac();
        }
    }
}
