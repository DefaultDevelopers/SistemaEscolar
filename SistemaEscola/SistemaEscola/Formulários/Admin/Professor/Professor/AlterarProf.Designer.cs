namespace SistemaEscola.Formulários.Admin.Professor
{
    partial class AlterarProf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarProf));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.cmbGrauFormacao = new System.Windows.Forms.ComboBox();
            this.dtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.txtFormacao = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.lblGrauForm = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblDadosProf = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblNum = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEnd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(316, 9);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(135, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(193, 12);
            this.txtCod.Mask = "00000000";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(117, 20);
            this.txtCod.TabIndex = 1;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(14, 13);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(181, 16);
            this.lblCod.TabIndex = 3;
            this.lblCod.Text = "Digite o código do professor:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(274, 319);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(95, 37);
            this.btnLimpar.TabIndex = 17;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(96, 319);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(95, 37);
            this.btnAlterar.TabIndex = 16;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // cmbGrauFormacao
            // 
            this.cmbGrauFormacao.FormattingEnabled = true;
            this.cmbGrauFormacao.Items.AddRange(new object[] {
            "Tecnólogo",
            "Bacharel",
            "Licenciado",
            "Especializado",
            "Mestre",
            "Doutor"});
            this.cmbGrauFormacao.Location = new System.Drawing.Point(339, 88);
            this.cmbGrauFormacao.Name = "cmbGrauFormacao";
            this.cmbGrauFormacao.Size = new System.Drawing.Size(96, 21);
            this.cmbGrauFormacao.TabIndex = 8;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.Location = new System.Drawing.Point(31, 158);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.Size = new System.Drawing.Size(193, 20);
            this.dtpDataNasc.TabIndex = 6;
            // 
            // txtFormacao
            // 
            this.txtFormacao.Location = new System.Drawing.Point(297, 114);
            this.txtFormacao.MaxLength = 25;
            this.txtFormacao.Name = "txtFormacao";
            this.txtFormacao.Size = new System.Drawing.Size(138, 20);
            this.txtFormacao.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(63, 113);
            this.txtEmail.MaxLength = 25;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(161, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(77, 87);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(147, 20);
            this.txtTelefone.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(77, 62);
            this.txtNome.MaxLength = 45;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(147, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Data de Nascimento:";
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Location = new System.Drawing.Point(243, 117);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(57, 13);
            this.lblForm.TabIndex = 31;
            this.lblForm.Text = "Formação:";
            // 
            // lblGrauForm
            // 
            this.lblGrauForm.AutoSize = true;
            this.lblGrauForm.Location = new System.Drawing.Point(243, 92);
            this.lblGrauForm.Name = "lblGrauForm";
            this.lblGrauForm.Size = new System.Drawing.Size(98, 13);
            this.lblGrauForm.TabIndex = 30;
            this.lblGrauForm.Text = "Grau de Formação:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(28, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(38, 13);
            this.lblEmail.TabIndex = 29;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(246, 67);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(30, 13);
            this.lblCPF.TabIndex = 28;
            this.lblCPF.Text = "CPF:";
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(28, 90);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(52, 13);
            this.lblTel.TabIndex = 27;
            this.lblTel.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome:";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(277, 62);
            this.txtCPF.Mask = "000.000.000-00";
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(158, 20);
            this.txtCPF.TabIndex = 7;
            // 
            // lblDadosProf
            // 
            this.lblDadosProf.AutoSize = true;
            this.lblDadosProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosProf.Location = new System.Drawing.Point(28, 41);
            this.lblDadosProf.Name = "lblDadosProf";
            this.lblDadosProf.Size = new System.Drawing.Size(141, 18);
            this.lblDadosProf.TabIndex = 51;
            this.lblDadosProf.Text = "Dados do professor";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(283, 282);
            this.txtCEP.Mask = "00000-000";
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(132, 20);
            this.txtCEP.TabIndex = 15;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(82, 282);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(128, 20);
            this.txtNum.TabIndex = 12;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(72, 252);
            this.txtBairro.MaxLength = 25;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(138, 20);
            this.txtBairro.TabIndex = 11;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(63, 222);
            this.txtRua.MaxLength = 25;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(147, 20);
            this.txtRua.TabIndex = 10;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(250, 255);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 58;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(250, 285);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(31, 13);
            this.lblCEP.TabIndex = 57;
            this.lblCEP.Text = "CEP:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(250, 223);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 55;
            this.lblEstado.Text = "Estado:";
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Location = new System.Drawing.Point(28, 285);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(47, 13);
            this.lblNum.TabIndex = 54;
            this.lblNum.Text = "Número:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(28, 255);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 53;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(28, 223);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(30, 13);
            this.lblRua.TabIndex = 52;
            this.lblRua.Text = "Rua:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(297, 220);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(118, 20);
            this.txtEstado.TabIndex = 13;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(297, 252);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(118, 20);
            this.txtCidade.TabIndex = 14;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnd.Location = new System.Drawing.Point(28, 197);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(72, 18);
            this.lblEnd.TabIndex = 68;
            this.lblEnd.Text = "Endereço";
            // 
            // AlterarProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 366);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblCEP);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNum);
            this.Controls.Add(this.lblBairro);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.lblDadosProf);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.cmbGrauFormacao);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.txtFormacao);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblForm);
            this.Controls.Add(this.lblGrauForm);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarProf";
            this.Text = "Alterar Dados de Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cmbGrauFormacao;
        private System.Windows.Forms.DateTimePicker dtpDataNasc;
        private System.Windows.Forms.TextBox txtFormacao;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblForm;
        private System.Windows.Forms.Label lblGrauForm;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox txtCPF;
        private System.Windows.Forms.Label lblDadosProf;
        private System.Windows.Forms.MaskedTextBox txtCEP;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEnd;
    }
}