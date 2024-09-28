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

namespace _21_PastaneUrunMaliyetlendirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=PastaneUrunMaliyetlendirme;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        void MalzemeListe()
        {
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Malzemeler", connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        void UrunListesi()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("select * from Urunler", connection);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        void Kasa()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Kasa", connection);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        void Urunler()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Urunler",connection);
            DataTable table = new DataTable();
            da.Fill(table);
            cmbUrun.ValueMember = "UrunId";
            cmbUrun.DisplayMember = "Ad";
            cmbUrun.DataSource = table;
            connection.Close();
        }

        void Malzemeler()
        {
            connection.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from Malzemeler", connection);
            DataTable table = new DataTable();
            da.Fill(table);
            cmbMalzeme.ValueMember = "MalzemeId";
            cmbMalzeme.DisplayMember = "Ad";
            cmbMalzeme.DataSource = table;
            connection.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            MalzemeListe();

            Urunler();

            Malzemeler();
        }

        private void btnUrun_Click(object sender, EventArgs e)
        {
            UrunListesi();
        }

        private void btnMalzeme_Click(object sender, EventArgs e)
        {
            MalzemeListe();
        }

        private void btnKasa_Click(object sender, EventArgs e)
        {
            Kasa();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMalzemeEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into Malzemeler (Ad,Stok,Fiyat,Notlar) values (@p1,@p2,@p3,@p4)", connection);
            cmd.Parameters.AddWithValue("@p1", txtMad.Text);
            cmd.Parameters.AddWithValue("@p2", decimal.Parse(txtMstok.Text));
            cmd.Parameters.AddWithValue("@p3", decimal.Parse(txtMfiyat.Text));
            cmd.Parameters.AddWithValue("@p4", txtMnot.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Malzeme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            connection.Close();
            MalzemeListe();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Urunler (Ad) values (@p1)", connection);
            command.Parameters.AddWithValue("@p1", txtMad.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            connection.Close();
            UrunListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into Firin (UrunId,MalzemeId,Miktar,Maliyet) values (@p1,@p2,@p3,@p4)",connection);
            command.Parameters.AddWithValue("@p1", cmbUrun.SelectedValue);
            command.Parameters.AddWithValue("@p2", cmbMalzeme.SelectedValue);
            command.Parameters.AddWithValue("@p3", decimal.Parse(txtMiktar.Text));
            command.Parameters.AddWithValue("@p4", decimal.Parse(txtMaliyet.Text));
            command.ExecuteNonQuery();
            MessageBox.Show("Malzeme eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            connection.Close();

            listBox1.Items.Add(cmbMalzeme.Text + " - " + txtMaliyet.Text);
        }

        private void txtMiktar_TextChanged(object sender, EventArgs e)
        {
            double maliyet;

            if (txtMiktar.Text=="")
            {
                txtMiktar.Text = "0";
            }

            connection.Open();
            SqlCommand command = new SqlCommand("select * from Malzemeler where MalzemeId=@p1", connection);
            command.Parameters.AddWithValue("@p1", cmbMalzeme.SelectedValue);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                txtMaliyet.Text = reader[3].ToString();
            }
            connection.Close();

            maliyet = Convert.ToDouble(txtMaliyet.Text) / 1000 * Convert.ToDouble(txtMiktar.Text);

            txtMaliyet.Text = maliyet.ToString();
        }
    }
}
