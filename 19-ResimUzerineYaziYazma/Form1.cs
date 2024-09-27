using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_ResimUzerineYaziYazma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resim;
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
        }


        Color renk;
        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            renk = colorDialog1.Color;
        }

        Bitmap bmp;
        private void button3_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(resim);
            Graphics gr = Graphics.FromImage(bmp);
            gr.DrawString(textBox1.Text, new Font("Segoe UI", Convert.ToInt16(textBox2.Text), FontStyle.Bold), new SolidBrush(renk), 20, 30);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            bmp.Save(saveFileDialog1.FileName);
        }
    }
}
