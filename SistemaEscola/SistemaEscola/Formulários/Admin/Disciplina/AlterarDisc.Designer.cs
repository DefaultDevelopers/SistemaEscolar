namespace SistemaEscola.Formulários.Admin.Disciplina
{
    partial class AlterarDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarDisc));
            this.lblCodDisc = new System.Windows.Forms.Label();
            this.grboxDados = new System.Windows.Forms.GroupBox();
            this.txtAltDiscDescricao = new System.Windows.Forms.TextBox();
            this.txtAltDiscNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCargaHor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtAltDiscCod = new System.Windows.Forms.TextBox();
            this.btnAltDiscSalvar = new System.Windows.Forms.Button();
            this.btnAltDiscLimpar = new System.Windows.Forms.Button();
            this.btnPesqDisc = new System.Windows.Forms.Button();
            this.txtAltDiscCargHor = new System.Windows.Forms.MaskedTextBox();
            this.grboxDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodDisc
            // 
            this.lblCodDisc.AutoSize = true;
            this.lblCodDisc.Location = new System.Drawing.Point(12, 28);
            this.lblCodDisc.Name = "lblCodDisc";
            this.lblCodDisc.Size = new System.Drawing.Size(106, 13);
            this.lblCodDisc.TabIndex = 0;
            this.lblCodDisc.Text = "Código da Disciplina:";
            // 
            // grboxDados
            // 
            this.grboxDados.Controls.Add(this.txtAltDiscCargHor);
            this.grboxDados.Controls.Add(this.txtAltDiscDescricao);
            this.grboxDados.Controls.Add(this.txtAltDiscNome);
            this.grboxDados.Controls.Add(this.lblDescricao);
            this.grboxDados.Controls.Add(this.lblCargaHor);
            this.grboxDados.Controls.Add(this.lblNome);
            this.grboxDados.Location = new System.Drawing.Point(15, 64);
            this.grboxDados.Name = "grboxDados";
            this.grboxDados.Size = new System.Drawing.Size(303, 207);
            this.grboxDados.TabIndex = 1;
            this.grboxDados.TabStop = false;
            this.grboxDados.Text = "Dados a alterar";
            // 
            // txtAltDiscDescricao
            // 
            this.txtAltDiscDescricao.Location = new System.Drawing.Point(92, 99);
            this.txtAltDiscDescricao.MaxLength = 75;
            this.txtAltDiscDescricao.Multiline = true;
            this.txtAltDiscDescricao.Name = "txtAltDiscDescricao";
            this.txtAltDiscDescricao.Size = new System.Drawing.Size(199, 97);
            this.txtAltDiscDescricao.TabIndex = 7;
            // 
            // txtAltDiscNome
            // 
            this.txtAltDiscNome.Location = new System.Drawing.Point(72, 33);
            this.txtAltDiscNome.MaxLength = 45;
            this.txtAltDiscNome.Name = "txtAltDiscNome";
            this.txtAltDiscNome.Size = new System.Drawing.Size(219, 20);
            this.txtAltDiscNome.TabIndex = 5;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(28, 102);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCargaHor
            // 
            this.lblCargaHor.AutoSize = true;
            this.lblCargaHor.Location = new System.Drawing.Point(28, 69);
            this.lblCargaHor.Name = "lblCargaHor";
            this.lblCargaHor.Size = new System.Drawing.Size(75, 13);
            this.lblCargaHor.TabIndex = 3;
            this.lblCargaHor.Text = "Carga Horária:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(28, 36);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // txtAltDiscCod
            // 
            this.txtAltDiscCod.Location = new System.Drawing.Point(124, 25);
            this.txtAltDiscCod.Name = "txtAltDiscCod";
            this.txtAltDiscCod.Size = new System.Drawing.Size(107, 20);
            this.txtAltDiscCod.TabIndex = 8;
            // 
            // btnAltDiscSalvar
            // 
            this.btnAltDiscSalvar.Location = new System.Drawing.Point(46, 291);
            this.btnAltDiscSalvar.Name = "btnAltDiscSalvar";
            this.btnAltDiscSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnAltDiscSalvar.TabIndex = 8;
            this.btnAltDiscSalvar.Text = "Salvar";
            this.btnAltDiscSalvar.UseVisualStyleBackColor = true;
            // 
            // btnAltDiscLimpar
            // 
            this.btnAltDiscLimpar.Location = new System.Drawing.Point(211, 291);
            this.btnAltDiscLimpar.Name = "btnAltDiscLimpar";
            this.btnAltDiscLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnAltDiscLimpar.TabIndex = 9;
            this.btnAltDiscLimpar.Text = "Limpar";
            this.btnAltDiscLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesqDisc
            // 
            this.btnPesqDisc.Location = new System.Drawing.Point(237, 23);
            this.btnPesqDisc.Name = "btnPesqDisc";
            this.btnPesqDisc.Size = new System.Drawing.Size(81, 23);
            this.btnPesqDisc.TabIndex = 10;
            this.btnPesqDisc.Text = "Pesquisar";
            this.btnPesqDisc.UseVisualStyleBackColor = true;
            // 
            // txtAltDiscCargHor
            // 
            this.txtAltDiscCargHor.Location = new System.Drawing.Point(109, 66);
            this.txtAltDiscCargHor.Mask = "000";
            this.txtAltDiscCargHor.Name = "txtAltDiscCargHor";
            this.txtAltDiscCargHor.Size = new System.Drawing.Size(182, 20);
            this.txtAltDiscCargHor.TabIndex = 8;
            // 
            // AlterarDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 328);
            this.Controls.Add(this.btnPesqDisc);
            this.Controls.Add(this.btnAltDiscLimpar);
            this.Controls.Add(this.btnAltDiscSalvar);
            this.Controls.Add(this.txtAltDiscCod);
            this.Controls.Add(this.grboxDados);
            this.Controls.Add(this.lblCodDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarDisc";
            this.Text = "Alterar Dados da Disciplina";
            this.grboxDados.ResumeLayout(false);
            this.grboxDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodDisc;
        private System.Windows.Forms.GroupBox grboxDados;
        private System.Windows.Forms.TextBox txtAltDiscDescricao;
        private System.Windows.Forms.TextBox txtAltDiscNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCargaHor;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtAltDiscCod;
        private System.Windows.Forms.Button btnAltDiscSalvar;
        private System.Windows.Forms.Button btnAltDiscLimpar;
        private System.Windows.Forms.Button btnPesqDisc;
        private System.Windows.Forms.MaskedTextBox txtAltDiscCargHor;
    }
}