using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VivacePonto.Forms
{
    public partial class frmOverlay : Form
    {
        public frmOverlay()
        {
            InitializeComponent();
            this.GotFocus += FrmOverlay_GotFocus;
        }

        private void FrmOverlay_GotFocus(object sender, EventArgs e)
        {
            Helper.AvisoHelper.BringAvisoFront();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(!Helper.AvisoHelper.IsAvisoVisivel())
            {
                Helper.AvisoHelper.CloseAviso();
            }
        }
    }
}
