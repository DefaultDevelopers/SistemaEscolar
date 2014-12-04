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
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblEscolhaDisc = new System.Windows.Forms.Label();
            this.lblIDADeletar = new System.Windows.Forms.Label();
            this.txtDiscADeletar = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDadosDisc
            // 
            this.lblDadosDisc.AutoSize = true;
            this.lblDadosDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDisc.Location = new System.Drawing.Point(330, 48);
            this.lblDadosDisc.Name = "lblDadosDisc";
            this.lblDadosDisc.Size = new System.Drawing.Size(62, 16);
            this.lblDadosDisc.TabIndex = 36;
            this.lblDadosDisc.Text = "Vínculos:";
            // 
            // dgvDadosDisc
            // 
            this.dgvDadosDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosDisc.Location = new System.Drawing.Point(333, 67);
            this.dgvDadosDisc.Name = "dgvDadosDisc";
            this.dgvDadosDisc.Size = new System.Drawing.Size(283, 193);
            this.dgvDadosDisc.TabIndex = 35;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(234, 107);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 23);
            this.btnPesquisar.TabIndex = 34;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(46, 219);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(93, 39);
            this.btnDeletar.TabIndex = 32;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(202, 81);
            this.txtCod.Mask = "00000000";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(125, 20);
            this.txtCod.TabIndex = 27;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(13, 82);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(57, 16);
            this.lblCod.TabIndex = 26;
            this.lblCod.Text = "Digite o ";
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
            // lblIDADeletar
            // 
            this.lblIDADeletar.AutoSize = true;
            this.lblIDADeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDADeletar.Location = new System.Drawing.Point(12, 165);
            this.lblIDADeletar.Name = "lblIDADeletar";
            this.lblIDADeletar.Size = new System.Drawing.Size(241, 16);
            this.lblIDADeletar.TabIndex = 37;
            this.lblIDADeletar.Text = "Escolha o ID do vínculo a ser deletado:";
            // 
            // txtDiscADeletar
            // 
            this.txtDiscADeletar.Location = new System.Drawing.Point(250, 161);
            this.txtDiscADeletar.Mask = "000";
            this.txtDiscADeletar.Name = "txtDiscADeletar";
            this.txtDiscADeletar.Size = new System.Drawing.Size(77, 20);
            this.txtDiscADeletar.TabIndex = 38;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(64, 82);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(132, 16);
            this.linkLabel1.TabIndex = 39;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "código do professor:";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // DeletarDiscMinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 275);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtDiscADeletar);
            this.Controls.Add(this.lblIDADeletar);
            this.Controls.Add(this.lblDadosDisc);
            this.Controls.Add(this.dgvDadosDisc);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblEscolhaDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarDiscMinis";
            this.Text = "Deletar Disciplinas Ministradas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDadosDisc;
        private System.Windows.Forms.DataGridView dgvDadosDisc;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblEscolhaDisc;
        private System.Windows.Forms.Label lblIDADeletar;
        private System.Windows.Forms.MaskedTextBox txtDiscADeletar;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}