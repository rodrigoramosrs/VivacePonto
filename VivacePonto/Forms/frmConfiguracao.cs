using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VivacePonto.Manager;

namespace VivacePonto.Forms
{
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
            if(Manager.ConfiguracaoManager.ConfigurationFileIsValid())
                this.SetConfigurationDataToForm(ConfiguracaoManager.ConfiguracaoGlobal);


        }

        private void SetConfigurationDataToForm(Model.ConfiguracaoGeral configuracao)
        {

            this.chkAbrirBennerAposNotificar.Checked = configuracao.AbrirBennerAposNotificacao;
            this.chkMinimizarDemaisJanelas.Checked = configuracao.MinimizarDemaisTelas;
            this.chkNotificacaoTelaCheia.Checked = configuracao.NotificacaoTelaCheia;


            nrEntradaHora.Value = Convert.ToInt32(configuracao.EntradaHora);
            nrEntradaMinuto.Value = Convert.ToInt32(configuracao.EntradaMinuto);

            nrAlmocoSaidaHora.Value = Convert.ToInt32(configuracao.AlmocoSaidaHora);
            nrAlmocoSaidaMinuto.Value = Convert.ToInt32(configuracao.AlmocoSaidaMinuto);

            nrAlmocoRetornoHora.Value = Convert.ToInt32(configuracao.AlmocoRetornoHora);
            nrAlmocoRetornoMinuto.Value = Convert.ToInt32(configuracao.AlmocoRetornoMinuto);

            nrSaidaHora.Value = Convert.ToInt32(configuracao.SaidaHora);
            nrSaidaMinuto.Value = Convert.ToInt32(configuracao.SaidaMinuto);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ConfiguracaoManager.WriteConfiguracao(this.GetConfiguracaoFromData());
            this.Close();

        }

        private Model.ConfiguracaoGeral GetConfiguracaoFromData()
        {
            Model.ConfiguracaoGeral configuracao = new Model.ConfiguracaoGeral();
            configuracao.AbrirBennerAposNotificacao = this.chkAbrirBennerAposNotificar.Checked;
            configuracao.MinimizarDemaisTelas = this.chkMinimizarDemaisJanelas.Checked;
            configuracao.NotificacaoTelaCheia = this.chkNotificacaoTelaCheia.Checked;


            configuracao.EntradaHora = nrEntradaHora.Value.ToString().PadLeft(2, '0');
            configuracao.EntradaMinuto = nrEntradaMinuto.Value.ToString().PadLeft(2, '0');

            configuracao.AlmocoSaidaHora = nrAlmocoSaidaHora.Value.ToString().PadLeft(2, '0');
            configuracao.AlmocoSaidaMinuto = nrAlmocoSaidaMinuto.Value.ToString().PadLeft(2, '0');

            configuracao.AlmocoRetornoHora = nrAlmocoRetornoHora.Value.ToString().PadLeft(2, '0');
            configuracao.AlmocoRetornoMinuto = nrAlmocoRetornoMinuto.Value.ToString().PadLeft(2, '0');

            configuracao.SaidaHora = nrSaidaHora.Value.ToString().PadLeft(2, '0');
            configuracao.SaidaMinuto = nrSaidaMinuto.Value.ToString().PadLeft(2, '0');
            
            return configuracao;
        }
    }
}
