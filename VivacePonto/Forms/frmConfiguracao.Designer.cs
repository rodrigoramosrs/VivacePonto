namespace VivacePonto.Forms
{
    partial class frmConfiguracao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguracao));
            this.label1 = new System.Windows.Forms.Label();
            this.nrEntradaHora = new System.Windows.Forms.NumericUpDown();
            this.nrAlmocoSaidaMinuto = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nrAlmocoSaidaHora = new System.Windows.Forms.NumericUpDown();
            this.nrEntradaMinuto = new System.Windows.Forms.NumericUpDown();
            this.nrAlmocoRetornoHora = new System.Windows.Forms.NumericUpDown();
            this.nrAlmocoRetornoMinuto = new System.Windows.Forms.NumericUpDown();
            this.nrSaidaHora = new System.Windows.Forms.NumericUpDown();
            this.nrSaidaMinuto = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkAbrirBennerAposNotificar = new System.Windows.Forms.CheckBox();
            this.chkMinimizarDemaisJanelas = new System.Windows.Forms.CheckBox();
            this.chkNotificacaoTelaCheia = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nrEntradaHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlmocoSaidaMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlmocoSaidaHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrEntradaMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlmocoRetornoHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlmocoRetornoMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSaidaHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSaidaMinuto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrada";
            // 
            // nrEntradaHora
            // 
            this.nrEntradaHora.Location = new System.Drawing.Point(7, 50);
            this.nrEntradaHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrEntradaHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nrEntradaHora.Name = "nrEntradaHora";
            this.nrEntradaHora.Size = new System.Drawing.Size(48, 29);
            this.nrEntradaHora.TabIndex = 1;
            this.nrEntradaHora.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // nrAlmocoSaidaMinuto
            // 
            this.nrAlmocoSaidaMinuto.Location = new System.Drawing.Point(78, 107);
            this.nrAlmocoSaidaMinuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrAlmocoSaidaMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nrAlmocoSaidaMinuto.Name = "nrAlmocoSaidaMinuto";
            this.nrAlmocoSaidaMinuto.Size = new System.Drawing.Size(48, 29);
            this.nrAlmocoSaidaMinuto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Almoço - Saída";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Almoço - Retorno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 199);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Saída";
            // 
            // nrAlmocoSaidaHora
            // 
            this.nrAlmocoSaidaHora.Location = new System.Drawing.Point(7, 107);
            this.nrAlmocoSaidaHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrAlmocoSaidaHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nrAlmocoSaidaHora.Name = "nrAlmocoSaidaHora";
            this.nrAlmocoSaidaHora.Size = new System.Drawing.Size(48, 29);
            this.nrAlmocoSaidaHora.TabIndex = 10;
            this.nrAlmocoSaidaHora.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // nrEntradaMinuto
            // 
            this.nrEntradaMinuto.Location = new System.Drawing.Point(78, 50);
            this.nrEntradaMinuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrEntradaMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nrEntradaMinuto.Name = "nrEntradaMinuto";
            this.nrEntradaMinuto.Size = new System.Drawing.Size(48, 29);
            this.nrEntradaMinuto.TabIndex = 11;
            // 
            // nrAlmocoRetornoHora
            // 
            this.nrAlmocoRetornoHora.Location = new System.Drawing.Point(7, 166);
            this.nrAlmocoRetornoHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrAlmocoRetornoHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nrAlmocoRetornoHora.Name = "nrAlmocoRetornoHora";
            this.nrAlmocoRetornoHora.Size = new System.Drawing.Size(48, 29);
            this.nrAlmocoRetornoHora.TabIndex = 13;
            this.nrAlmocoRetornoHora.Value = new decimal(new int[] {
            13,
            0,
            0,
            0});
            // 
            // nrAlmocoRetornoMinuto
            // 
            this.nrAlmocoRetornoMinuto.Location = new System.Drawing.Point(78, 166);
            this.nrAlmocoRetornoMinuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrAlmocoRetornoMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nrAlmocoRetornoMinuto.Name = "nrAlmocoRetornoMinuto";
            this.nrAlmocoRetornoMinuto.Size = new System.Drawing.Size(48, 29);
            this.nrAlmocoRetornoMinuto.TabIndex = 12;
            // 
            // nrSaidaHora
            // 
            this.nrSaidaHora.Location = new System.Drawing.Point(7, 224);
            this.nrSaidaHora.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrSaidaHora.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nrSaidaHora.Name = "nrSaidaHora";
            this.nrSaidaHora.Size = new System.Drawing.Size(48, 29);
            this.nrSaidaHora.TabIndex = 15;
            this.nrSaidaHora.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // nrSaidaMinuto
            // 
            this.nrSaidaMinuto.Location = new System.Drawing.Point(78, 224);
            this.nrSaidaMinuto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nrSaidaMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nrSaidaMinuto.Name = "nrSaidaMinuto";
            this.nrSaidaMinuto.Size = new System.Drawing.Size(48, 29);
            this.nrSaidaMinuto.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 83);
            this.panel1.TabIndex = 16;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VivacePonto.Properties.Resources.cog;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 23);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Configurações gerais";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nrEntradaHora);
            this.groupBox1.Controls.Add(this.nrSaidaHora);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nrSaidaMinuto);
            this.groupBox1.Controls.Add(this.nrAlmocoSaidaMinuto);
            this.groupBox1.Controls.Add(this.nrAlmocoRetornoHora);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.nrAlmocoRetornoMinuto);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nrEntradaMinuto);
            this.groupBox1.Controls.Add(this.nrAlmocoSaidaHora);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 271);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Horários";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(60, 228);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(60, 170);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 21);
            this.label8.TabIndex = 18;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(60, 111);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 21);
            this.label7.TabIndex = 17;
            this.label7.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = ":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkAbrirBennerAposNotificar);
            this.groupBox2.Controls.Add(this.chkMinimizarDemaisJanelas);
            this.groupBox2.Controls.Add(this.chkNotificacaoTelaCheia);
            this.groupBox2.Location = new System.Drawing.Point(188, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 267);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configurações de notificação";
            // 
            // chkAbrirBennerAposNotificar
            // 
            this.chkAbrirBennerAposNotificar.AutoSize = true;
            this.chkAbrirBennerAposNotificar.Checked = true;
            this.chkAbrirBennerAposNotificar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAbrirBennerAposNotificar.Location = new System.Drawing.Point(6, 90);
            this.chkAbrirBennerAposNotificar.Name = "chkAbrirBennerAposNotificar";
            this.chkAbrirBennerAposNotificar.Size = new System.Drawing.Size(215, 25);
            this.chkAbrirBennerAposNotificar.TabIndex = 2;
            this.chkAbrirBennerAposNotificar.Text = "Abrir benner após notificar";
            this.chkAbrirBennerAposNotificar.UseVisualStyleBackColor = true;
            // 
            // chkMinimizarDemaisJanelas
            // 
            this.chkMinimizarDemaisJanelas.AutoSize = true;
            this.chkMinimizarDemaisJanelas.Location = new System.Drawing.Point(6, 59);
            this.chkMinimizarDemaisJanelas.Name = "chkMinimizarDemaisJanelas";
            this.chkMinimizarDemaisJanelas.Size = new System.Drawing.Size(219, 25);
            this.chkMinimizarDemaisJanelas.TabIndex = 1;
            this.chkMinimizarDemaisJanelas.Text = "Minimizar todos aplicativos";
            this.chkMinimizarDemaisJanelas.UseVisualStyleBackColor = true;
            // 
            // chkNotificacaoTelaCheia
            // 
            this.chkNotificacaoTelaCheia.AutoSize = true;
            this.chkNotificacaoTelaCheia.Checked = true;
            this.chkNotificacaoTelaCheia.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNotificacaoTelaCheia.Location = new System.Drawing.Point(6, 28);
            this.chkNotificacaoTelaCheia.Name = "chkNotificacaoTelaCheia";
            this.chkNotificacaoTelaCheia.Size = new System.Drawing.Size(202, 25);
            this.chkNotificacaoTelaCheia.TabIndex = 0;
            this.chkNotificacaoTelaCheia.Text = "Notificação em tela cheia";
            this.chkNotificacaoTelaCheia.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(347, 365);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 34);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(252, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 34);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmConfiguracao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 405);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConfiguracao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurações Gerais";
            ((System.ComponentModel.ISupportInitialize)(this.nrEntradaHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlmocoSaidaMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlmocoSaidaHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrEntradaMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlmocoRetornoHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrAlmocoRetornoMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSaidaHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nrSaidaMinuto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nrEntradaHora;
        private System.Windows.Forms.NumericUpDown nrAlmocoSaidaMinuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nrAlmocoSaidaHora;
        private System.Windows.Forms.NumericUpDown nrEntradaMinuto;
        private System.Windows.Forms.NumericUpDown nrAlmocoRetornoHora;
        private System.Windows.Forms.NumericUpDown nrAlmocoRetornoMinuto;
        private System.Windows.Forms.NumericUpDown nrSaidaHora;
        private System.Windows.Forms.NumericUpDown nrSaidaMinuto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkNotificacaoTelaCheia;
        private System.Windows.Forms.CheckBox chkMinimizarDemaisJanelas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chkAbrirBennerAposNotificar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}