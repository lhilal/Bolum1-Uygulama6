using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_uygulama3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1=Convert.ToInt32(textBox1.Text);
            int sayi2=Convert.ToInt32(textBox2.Text);

            if (sayi1 == sayi2)
            {
                MessageBox.Show(textBox1.Text + "=" + textBox2.Text + "     SAYILAR BİRBİRİNE EŞİTTİR.");
            }else if(sayi1 < sayi2)
            {
                MessageBox.Show(textBox1.Text + "<" + textBox2.Text + "     1.SAYI 2.SAYIDAN KÜÇÜKTÜR.");
            }
            else
            {
                MessageBox.Show(textBox1.Text + ">" + textBox2.Text + "     1.SAYI 2.SAYIDAN BÜYÜKTÜR.");
            }
        }
    }
}
