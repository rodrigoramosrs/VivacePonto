using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VivacePonto.Forms
{
    public partial class frmAviso : Form
    {
        public void SetHorario(string Horario)
        {
            this.lblHorario.Text = Horario;
        }

        public void SetTitulo(string Titulo)
        {
            this.lblTitulo.Text = Titulo;
        }

        public frmAviso()
        {
            InitializeComponent();
        }

        private void frmAviso_Shown(object sender, EventArgs e)
        {
            
            
        }

        private void frmAviso_Enter(object sender, EventArgs e)
        {
        }

        private void btnFecharAviso_Click(object sender, EventArgs e)
        {
            Helper.AvisoHelper.CloseAviso();
        }
    }
}
