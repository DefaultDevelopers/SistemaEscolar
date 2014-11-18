namespace SistemaEscola.Formulários.Admin.Professor
{
    partial class DeletarDiscMinis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarDiscMinis));
            this.lblDadosDisc = new System.Windows.Forms.Label();
            this.dgvDadosDisc = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblDiscProf = new System.Windows.Forms.Label();
            this.dgvDiscProf = new System.Windows.Forms.DataGridView();
            this.txtCod = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblEscolhaDisc = new System.Windows.Forms.Label();
            this.txtDiscADeletar = new System.Windows.Forms.TextBox();
            this.lblIDADeletar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscProf)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDadosDisc
            // 
            this.lblDadosDisc.AutoSize = true;
            this.lblDadosDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDisc.Location = new System.Drawing.Point(333, 158);
            this.lblDadosDisc.Name = "lblDadosDisc";
            this.lblDadosDisc.Size = new System.Drawing.Size(138, 16);
            this.lblDadosDisc.TabIndex = 36;
            this.lblDadosDisc.Text = "Dados de disciplinas:";
            // 
            // dgvDadosDisc
            // 
            this.dgvDadosDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosDisc.Location = new System.Drawing.Point(333, 177);
            this.dgvDadosDisc.Name = "dgvDadosDisc";
            this.dgvDadosDisc.Size = new System.Drawing.Size(283, 83);
            this.dgvDadosDisc.TabIndex = 35;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(234, 96);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 23);
            this.btnPesquisar.TabIndex = 34;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(203, 221);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 39);
            this.btnLimpar.TabIndex = 33;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(46, 219);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 39);
            this.btnAlterar.TabIndex = 32;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblDiscProf
            // 
            this.lblDiscProf.AutoSize = true;
            this.lblDiscProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscProf.Location = new System.Drawing.Point(333, 49);
            this.lblDiscProf.Name = "lblDiscProf";
            this.lblDiscProf.Size = new System.Drawing.Size(156, 16);
            this.lblDiscProf.TabIndex = 31;
            this.lblDiscProf.Text = "Disciplinas do professor:";
            // 
            // dgvDiscProf
            // 
            this.dgvDiscProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscProf.Location = new System.Drawing.Point(333, 68);
            this.dgvDiscProf.Name = "dgvDiscProf";
            this.dgvDiscProf.Size = new System.Drawing.Size(283, 83);
            this.dgvDiscProf.TabIndex = 30;
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(192, 70);
            this.txtCod.Mask = "0000000";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(135, 20);
            this.txtCod.TabIndex = 27;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(13, 71);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(181, 16);
            this.lblCod.TabIndex = 26;
            this.lblCod.Text = "Digite o código do professor:";
            // 
            // lblEscolhaDisc
            // 
            this.lblEscolhaDisc.AutoSize = true;
            this.lblEscolhaDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaDisc.Location = new System.Drawing.Point(12, 18);
            this.lblEscolhaDisc.Name = "lblEscolhaDisc";
            this.lblEscolhaDisc.Size = new System.Drawing.Size(465, 20);
            this.lblEscolhaDisc.TabIndex = 25;
            this.lblEscolhaDisc.Text = "Pesquise quais disciplinas ministradas pelo professor e delete-as";
            // 
            // txtDiscADeletar
            // 
            this.txtDiscADeletar.Location = new System.Drawing.Point(180, 154);
            this.txtDiscADeletar.Name = "txtDiscADeletar";
            this.txtDiscADeletar.Size = new System.Drawing.Size(147, 20);
            this.txtDiscADeletar.TabIndex = 38;
            this.txtDiscADeletar.Text = "Para deletar";
            // 
            // lblIDADeletar
            // 
            this.lblIDADeletar.AutoSize = true;
            this.lblIDADeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDADeletar.Location = new System.Drawing.Point(10, 135);
            this.lblIDADeletar.Name = "lblIDADeletar";
            this.lblIDADeletar.Size = new System.Drawing.Size(321, 16);
            this.lblIDADeletar.TabIndex = 37;
            this.lblIDADeletar.Text = "Escolha o ID da disciplina ministrada a ser deletada:";
            // 
            // DeletarDiscMinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 275);
            this.Controls.Add(this.txtDiscADeletar);
            this.Controls.Add(this.lblIDADeletar);
            this.Controls.Add(this.lblDadosDisc);
            this.Controls.Add(this.dgvDadosDisc);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblDiscProf);
            this.Controls.Add(this.dgvDiscProf);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblEscolhaDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarDiscMinis";
            this.Text = "Deletar Disciplinas Ministradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadosDisc;
        private System.Windows.Forms.DataGridView dgvDadosDisc;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblDiscProf;
        private System.Windows.Forms.DataGridView dgvDiscProf;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblEscolhaDisc;
        private System.Windows.Forms.TextBox txtDiscADeletar;
        private System.Windows.Forms.Label lblIDADeletar;
    }
}