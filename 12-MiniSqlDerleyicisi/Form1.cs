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

namespace _12_MiniSqlDerleyicisi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=DbOgrenciNot;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        private void btnCalistir_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;

            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sorgu, connection);
                DataTable dataTable = new DataTable();
                da.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception)
            {
                MessageBox.Show("Sorgunuzu kontrol edin!","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sorgu=richTextBox1.Text;
            connection.Open();
            SqlCommand cmd= new SqlCommand(sorgu,connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            SqlDataAdapter da= new SqlDataAdapter("select * from TblOgrenciler", connection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource= dataTable;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;
            connection.Open();
            SqlCommand cmd = new SqlCommand(sorgu, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            SqlDataAdapter da = new SqlDataAdapter("select * from TblOgrenciler", connection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string sorgu = richTextBox1.Text;
            connection.Open();
            SqlCommand cmd = new SqlCommand(sorgu, connection);
            cmd.ExecuteNonQuery();
            connection.Close();

            SqlDataAdapter da = new SqlDataAdapter("select * from TblOgrenciler", connection);
            DataTable dataTable = new DataTable();
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}
