namespace SistemaEscola.Formulários.Admin.Disciplina
{
    partial class CadastrarDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarDisc));
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiscCod = new System.Windows.Forms.Label();
            this.lblDiscNome = new System.Windows.Forms.Label();
            this.lblCargaHor = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtCodDisc = new System.Windows.Forms.MaskedTextBox();
            this.txtDiscNome = new System.Windows.Forms.TextBox();
            this.txtDiscCargaHor = new System.Windows.Forms.MaskedTextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnDiscSalvar = new System.Windows.Forms.Button();
            this.btnDiscLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite os dados da disciplina:";
            // 
            // lblDiscCod
            // 
            this.lblDiscCod.AutoSize = true;
            this.lblDiscCod.Location = new System.Drawing.Point(12, 41);
            this.lblDiscCod.Name = "lblDiscCod";
            this.lblDiscCod.Size = new System.Drawing.Size(106, 13);
            this.lblDiscCod.TabIndex = 1;
            this.lblDiscCod.Text = "Código da Disciplina:";
            // 
            // lblDiscNome
            // 
            this.lblDiscNome.AutoSize = true;
            this.lblDiscNome.Location = new System.Drawing.Point(12, 73);
            this.lblDiscNome.Name = "lblDiscNome";
            this.lblDiscNome.Size = new System.Drawing.Size(38, 13);
            this.lblDiscNome.TabIndex = 2;
            this.lblDiscNome.Text = "Nome:";
            // 
            // lblCargaHor
            // 
            this.lblCargaHor.AutoSize = true;
            this.lblCargaHor.Location = new System.Drawing.Point(12, 106);
            this.lblCargaHor.Name = "lblCargaHor";
            this.lblCargaHor.Size = new System.Drawing.Size(73, 13);
            this.lblCargaHor.TabIndex = 3;
            this.lblCargaHor.Text = "Carga horária:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(12, 141);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(58, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição:";
            // 
            // txtCodDisc
            // 
            this.txtCodDisc.Location = new System.Drawing.Point(124, 38);
            this.txtCodDisc.Mask = "000";
            this.txtCodDisc.Name = "txtCodDisc";
            this.txtCodDisc.Size = new System.Drawing.Size(161, 20);
            this.txtCodDisc.TabIndex = 5;
            // 
            // txtDiscNome
            // 
            this.txtDiscNome.Location = new System.Drawing.Point(54, 70);
            this.txtDiscNome.MaxLength = 45;
            this.txtDiscNome.Name = "txtDiscNome";
            this.txtDiscNome.Size = new System.Drawing.Size(231, 20);
            this.txtDiscNome.TabIndex = 6;
            // 
            // txtDiscCargaHor
            // 
            this.txtDiscCargaHor.Location = new System.Drawing.Point(91, 103);
            this.txtDiscCargaHor.Mask = "00";
            this.txtDiscCargaHor.Name = "txtDiscCargaHor";
            this.txtDiscCargaHor.Size = new System.Drawing.Size(194, 20);
            this.txtDiscCargaHor.TabIndex = 7;
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(76, 138);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(209, 103);
            this.txtDescricao.TabIndex = 8;
            // 
            // btnDiscSalvar
            // 
            this.btnDiscSalvar.Location = new System.Drawing.Point(52, 263);
            this.btnDiscSalvar.Name = "btnDiscSalvar";
            this.btnDiscSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnDiscSalvar.TabIndex = 9;
            this.btnDiscSalvar.Text = "Salvar";
            this.btnDiscSalvar.UseVisualStyleBackColor = true;
            // 
            // btnDiscLimpar
            // 
            this.btnDiscLimpar.Location = new System.Drawing.Point(178, 263);
            this.btnDiscLimpar.Name = "btnDiscLimpar";
            this.btnDiscLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnDiscLimpar.TabIndex = 10;
            this.btnDiscLimpar.Text = "Limpar";
            this.btnDiscLimpar.UseVisualStyleBackColor = true;
            // 
            // CadastrarDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 298);
            this.Controls.Add(this.btnDiscLimpar);
            this.Controls.Add(this.btnDiscSalvar);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtDiscCargaHor);
            this.Controls.Add(this.txtDiscNome);
            this.Controls.Add(this.txtCodDisc);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblCargaHor);
            this.Controls.Add(this.lblDiscNome);
            this.Controls.Add(this.lblDiscCod);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarDisc";
            this.Text = "Cadastro de Disciplinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiscCod;
        private System.Windows.Forms.Label lblDiscNome;
        private System.Windows.Forms.Label lblCargaHor;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.MaskedTextBox txtCodDisc;
        private System.Windows.Forms.TextBox txtDiscNome;
        private System.Windows.Forms.MaskedTextBox txtDiscCargaHor;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnDiscSalvar;
        private System.Windows.Forms.Button btnDiscLimpar;
    }
}