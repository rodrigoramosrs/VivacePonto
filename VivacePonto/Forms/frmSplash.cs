﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VivacePonto.Forms
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();

            this.lblVersao.Text = Application.ProductVersion;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.timer1.Stop();
            this.Close();

        }
    }
}
