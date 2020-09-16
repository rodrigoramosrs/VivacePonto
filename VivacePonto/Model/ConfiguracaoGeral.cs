using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VivacePonto.Model
{
    public class ConfiguracaoGeral
    {
        public string EntradaHora { get; set; }
        public string EntradaMinuto { get; set; }

        public string AlmocoSaidaHora { get; set; }
        public string AlmocoSaidaMinuto { get; set; }
        public string AlmocoRetornoHora { get; set; }
        public string AlmocoRetornoMinuto { get; set; }
        public string SaidaHora { get; set; }
        public string SaidaMinuto { get; set; }


        public bool NotificacaoTelaCheia { get; set; }
        public bool MinimizarDemaisTelas { get; set; }
        public bool AbrirBennerAposNotificacao { get; set; }
        
    }
}
