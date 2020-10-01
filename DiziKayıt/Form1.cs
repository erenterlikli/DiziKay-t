using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiziKayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] adsoyad = new string[30];
        string[] telefon = new string[11];
        string[] ilce = new string[20];

        int i = 0; 

        private void Temizle()
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            comboBox1.Text = " ";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            adsoyad[i] = textBox1.Text;
            telefon[i] = textBox2.Text;
            ilce[i] = comboBox1.Text;
            i++; //son yazdığını göstersin.
            Temizle();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            i--; //son girileni göstersin. Diziler FIFO mantığıyla çalışır.
            label7.Text = adsoyad[i];
            label8.Text = telefon[i];
            label9.Text = ilce[i];
            Temizle();
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            i--;
            label7.Text = adsoyad[i];
            label8.Text = telefon[i];
            label9.Text = ilce[i];
            Temizle();
            textBox1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            label7.Text = adsoyad[i];
            label8.Text = telefon[i];
            label9.Text = ilce[i];
            Temizle();
            textBox1.Focus();
        }
    }
}
