using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VivacePonto.Forms;

namespace VivacePonto.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            this.Resize += FrmPrincipal_Resize;
            notifyIcon1.Visible = true;
            this.Shown += FrmPrincipal_Shown;
        }

        private void FrmPrincipal_Shown(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(2000, "Vivace Ponto", "Para abrir as configurações de um duplo clique.", ToolTipIcon.Info);
        }

        private void FrmPrincipal_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        frmConfiguracao formConfiguracao = new frmConfiguracao();

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (formConfiguracao.Visible)
                formConfiguracao.BringToFront();
            else
                formConfiguracao.ShowDialog();
        }

        private void notifyIcon1_BalloonTipClicked(object sender, EventArgs e)
        {
            if (formConfiguracao.Visible)
                formConfiguracao.BringToFront();
            else
                formConfiguracao.ShowDialog();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void configuraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formConfiguracao.Visible)
                formConfiguracao.BringToFront();
            else
                formConfiguracao.ShowDialog();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/rodrigoramosrs");
        }
    }
}
