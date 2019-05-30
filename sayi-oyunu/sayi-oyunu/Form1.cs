using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] dizi = new int[10];
        Random salla = new Random();
        bool kontrol, kontrol2;
        private void button1_Click(object sender, EventArgs e)
        {
            int s1, s2, s3, s4, s5, s6, s7, s8, s9;
            s1 = Convert.ToInt32(textBox1.Text);
            s2 = Convert.ToInt32(textBox2.Text);
            s3 = Convert.ToInt32(textBox3.Text);
            textBox10.Text = (s1 + s2 + s3).ToString();

            s4 = Convert.ToInt32(textBox4.Text);
            s5 = Convert.ToInt32(textBox5.Text);
            s6 = Convert.ToInt32(textBox6.Text);
            textBox11.Text = (s4 + s5 + s6).ToString();

            s7 = Convert.ToInt32(textBox7.Text);
            s8 = Convert.ToInt32(textBox8.Text);
            s9 = Convert.ToInt32(textBox9.Text);
            textBox12.Text = (s7 + s8 + s9).ToString();

            
            textBox13.Text = (s1 + s4 + s7).ToString();

           
            textBox14.Text = (s2 + s5 + s8).ToString();

            
            textBox15.Text = (s3 + s6 + s9).ToString();

            if (textBox10.Text=="15" && textBox11.Text=="15" && textBox12.Text=="15" &&
                textBox13.Text=="15" && textBox14.Text=="15" && textBox15.Text=="15")
            {
                MessageBox.Show("Tebrikler,başardınız!");
            }
            else
            {
                MessageBox.Show("Malesef olmadı.");

                textBox1.Clear();
                textBox1.Enabled = true;

                textBox2.Clear();
                textBox2.Enabled = true;

                textBox3.Clear();
                textBox3.Enabled = true;

                textBox4.Clear();
                textBox4.Enabled = true;

                textBox5.Clear();
                textBox5.Enabled = true;

                textBox6.Clear();
                textBox6.Enabled = true;

                textBox7.Clear();
                textBox7.Enabled = true;

                textBox8.Clear();
                textBox8.Enabled = true;

                textBox9.Clear();
                textBox9.Enabled = true;

                for (int i = 1; i < dizi.Length; i++)
                {
                    dizi[i] = 0;
                }

                button1.Visible = false;
                int sayi;

                sayi = salla.Next(1, 10);
                dizi[sayi] = 1;
                textBox2.Text = sayi.ToString();
                textBox2.Enabled = false;

                kontrol2 = true;
                while (kontrol2)
                {
                    sayi = salla.Next(1, 10);
                    if (dizi[sayi] == 0)
                    {
                        kontrol2 = false;
                        dizi[sayi] = 1;
                        textBox4.Text = sayi.ToString();
                        textBox4.Enabled = false;
                    }
                }
                kontrol2 = true;
                while (kontrol2)
                {
                    sayi = salla.Next(1, 10);
                    if (dizi[sayi] == 0)
                    {
                        kontrol2 = false;
                        dizi[sayi] = 1;
                        textBox9.Text = sayi.ToString();
                        textBox9.Enabled = false;
                    }
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                int sayi = Convert.ToInt32(textBox1.Text);
                if (dizi[sayi] == 0)
                {
                    dizi[sayi] = 1;
                    textBox1.Enabled = false;
                    textBox2.Focus();
                }
                else
                {
                    MessageBox.Show("bu sayı daha once kullanılmış!");
                    textBox1.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {
                int sayi = Convert.ToInt32(textBox3.Text);
                if (dizi[sayi] == 0)
                {
                    dizi[sayi] = 1;
                    textBox3.Enabled = false;
                    textBox4.Focus();
                }
                else
                {
                    MessageBox.Show("bu sayı daha once kullanılmış!");
                    textBox3.Clear();
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            if (textBox5.Text != "")
            {
                int sayi = Convert.ToInt32(textBox5.Text);
                if (dizi[sayi] == 0)
                {
                    dizi[sayi] = 1;
                    textBox5.Enabled = false;
                    textBox6.Focus();
                }
                else
                {
                    MessageBox.Show("bu sayı daha once kullanılmış!");
                    textBox5.Clear();
                }
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != "")
            {
                int sayi = Convert.ToInt32(textBox6.Text);
                if (dizi[sayi] == 0)
                {
                    dizi[sayi] = 1;
                    textBox6.Enabled = false;
                    textBox7.Focus();
                }
                else
                {
                    MessageBox.Show("bu sayı daha once kullanılmış!");
                    textBox6.Clear();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                int sayi = Convert.ToInt32(textBox7.Text);
                if (dizi[sayi] == 0)
                {
                    dizi[sayi] = 1;
                    textBox7.Enabled = false;
                    textBox8.Focus();
                }
                else
                {
                    MessageBox.Show("bu sayı daha once kullanılmış!");
                    textBox7.Clear();
                }
            }
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text != "")
            {
                int sayi = Convert.ToInt32(textBox8.Text);
                if (dizi[sayi] == 0)
                {
                    dizi[sayi] = 1;
                    textBox8.Enabled = false;
                    textBox9.Focus();
                }
                else
                {
                    MessageBox.Show("bu sayı daha once kullanılmış!");
                    textBox8.Clear();
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            kontrol = true;
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i]==0)
                {
                    kontrol = false;
                }
            }
            if (kontrol==true)
            {
                button1.Visible = true;
            }
            else
            {
                button1.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Enabled = true;

            textBox2.Clear();
            textBox2.Enabled = true;

            textBox3.Clear();
            textBox3.Enabled = true;

            textBox4.Clear();
            textBox4.Enabled = true;

            textBox5.Clear();
            textBox5.Enabled = true;

            textBox6.Clear();
            textBox6.Enabled = true;

            textBox7.Clear();
            textBox7.Enabled = true;

            textBox8.Clear();
            textBox8.Enabled = true;

            textBox9.Clear();
            textBox9.Enabled = true;

            for (int i = 1; i < dizi.Length; i++)
            {
                dizi[i] = 0;
            }
            int sayi;

            sayi = salla.Next(1, 10);
            dizi[sayi] = 1;
            textBox2.Text = sayi.ToString();
            textBox2.Enabled = false;

            kontrol2 = true;
            while (kontrol2)
            {
                sayi = salla.Next(1, 10);
                if (dizi[sayi] == 0)
                {
                    kontrol2 = false;
                    dizi[sayi] = 1;
                    textBox4.Text = sayi.ToString();
                    textBox4.Enabled = false;
                }
            }
            kontrol2 = true;
            while (kontrol2)
            {
                sayi = salla.Next(1, 10);
                if (dizi[sayi] == 0)
                {
                    kontrol2 = false;
                    dizi[sayi] = 1;
                    textBox9.Text = sayi.ToString();
                    textBox9.Enabled = false;
                }
            }

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

            int sayi;

            sayi = salla.Next(1, 10);
            dizi[sayi] = 1;
            textBox2.Text = sayi.ToString();
            textBox2.Enabled = false;

            kontrol2 = true;
            while (kontrol2)
            {
                sayi = salla.Next(1, 10);
                if (dizi[sayi] == 0)
                {
                    kontrol2 = false;
                    dizi[sayi] = 1;
                    textBox4.Text = sayi.ToString();
                    textBox4.Enabled = false;
                }
            }
            kontrol2 = true;
            while (kontrol2)
            {
                sayi = salla.Next(1, 10);
                if (dizi[sayi] == 0)
                {
                    kontrol2 = false;
                    dizi[sayi] = 1;
                    textBox9.Text = sayi.ToString();
                    textBox9.Enabled = false;
                }
            }
        }
    }
}
