using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace _22_InternettenHaberBasligiCekme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlTextReader = new XmlTextReader("https://www.hurriyet.com.tr/rss/anasayfa");
            while (xmlTextReader.Read())
            {
                if (xmlTextReader.Name=="title")
                {
                   listBox1.Items.Add(xmlTextReader.ReadString());
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlTextReader1 = new XmlTextReader("https://www.milliyet.com.tr/rss/rssNew/gundemRss.xml");
            while (xmlTextReader1.Read())
            {
                if (xmlTextReader1.Name == "title")
                {
                    listBox1.Items.Add(xmlTextReader1.ReadString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            XmlTextReader xmlTextReader2 = new XmlTextReader("https://www.fotomac.com.tr/rss/anasayfa.xml");
            while (xmlTextReader2.Read())
            {
                if (xmlTextReader2.Name == "title")
                {
                    listBox1.Items.Add(xmlTextReader2.ReadString());
                }
            }
        }
    }
}
