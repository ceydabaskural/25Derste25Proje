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

namespace _10_IliskiliTablolarileBirlestirme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=IliskiliTablolarileBirlestirme;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select UrunAd,(Ad+ ' '+Soyad)as 'Müşteri',AdSoyad,TblHareket.Fiyat from TblHareket\r\ninner join TblUrunler on Urun=UrunId\r\ninner join TblMusteri on Id=Musteri\r\ninner join TblPersonel on TblPersonel.Id=TblHareket.Personel", connection);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
