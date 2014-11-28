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
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAltDiscLimpar = new System.Windows.Forms.Button();
            this.btnPesqDisc = new System.Windows.Forms.Button();
            this.txtAltDiscCod = new System.Windows.Forms.MaskedTextBox();
            this.txtAltDiscCargHor = new System.Windows.Forms.MaskedTextBox();
            this.txtAltDiscDescricao = new System.Windows.Forms.TextBox();
            this.txtAltDiscNome = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblCargaHor = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
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
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(45, 231);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(87, 38);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnAltDiscLimpar
            // 
            this.btnAltDiscLimpar.Location = new System.Drawing.Point(199, 231);
            this.btnAltDiscLimpar.Name = "btnAltDiscLimpar";
            this.btnAltDiscLimpar.Size = new System.Drawing.Size(87, 38);
            this.btnAltDiscLimpar.TabIndex = 9;
            this.btnAltDiscLimpar.Text = "Limpar";
            this.btnAltDiscLimpar.UseVisualStyleBackColor = true;
            this.btnAltDiscLimpar.Click += new System.EventHandler(this.btnAltDiscLimpar_Click);
            // 
            // btnPesqDisc
            // 
            this.btnPesqDisc.Location = new System.Drawing.Point(237, 23);
            this.btnPesqDisc.Name = "btnPesqDisc";
            this.btnPesqDisc.Size = new System.Drawing.Size(81, 23);
            this.btnPesqDisc.TabIndex = 10;
            this.btnPesqDisc.Text = "Pesquisar";
            this.btnPesqDisc.UseVisualStyleBackColor = true;
            this.btnPesqDisc.Click += new System.EventHandler(this.btnPesqDisc_Click);
            // 
            // txtAltDiscCod
            // 
            this.txtAltDiscCod.Location = new System.Drawing.Point(124, 25);
            this.txtAltDiscCod.Mask = "000";
            this.txtAltDiscCod.Name = "txtAltDiscCod";
            this.txtAltDiscCod.Size = new System.Drawing.Size(100, 20);
            this.txtAltDiscCod.TabIndex = 11;
            // 
            // txtAltDiscCargHor
            // 
            this.txtAltDiscCargHor.Location = new System.Drawing.Point(115, 95);
            this.txtAltDiscCargHor.Mask = "000";
            this.txtAltDiscCargHor.Name = "txtAltDiscCargHor";
            this.txtAltDiscCargHor.Size = new System.Drawing.Size(182, 20);
            this.txtAltDiscCargHor.TabIndex = 17;
            // 
            // txtAltDiscDescricao
            // 
            this.txtAltDiscDescricao.Location = new System.Drawing.Point(98, 128);
            this.txtAltDiscDescricao.MaxLength = 75;
            this.txtAltDiscDescricao.Multiline = true;
            this.txtAltDiscDescricao.Name = "txtAltDiscDescricao";
            this.txtAltDiscDescricao.Size = new System.Drawing.Size(199, 97);
            this.txtAltDiscDescricao.TabIndex = 16;
            // 
            // txtAltDiscNome
            // 
            this.txtAltDiscNome.Location = new System.Drawing.Point(78, 62);
            this.txtAltDiscNome.MaxLength = 45;
            this.txtAltDiscNome.Name = "txtAltDiscNome";
            this.txtAltDiscNome.Size = new System.Drawing.Size(219, 20);
            this.txtAltDiscNome.TabIndex = 15;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(34, 131);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 14;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblCargaHor
            // 
            this.lblCargaHor.AutoSize = true;
            this.lblCargaHor.Location = new System.Drawing.Point(34, 98);
            this.lblCargaHor.Name = "lblCargaHor";
            this.lblCargaHor.Size = new System.Drawing.Size(75, 13);
            this.lblCargaHor.TabIndex = 13;
            this.lblCargaHor.Text = "Carga Horária:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(34, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 12;
            this.lblNome.Text = "Nome:";
            // 
            // AlterarDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 279);
            this.Controls.Add(this.txtAltDiscCargHor);
            this.Controls.Add(this.txtAltDiscDescricao);
            this.Controls.Add(this.txtAltDiscNome);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCargaHor);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtAltDiscCod);
            this.Controls.Add(this.btnPesqDisc);
            this.Controls.Add(this.btnAltDiscLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblCodDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarDisc";
            this.Text = "Alterar Dados da Disciplina";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodDisc;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAltDiscLimpar;
        private System.Windows.Forms.Button btnPesqDisc;
        private System.Windows.Forms.MaskedTextBox txtAltDiscCod;
        private System.Windows.Forms.MaskedTextBox txtAltDiscCargHor;
        private System.Windows.Forms.TextBox txtAltDiscDescricao;
        private System.Windows.Forms.TextBox txtAltDiscNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblCargaHor;
        private System.Windows.Forms.Label lblNome;
    }
}