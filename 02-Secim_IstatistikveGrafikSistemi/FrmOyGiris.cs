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

namespace _02_Secim_IstatistikveGrafikSistemi
{
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-F5CBDSU\\SQLEXPRESS;Initial Catalog=DbSecimProje;Integrated Security=True;TrustServerCertificate=True");
        private void btnOy_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into TblIlce (IlceAd,AParti,BParti,CParti,DParti,EParti) values (@p1,@p2,@p3,@p4,@p5,@p6)", connection);
            cmd.Parameters.AddWithValue("@p1",txtAd.Text);
            cmd.Parameters.AddWithValue("@p2",txtA.Text);
            cmd.Parameters.AddWithValue("@p3",txtB.Text);
            cmd.Parameters.AddWithValue("@p4",txtC.Text);
            cmd.Parameters.AddWithValue("@p5",txtD.Text);
            cmd.Parameters.AddWithValue("@p6",txtE.Text);
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Oy Girişi Gerçekleşti");

        }

        private void btnGrafşk_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }

        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
