using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yuzde_Hesaplama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi = int.Parse(textBox1.Text);
            sayi = sayi * int.Parse(textBox2.Text);
            sayi = sayi / 100;

            label1.Text = sayi.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double fiyat, kdv, toplam;
            fiyat = Convert.ToDouble(textBox4.Text);
            kdv = fiyat * Convert.ToDouble(textBox3.Text) / 100;

            if (radioButton1.Checked == true)
            {
                toplam = fiyat + kdv;

                label5.Text = toplam.ToString();

            }
            else if (radioButton2.Checked == true)
            {

                toplam = fiyat - kdv;

                label5.Text = toplam.ToString();
            }


        }
    }
}
