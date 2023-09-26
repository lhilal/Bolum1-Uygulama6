using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum1_uygulama11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            bool durum;
            durum = checkBox1.Checked;
            if (durum==true) {
                label1.Text = "Lamba Durumu: True";
                checkBox1.Text = "Lambayı Kapat";
            }
            else
            {
                label1.Text = "Lamba Durumu: False";
                checkBox1.Text = "Lambayı Aç";
            }
        }
    }
}
