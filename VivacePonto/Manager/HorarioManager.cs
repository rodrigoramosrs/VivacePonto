using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace VivacePonto.Manager
{
    public static class HorarioManager
    {
        static Timer _temporizador = new Timer();

        static bool NotificouEntrada = false;
        static bool NotificouAlmocoSaida = false;
        static bool NotificouAlmocoRetorno = false;
        static bool NotificouSaida = false;
        static HorarioManager()
        {
            _temporizador.Stop();
            _temporizador.Interval = 5000;
            _temporizador.Tick += _temporizador_Tick;
        }

        private static void _temporizador_Tick(object sender, EventArgs e)
        {
            var dataAgora = DateTime.Now;

            int EntradaHora = Convert.ToInt32(ConfiguracaoManager.ConfiguracaoGlobal.EntradaHora);
            int EntradaMinuto = Convert.ToInt32(ConfiguracaoManager.ConfiguracaoGlobal.EntradaMinuto);

            int AlmocoSaidaHora = Convert.ToInt32(ConfiguracaoManager.ConfiguracaoGlobal.AlmocoSaidaHora);
            int AlmocoSaidaMinuto = Convert.ToInt32(ConfiguracaoManager.ConfiguracaoGlobal.AlmocoSaidaMinuto);

            int AlmocoRetornoHora = Convert.ToInt32(ConfiguracaoManager.ConfiguracaoGlobal.AlmocoRetornoHora);
            int AlmocoRetornoMinuto = Convert.ToInt32(ConfiguracaoManager.ConfiguracaoGlobal.AlmocoRetornoMinuto);

            int SaidaHora = Convert.ToInt32(ConfiguracaoManager.ConfiguracaoGlobal.SaidaHora);
            int SaidaMinuto = Convert.ToInt32(ConfiguracaoManager.ConfiguracaoGlobal.SaidaMinuto);

            bool Notificar = false;
            string NotificarMessage = "";

            if (dataAgora.Hour <= EntradaHora && !NotificouEntrada && !Notificar)
            {
                Notificar = dataAgora.Hour == EntradaHora && dataAgora.Minute == EntradaMinuto;

                if (Notificar)
                {
                    NotificarMessage = "ENTRADA";
                    NotificouEntrada = true;
                    NotificouSaida = false;
                }
            }
            
            if (dataAgora.Hour <= AlmocoSaidaHora && !NotificouAlmocoSaida && !Notificar)
            {
                Notificar = dataAgora.Hour == AlmocoSaidaHora && dataAgora.Minute == AlmocoSaidaMinuto;
                if (Notificar)
                {
                    NotificarMessage = "ALMOÇO";
                    NotificouAlmocoSaida = true;
                }
            }

            if (dataAgora.Hour <= AlmocoRetornoHora && !NotificouAlmocoRetorno && !Notificar)
            {
                Notificar = dataAgora.Hour == AlmocoRetornoHora && dataAgora.Minute == AlmocoRetornoMinuto;
                if (Notificar)
                {
                    NotificarMessage = "RETORNO DO ALMOÇO";
                    NotificouAlmocoRetorno = true;
                }
            }
            
            if (dataAgora.Hour <= SaidaHora && !NotificouSaida && !Notificar)
            {
                Notificar = dataAgora.Hour == SaidaHora &&  dataAgora.Minute == SaidaMinuto;
                if (Notificar)
                {
                    NotificarMessage = "SAÍDA";
                    NotificouSaida = true;

                    NotificouEntrada = false;
                    NotificouAlmocoSaida = false;
                    NotificouAlmocoRetorno = false;
                }
            }


            if(Notificar)
            {
                Helper.AvisoHelper.ShowAviso(NotificarMessage, dataAgora.Hour.ToString().PadLeft(2, '0') + ":" + dataAgora.Minute.ToString().PadLeft(2, '0'));
            }

        }


        private static void NotificarEntrada()
        {

        }

        private static void NotificarSaidaAlmoco()
        {

        }


        private static void NotificarRetrornoAlmoco()
        {

        }

        private static void NotificarSaida()
        {

        }

        public static void PararMonitoramento()
        {
            _temporizador.Stop();
        }
        public static void InicializarMonitoramento()
        {
            _temporizador.Start();
        }
    }
}
