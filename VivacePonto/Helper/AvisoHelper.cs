using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using VivacePonto.Forms;

namespace VivacePonto.Helper
{
    public static class AvisoHelper
    {
        static frmAviso formAviso;
        static frmOverlay formOverlay;
        public static void ShowAviso(string Titulo, string Horario)
        {
            CloseAviso();
            ValidateFormCreation();
            if (Manager.ConfiguracaoManager.ConfiguracaoGlobal.MinimizarDemaisTelas)
                Helper.WindowsHelper.MinimizeAll();

         

            if(Manager.ConfiguracaoManager.ConfiguracaoGlobal.NotificacaoTelaCheia)
                formOverlay.Show();


            formAviso.SetTitulo(Titulo);
            formAviso.SetHorario(Horario);
            formAviso.Show();

            if (Manager.ConfiguracaoManager.ConfiguracaoGlobal.AbrirBennerAposNotificacao)
                Process.Start("https://myplace.mv.com.br/BENNER_RH/Login");

        }

        internal static bool IsAvisoVisivel()
        {
            if (formAviso == null)
                return false;

            return formAviso.Visible;
        }

        private static void ValidateFormCreation()
        {
            if (formAviso == null)
                formAviso = new frmAviso();

            if (formOverlay == null)
                formOverlay = new frmOverlay();
        }

        public static void BringAvisoFront()
        {
            formAviso.BringToFront();
        }

        public static void CloseAviso()
        {
            if(formOverlay != null)
            {
                formOverlay.Hide();
                try
                {
                    formOverlay.Close();
                }
                catch (Exception)
                {

                    
                }
                formOverlay.Dispose();
                formOverlay = null;
            }

            if (formAviso != null)
            {
                formAviso.Hide();
                try
                {
                    formAviso.Close();
                }
                catch (Exception)
                {


                }
                formAviso.Dispose();
                formAviso = null;
            }


        }
    }
}
