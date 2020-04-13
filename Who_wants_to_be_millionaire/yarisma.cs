using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Who_wants_to_be_millionaire
{
    public partial class yarisma : Form
    {
        public yarisma()
        {
            InitializeComponent();
            button1.BackColor = Color.Yellow;
        }

        int soruno = 1;
        
      

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (soruno == 1)
            {
                richTextBox1.Text = "3  8  11  19  30  49  ? Dizide soru işaretli yere hangi sayı gelmelidir ?";
                button1.BackColor = Color.Yellow;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "Mustafa 600TL'ye eski bir araba almış,bunu Murat'a 800TL'ye satmış. Sonra 1000TL'ye başka bir araba almış bunu da 1200TL'ye satmış.Mustafanın kârı ne kadardır ?";
                button2.BackColor = Color.Yellow;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "1 Metre kaç milimetredir ?";
                button3.BackColor = Color.Yellow;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "120'yi yarıma bölüp 120 eklediniz sonuç kaçtır ?";
                button4.BackColor = Color.Yellow;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Ekin tanelerini ayıran, samanı deste veya balya durumuna getiren makineye verilen ad?";
                button5.BackColor = Color.Yellow;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Kanadanın İngilizce haricinde ki resmi dili nedir ?";
                button6.BackColor = Color.Yellow;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Bir günde kaç saniye vardır ?";
                button7.BackColor = Color.Yellow;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Dünyada en çok konuşulan dil ?";
                button8.BackColor = Color.Yellow;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Türkiye'nin kuzeyinde ki en uç şehirin adı nedir ?";
                button9.BackColor = Color.Yellow;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Bakterilerden daha küçük,yaşamak için başka hücrenin içine girmek zorunda olan parazite ne denir ?";
                button10.BackColor = Color.Yellow;
            }

            if (e.KeyCode == Keys.Enter)
            {
                
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "79")
                        {
                            soruno++;
                            button1.BackColor = Color.Green;
                           
                            

                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (0 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 2:
                        if (textBox1.Text == "400")
                        {
                            soruno++;
                            button2.BackColor = Color.Green;
                            
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (1.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "1000")
                        {
                            soruno++;
                            button3.BackColor = Color.Green;
                            
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (5.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "360")
                        {
                            soruno++;
                            button4.BackColor = Color.Green;

                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (10.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "biçerdöver")
                        {
                            soruno++;
                            button5.BackColor = Color.Green;

                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (15.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "fransızca")
                        {
                            soruno++;
                            button6.BackColor = Color.Green;

                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (25.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "86400")
                        {
                            soruno++;
                            button7.BackColor = Color.Green;

                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (50.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "çince")
                        {
                            soruno++;
                            button8.BackColor = Color.Green;

                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (100.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "sinop")
                        {
                            soruno++;
                            button9.BackColor = Color.Green;

                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (250.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "virüs")
                        {
                            soruno++;
                            button10.BackColor = Color.Green;
                            DialogResult secenek2 = MessageBox.Show("TEBRİKLER ARTIK BİR MİLYONERSİNİZ");
                            if (secenek2 == DialogResult.OK)
                            {
                                Application.Exit();
                            }

                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            DialogResult secenek = MessageBox.Show("YANLIŞ CEVAP (500.000 TL KAZANDINIZ)");
                            if (secenek == DialogResult.OK)
                            {
                                Application.Exit();
                            }
                        }
                        break;



                }
                
               
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            soruno++;
        }
    }
}    
