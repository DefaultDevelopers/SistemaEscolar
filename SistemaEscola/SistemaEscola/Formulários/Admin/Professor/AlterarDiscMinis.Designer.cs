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
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblDiscProf = new System.Windows.Forms.Label();
            this.dgvDiscProf = new System.Windows.Forms.DataGridView();
            this.cmbEscDisc = new System.Windows.Forms.ComboBox();
            this.lblEscDisc = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.MaskedTextBox();
            this.lblCod = new System.Windows.Forms.Label();
            this.lblEscolhaDisc = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDadosDisc = new System.Windows.Forms.Label();
            this.dgvDadosDisc = new System.Windows.Forms.DataGridView();
            this.lblIDAAlterar = new System.Windows.Forms.Label();
            this.txtDiscAAlterar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscProf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(203, 212);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 39);
            this.btnLimpar.TabIndex = 21;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(46, 210);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(93, 39);
            this.btnAlterar.TabIndex = 20;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // lblDiscProf
            // 
            this.lblDiscProf.AutoSize = true;
            this.lblDiscProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscProf.Location = new System.Drawing.Point(333, 40);
            this.lblDiscProf.Name = "lblDiscProf";
            this.lblDiscProf.Size = new System.Drawing.Size(156, 16);
            this.lblDiscProf.TabIndex = 19;
            this.lblDiscProf.Text = "Disciplinas do professor:";
            // 
            // dgvDiscProf
            // 
            this.dgvDiscProf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiscProf.Location = new System.Drawing.Point(333, 59);
            this.dgvDiscProf.Name = "dgvDiscProf";
            this.dgvDiscProf.Size = new System.Drawing.Size(283, 83);
            this.dgvDiscProf.TabIndex = 18;
            // 
            // cmbEscDisc
            // 
            this.cmbEscDisc.FormattingEnabled = true;
            this.cmbEscDisc.Location = new System.Drawing.Point(161, 165);
            this.cmbEscDisc.Name = "cmbEscDisc";
            this.cmbEscDisc.Size = new System.Drawing.Size(157, 21);
            this.cmbEscDisc.TabIndex = 17;
            this.cmbEscDisc.Text = "Escolha a nova disciplina";
            // 
            // lblEscDisc
            // 
            this.lblEscDisc.AutoSize = true;
            this.lblEscDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscDisc.Location = new System.Drawing.Point(1, 166);
            this.lblEscDisc.Name = "lblEscDisc";
            this.lblEscDisc.Size = new System.Drawing.Size(164, 16);
            this.lblEscDisc.TabIndex = 16;
            this.lblEscDisc.Text = "Escolha a nova disciplina:";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(192, 61);
            this.txtCod.Mask = "0000000";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(126, 20);
            this.txtCod.TabIndex = 15;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(13, 62);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(181, 16);
            this.lblCod.TabIndex = 14;
            this.lblCod.Text = "Digite o código do professor:";
            // 
            // lblEscolhaDisc
            // 
            this.lblEscolhaDisc.AutoSize = true;
            this.lblEscolhaDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaDisc.Location = new System.Drawing.Point(12, 9);
            this.lblEscolhaDisc.Name = "lblEscolhaDisc";
            this.lblEscolhaDisc.Size = new System.Drawing.Size(461, 20);
            this.lblEscolhaDisc.TabIndex = 13;
            this.lblEscolhaDisc.Text = "Pesquise quais disciplinas ministradas pelo professor e altere-as";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(234, 87);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(84, 23);
            this.btnPesquisar.TabIndex = 22;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblDadosDisc
            // 
            this.lblDadosDisc.AutoSize = true;
            this.lblDadosDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosDisc.Location = new System.Drawing.Point(333, 149);
            this.lblDadosDisc.Name = "lblDadosDisc";
            this.lblDadosDisc.Size = new System.Drawing.Size(138, 16);
            this.lblDadosDisc.TabIndex = 24;
            this.lblDadosDisc.Text = "Dados de disciplinas:";
            // 
            // dgvDadosDisc
            // 
            this.dgvDadosDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosDisc.Location = new System.Drawing.Point(333, 168);
            this.dgvDadosDisc.Name = "dgvDadosDisc";
            this.dgvDadosDisc.Size = new System.Drawing.Size(283, 83);
            this.dgvDadosDisc.TabIndex = 23;
            // 
            // lblIDAAlterar
            // 
            this.lblIDAAlterar.AutoSize = true;
            this.lblIDAAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDAAlterar.Location = new System.Drawing.Point(1, 113);
            this.lblIDAAlterar.Name = "lblIDAAlterar";
            this.lblIDAAlterar.Size = new System.Drawing.Size(317, 16);
            this.lblIDAAlterar.TabIndex = 25;
            this.lblIDAAlterar.Text = "Escolha o ID da disciplina ministrada a ser alterada:";
            // 
            // txtDiscAAlterar
            // 
            this.txtDiscAAlterar.Location = new System.Drawing.Point(171, 132);
            this.txtDiscAAlterar.Name = "txtDiscAAlterar";
            this.txtDiscAAlterar.Size = new System.Drawing.Size(147, 20);
            this.txtDiscAAlterar.TabIndex = 26;
            this.txtDiscAAlterar.Text = "Para alterar";
            // 
            // AlterarDiscMinis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 261);
            this.Controls.Add(this.txtDiscAAlterar);
            this.Controls.Add(this.lblIDAAlterar);
            this.Controls.Add(this.lblDadosDisc);
            this.Controls.Add(this.dgvDadosDisc);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.lblDiscProf);
            this.Controls.Add(this.dgvDiscProf);
            this.Controls.Add(this.cmbEscDisc);
            this.Controls.Add(this.lblEscDisc);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblEscolhaDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarDiscMinis";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscProf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblDiscProf;
        private System.Windows.Forms.DataGridView dgvDiscProf;
        private System.Windows.Forms.ComboBox cmbEscDisc;
        private System.Windows.Forms.Label lblEscDisc;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblEscolhaDisc;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblDadosDisc;
        private System.Windows.Forms.DataGridView dgvDadosDisc;
        private System.Windows.Forms.Label lblIDAAlterar;
        private System.Windows.Forms.TextBox txtDiscAAlterar;

    }
}