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
        int sayi1;
        int sayi2;
        int toplam;
        int islem;

        public Form1()
        {
            InitializeComponent();
        }

        private void buton_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "2";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "3";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "4";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "6";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "7";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "8";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "9";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            islem = 1;
            sayi1 = Convert.ToInt32(label1.Text);
            label1.Text = null;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            islem = 2;
            sayi1 = Convert.ToInt32(label1.Text);
            label1.Text = null;
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            islem = 3;
            sayi1 = Convert.ToInt32(label1.Text);
            label1.Text = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            islem = 4;
            sayi1 = Convert.ToInt32(label1.Text);
            label1.Text = null;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (islem==1)
            {
                sayi2 = Convert.ToInt32(label1.Text);
                toplam = sayi1 + sayi2;
                label3.Text = Convert.ToString(toplam);
                label1.Text = null;
            }
            else if (islem==2)
            {
                sayi2 = Convert.ToInt32(label1.Text);
                toplam = sayi1 - sayi2;
                label3.Text = Convert.ToString(toplam);
                label1.Text = null;
            }
            else if (islem==3)
            {
                sayi2 = Convert.ToInt32(label1.Text);
                toplam = sayi1 * sayi2;
                label3.Text = Convert.ToString(toplam);
                label1.Text = null;
            }
            else if (islem==4)
            {
                sayi2 = Convert.ToInt32(label1.Text);
                toplam = sayi1 / sayi2;
                label3.Text = Convert.ToString(toplam);
                label1.Text = null;
            }
            
        }

        
    }
}
