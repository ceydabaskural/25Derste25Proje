using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_PassaparolaOyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //e harfi klavyeden herhangi bir tuşa atama işlemi yapmak için gerekli olan parametremiz
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruNo)
                {
                    //Cevap 1
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label2.Text=yanlis.ToString();  
                        }
                        break;

                    //Cevap 2
                    case 2:
                        if (textBox1.Text == "bursa")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 3
                    case 3:
                        if (textBox1.Text == "cuma")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 4
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 5
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 6
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                        
                        //Cevap 7
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 8
                    case 8:
                        if (textBox1.Text == "halı")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 9
                    case 9:
                        if (textBox1.Text == "ısparta")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 10
                    case 10:
                        if (textBox1.Text == "izmir")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 11
                    case 11:
                        if (textBox1.Text == "jandarma")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 12
                    case 12:
                        if (textBox1.Text == "kayısı")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 13
                    case 13:
                        if (textBox1.Text == "lale")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 14
                    case 14:
                        if (textBox1.Text == "mayıs")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 15
                    case 15:
                        if (textBox1.Text == "ney")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 16
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 17
                    case 17:
                        if (textBox1.Text == "pırasa")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 18
                    case 18:
                        if (textBox1.Text == "ramazan")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 19
                    case 19:
                        if (textBox1.Text == "snake")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 20
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 21
                    case 21:
                        if (textBox1.Text == "umut")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red; 
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 22
                    case 22:
                        if (textBox1.Text == "van")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 23
                    case 23:
                        if (textBox1.Text == "yıldırım")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    //Cevap 24
                    case 24:
                        if (textBox1.Text == "zeytin")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label4.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Linklabelda 'Başla' yazıyor. Tıkladığımızda Sonraki yazacak;
            linkLabel1.Text = "Sonraki";

            //Her cevapla ya tıkladığımızda soru sayısı 1 artıyor:
            soruNo++;

            //Formun adının yazdığı yere soru sayısını yazdırdık:
            this.Text = soruNo.ToString();

            if (soruNo == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi ?";
                button2.BackColor = Color.Yellow;
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Yeşilliği ile ünlü marmara ilimiz nedir ?";
                button3.BackColor = Color.Yellow;
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü ?";
                button24.BackColor = Color.Yellow;
            }
            if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzu ile ünlü ilimiz ?";
                button6.BackColor = Color.Yellow;
            }
            if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı ?";
                button5.BackColor = Color.Yellow;
            }
            if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali ?";
                button4.BackColor = Color.Yellow;
            }
            if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı ?";
                button12.BackColor = Color.Yellow;
            }
            if (soruNo == 8)
            {
                richTextBox1.Text = "Yere serilen örtü ?";
                button11.BackColor = Color.Yellow;
            }
            if (soruNo == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz ?";
                button10.BackColor = Color.Yellow;
            }
            if (soruNo == 10)
            {
                richTextBox1.Text = "Boyozu ile meşhur ilimiz ?";
                button9.BackColor = Color.Yellow;
            }
            if (soruNo == 11)
            {
                richTextBox1.Text = "Askeri bir topluluk ?";
                button23.BackColor = Color.Yellow;
            }
            if (soruNo == 12)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                button8.BackColor = Color.Yellow;
            }
            if (soruNo == 13)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivali ?";
                button7.BackColor = Color.Yellow;
            }
            if (soruNo == 14)
            {
                richTextBox1.Text = "Yılın 3.ayı ?";
                button19.BackColor = Color.Yellow;
            }
            if (soruNo == 15)
            {
                richTextBox1.Text = "Üflemeli bir müzik aleti ?";
                button15.BackColor = Color.Yellow;
            }
            if (soruNo == 16)
            {
                richTextBox1.Text = "Halk şairi ?";
                button14.BackColor = Color.Yellow;
            }
            if (soruNo == 17)
            {
                richTextBox1.Text = "Bir sebze çeşidi ?";
                button20.BackColor = Color.Yellow;
            }
            if (soruNo == 18)
            {
                richTextBox1.Text = "11 ayın sultanı ?";
                button21.BackColor = Color.Yellow;
            }
            if (soruNo == 19)
            {
                richTextBox1.Text = "İngilizcede yılan ?";
                button16.BackColor = Color.Yellow;
            }
            if (soruNo == 20)
            {
                richTextBox1.Text = "Türkiye'nin megastarı ?";
                button17.BackColor = Color.Yellow;
            }
            if (soruNo == 21)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı ?";
                button18.BackColor = Color.Yellow;
            }
            if (soruNo == 22)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz ?";
                button13.BackColor = Color.Yellow;
            }
            if (soruNo == 23)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamısı ?";
                button1.BackColor = Color.Yellow;
            }
            if (soruNo == 24)
            {
                richTextBox1.Text = "Ege bölgesinde en çok yetişen ağaç ?";
                button22.BackColor = Color.Yellow;
            }


        }
    }
}
