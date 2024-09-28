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

namespace _24_SinifUzerindenVeriTabaniİslemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Bu projede elimde olan BOOKSTORE isimli database ine Kitap isimli tablo ekleyerk kullandım. Yeni bir veritabanı oluşturmadım.

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=BookStore;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");

        KitapDb kitapDb = new KitapDb();
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = kitapDb.kitaplar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kitap ktpSinif = new Kitap();
            ktpSinif.Ad = textBox1.Text;
            ktpSinif.Yazar = textBox2.Text;
            kitapDb.KitapEkle(ktpSinif);
            MessageBox.Show("Kitap Eklendi");
        }
    }
}
