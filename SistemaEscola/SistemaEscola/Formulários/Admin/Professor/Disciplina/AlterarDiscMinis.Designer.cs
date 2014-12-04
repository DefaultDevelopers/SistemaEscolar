namespace SistemaEscola.Formulários.Admin.Professor
{
    partial class AlterarDiscMinis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarDiscMinis));
            this.linklblCod = new System.Windows.Forms.LinkLabel();
            this.txtDiscAAlterar = new System.Windows.Forms.MaskedTextBox();
            this.lblIDADeletar = new System.Windows.Forms.Label();
            this.lblDadosDisc = new System.Windows.Forms.Label();
            this.dgvDadosDisc = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblEscolhaDisc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDisc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // linklblCod
            // 
            this.linklblCod.AutoSize = true;
            this.linklblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblCod.Location = new System.Drawing.Point(64, 59);
            this.linklblCod.Name = "linklblCod";
            this.linklblCod.Size = new System.Drawing.Size(132, 16);
            this.linklblCod.TabIndex = 50;
            this.linklblCod.TabStop = true;
            this.linklblCod.Text = "código do professor:";
            // 
            // txtDiscAAlterar
            // 
            this.txtDiscAAlterar.Location = new System.Drawing.Point(251, 123);
            this.txtDiscAAlterar.Mask = "000";
            this.txtDiscAAlterar.Name = "txtDiscAAlterar";
            this.txtDiscAAlterar.Size = new System.Drawing.Size(77, 20);
            this.txtDiscAAlterar.TabIndex = 49;
            // 
            // lblIDADeletar
            // 
            this.lblIDADeletar.AutoSize = true;
            this.lblIDADeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDADeletar.Location = new System.Drawing.Point(13, 127);
            this.lblIDADeletar.Name = "lblIDADeletar";
            this.lblIDADeletar.Size = new System.Drawing.Size(237, 16);
            this.lblIDADeletar.TabIndex = 48;
            this.lblIDADeletar.Text = "Escolha o ID do vínculo a ser alterado:";
            // 
            // lblDadosDisc
            // 
            this.lblDadosDisc.AutoSize = true;
            this.lblDadosDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDisc.Location = new System.Drawing.Point(330, 39);
            this.lblDadosDisc.Name = "lblDadosDisc";
            this.lblDadosDisc.Size = new System.Drawing.Size(62, 16);
            this.lblDadosDisc.TabIndex = 47;
            this.lblDadosDisc.Text = "Vínculos:";
            // 
            // dgvDadosDisc
            // 
            this.dgvDadosDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosDisc.Location = new System.Drawing.Point(333, 58);
            this.dgvDadosDisc.Name = "dgvDadosDisc";
            this.dgvDadosDisc.Size = new System.Drawing.Size(283, 193);
            this.dgvDadosDisc.TabIndex = 46;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(235, 84);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(93, 23);
            this.btnPesquisar.TabIndex = 45;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(203, 212);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 39);
            this.btnLimpar.TabIndex = 44;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(46, 210);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 39);
            this.btnAlterar.TabIndex = 43;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(202, 58);
            this.txtCod.Mask = "00000000";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(125, 20);
            this.txtCod.TabIndex = 42;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(13, 59);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(57, 16);
            this.lblCod.TabIndex = 41;
            this.lblCod.Text = "Digite o ";
            // 
            // lblEscolhaDisc
            // 
            this.lblEscolhaDisc.AutoSize = true;
            this.lblEscolhaDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaDisc.Location = new System.Drawing.Point(12, 9);
            this.lblEscolhaDisc.Name = "lblEscolhaDisc";
            this.lblEscolhaDisc.Size = new System.Drawing.Size(461, 20);
            this.lblEscolhaDisc.TabIndex = 40;
            this.lblEscolhaDisc.Text = "Pesquise quais disciplinas ministradas pelo professor e altere-as";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Escolha a nova disciplina:";
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.Location = new System.Drawing.Point(183, 160);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(145, 21);
            this.cmbDisc.TabIndex = 52;
            // 
            // AlterarDiscMinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linklblCod);
            this.Controls.Add(this.txtDiscAAlterar);
            this.Controls.Add(this.lblIDADeletar);
            this.Controls.Add(this.lblDadosDisc);
            this.Controls.Add(this.dgvDadosDisc);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblEscolhaDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarDiscMinis";
            this.Load += new System.EventHandler(this.AlterarDiscMinis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linklblCod;
        private System.Windows.Forms.MaskedTextBox txtDiscAAlterar;
        private System.Windows.Forms.Label lblIDADeletar;
        private System.Windows.Forms.Label lblDadosDisc;
        private System.Windows.Forms.DataGridView dgvDadosDisc;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblEscolhaDisc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDisc;


    }
}