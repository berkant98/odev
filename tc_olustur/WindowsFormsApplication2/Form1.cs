using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        ArrayList depo = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean devam = true;
            Random sayi = new Random();
            int[] dizi = new int[12];
            int adet = Convert.ToInt32(comboBox1.Text);
            for (int j = 0; j < adet; j++)
            {
                string tc = "";
                int tek = 0, cift = 0;
                for (int i = 1; i < 10; i++)
                {
                    if (i == 1)
                    {
                        dizi[i] = sayi.Next(1, 10);
                        tc = tc + dizi[i].ToString();
                        tek = tek + dizi[i];
                        i++;
                    }
                    dizi[i] = sayi.Next(0, 10);
                    tc = tc + dizi[i].ToString();
                    if (i % 2 == 0)
                    {
                        cift = cift + dizi[i];
                    }
                    else
                    {
                        tek = tek + dizi[i];
                    }
                }
                dizi[10] = ((tek * 7) - cift) % 10;
                dizi[11] = (tek + cift + dizi[10]) % 10;
                tc = tc + dizi[10].ToString() + dizi[11].ToString();
                for (int i = 1; i < depo.Count + 1; i++)
                {
                    if (depo[i - 1] == tc)
                    {
                        devam = false;
                        MessageBox.Show("Aynı tc eklenmedi!");
                        j--;
                    }
                }
                if (devam)
                {
                    depo.Add(tc);
                    listBox1.Items.Clear();
                }
            }
            for (int i = 0; i < depo.Count; i++)
            {
                listBox1.Items.Add(depo[i]);
            }
            button2.Visible = true;
            label1.Text = depo.Count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            depo.Clear();
            button2.Visible = false;
            label1.Text = "";
        }        
    }
}
