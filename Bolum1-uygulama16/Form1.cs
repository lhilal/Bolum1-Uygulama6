using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolum1_uygulama16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double turkceDogru, matDogru;
            double turkceYanlis, matYanlis;
            double turkceNet, matNet;
            turkceDogru = Convert.ToDouble(tdogru.Text);
            turkceYanlis = Convert.ToDouble(tyanlis.Text);
            turkceNet = (turkceDogru - (turkceYanlis / 4));
            tnet.Text = turkceNet.ToString();
            matDogru = Convert.ToDouble(mdogru.Text);
            matYanlis = Convert.ToDouble(myanlis.Text);
            matNet = (matDogru - (matYanlis / 4));
            mnet.Text = matNet.ToString();
        }
    }
}
