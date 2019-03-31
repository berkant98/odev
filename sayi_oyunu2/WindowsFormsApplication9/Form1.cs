using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        int ilk = 0, son = 101;
        int cevap,tahmin;
        public Form1()
        {
            InitializeComponent();
        }
        public void fonksiyon(int ilk, int son)
        {
            Random sayi = new Random();
            tahmin = sayi.Next(ilk, son);
            if (cevap == tahmin)
            {
                label1.Text = "Bildim! Tuttuğun sayi :" + cevap;
                arttir.Visible = false;
                azalt.Visible = false;
            }
            else
            {
                label1.Text = "Tuttuğun sayi bu mu? :" + tahmin;
            }
        }
        private void baslat_Click(object sender, EventArgs e)
        {
            try
            {
                cevap = Convert.ToInt32(textBox1.Text);
                if (cevap>=0 && cevap<=100)
                {
                    baslat.Visible = false;
                    Reset.Visible = true;
                    arttir.Visible = true;
                    azalt.Visible = true;
                    fonksiyon(0,101);
                }
                else
                {
                    MessageBox.Show("0 ile 100 arası bir sayi giriniz!!");
                } 
            }
            catch (Exception)
            {
                MessageBox.Show("0 ile 100 arası bir sayi giriniz!");
            }             
        }
        private void arttir_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            if (cevap>tahmin)
            {
                ilk = tahmin+1;
                fonksiyon(tahmin,son);
            }
            else
            {
                label2.Text = "yapılan tercihten eminmisin";
            } 
        }
        private void azalt_Click(object sender, EventArgs e)
        {
            label2.Text = " ";
            if (cevap<tahmin)
            {
                son = tahmin;
                fonksiyon(ilk, tahmin);
            }
            else
            {
                label2.Text = "yapılan tercihten eminmisin";
            }
        }
        private void Reset_Click(object sender, EventArgs e)
        {
            baslat.Visible = true;
            Reset.Visible = false;
            arttir.Visible = false;
            azalt.Visible = false;
            label1.Text = "Tahmin";
            label2.Text = " ";
            textBox1.Text = "";
            cevap = 0;
            tahmin = 0;
            ilk = 0;
            son = 101;
        }
    }
}
