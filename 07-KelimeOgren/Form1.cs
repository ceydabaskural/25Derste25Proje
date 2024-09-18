using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_KelimeOgren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\LENOVO\\Desktop\\dbSozluk.accdb");

        Random rast = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            int sayi;
            sayi = rast.Next(1,2490);

             connection.Open();
            OleDbCommand ole = new OleDbCommand("select ingilizce from sozluk where id=@p1", connection);
            ole.Parameters.AddWithValue("@p1", sayi);
            OleDbDataReader dataReader = ole.ExecuteReader();
            while (dataReader.Read())
            {
                textBox1.Text = dataReader[1].ToString();
                lblCevap.Text = dataReader[2].ToString();
            }
            connection.Close();
        }
    }
}
