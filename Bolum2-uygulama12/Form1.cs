﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bolum2_uygulama12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            int ses = trackBar1.Value;
            if (ses == 0)
            {
                label1.Text = "Ses Yok";
                label1.ForeColor = Color.Blue;
            }else if(ses>0 && ses <= 10)
            {
                label1.Text = "Normal Ses Seviyesi";
                label1.ForeColor = Color.Purple;
            }
            else
            {
                label1.Text = "Yüksek Ses Seviyesi";
                label1.ForeColor = Color.DarkRed;
            }
        }
    }
}
