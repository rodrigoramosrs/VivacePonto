using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using VivacePonto.Forms;

namespace VivacePonto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool createdNew = false; ;
            var m_Mutex = new Mutex(true, "VivacePontoMutex", out createdNew);
            if (!createdNew)
            {
                MessageBox.Show("Já exite um processo ativo. Verifique na barra de ferramentas ao lado do relógio do windows.", Application.ProductName,
                  MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;

            }




            new Forms.frmSplash().ShowDialog();
            
            while(!Manager.ConfiguracaoManager.ConfigurationFileIsValid())
                new frmConfiguracao().ShowDialog();

            Manager.HorarioManager.InicializarMonitoramento();
            Application.Run(new frmPrincipal());
        }
    }
}
