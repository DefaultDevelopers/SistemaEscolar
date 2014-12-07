namespace SistemaEscola.Formulários.Admin
{
    partial class PesquisaUsuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaUsuário));
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.rdAluno = new System.Windows.Forms.RadioButton();
            this.rdProf = new System.Windows.Forms.RadioButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblPorNome = new System.Windows.Forms.Label();
            this.lblPorCod = new System.Windows.Forms.Label();
            this.txtPorNome = new System.Windows.Forms.TextBox();
            this.txtPorCod = new System.Windows.Forms.MaskedTextBox();
            this.grpPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.rdAluno);
            this.grpPesquisa.Controls.Add(this.rdProf);
            this.grpPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPesquisa.Location = new System.Drawing.Point(63, 12);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(460, 51);
            this.grpPesquisa.TabIndex = 0;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Pesquisar por";
            this.grpPesquisa.Enter += new System.EventHandler(this.grpPesquisa_CheckedChanged);
            // 
            // rdAluno
            // 
            this.rdAluno.AutoSize = true;
            this.rdAluno.Location = new System.Drawing.Point(248, 21);
            this.rdAluno.Name = "rdAluno";
            this.rdAluno.Size = new System.Drawing.Size(60, 20);
            this.rdAluno.TabIndex = 1;
            this.rdAluno.TabStop = true;
            this.rdAluno.Text = "Aluno";
            this.rdAluno.UseVisualStyleBackColor = true;
            // 
            // rdProf
            // 
            this.rdProf.AutoSize = true;
            this.rdProf.Location = new System.Drawing.Point(129, 21);
            this.rdProf.Name = "rdProf";
            this.rdProf.Size = new System.Drawing.Size(84, 20);
            this.rdProf.TabIndex = 0;
            this.rdProf.TabStop = true;
            this.rdProf.Text = "Professor";
            this.rdProf.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(18, 107);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(552, 261);
            this.dgvDados.TabIndex = 5;
            // 
            // lblPorNome
            // 
            this.lblPorNome.AutoSize = true;
            this.lblPorNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorNome.Location = new System.Drawing.Point(60, 84);
            this.lblPorNome.Name = "lblPorNome";
            this.lblPorNome.Size = new System.Drawing.Size(72, 16);
            this.lblPorNome.TabIndex = 6;
            this.lblPorNome.Text = "Por Nome:";
            // 
            // lblPorCod
            // 
            this.lblPorCod.AutoSize = true;
            this.lblPorCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorCod.Location = new System.Drawing.Point(308, 84);
            this.lblPorCod.Name = "lblPorCod";
            this.lblPorCod.Size = new System.Drawing.Size(79, 16);
            this.lblPorCod.TabIndex = 7;
            this.lblPorCod.Text = "Por Código:";
            // 
            // txtPorNome
            // 
            this.txtPorNome.Location = new System.Drawing.Point(138, 81);
            this.txtPorNome.Name = "txtPorNome";
            this.txtPorNome.Size = new System.Drawing.Size(138, 20);
            this.txtPorNome.TabIndex = 8;
            this.txtPorNome.TextChanged += new System.EventHandler(this.txtPorNome_TextChanged);
            // 
            // txtPorCod
            // 
            this.txtPorCod.Location = new System.Drawing.Point(385, 80);
            this.txtPorCod.Mask = "00000000000";
            this.txtPorCod.Name = "txtPorCod";
            this.txtPorCod.Size = new System.Drawing.Size(138, 20);
            this.txtPorCod.TabIndex = 10;
            this.txtPorCod.TextChanged += new System.EventHandler(this.txtPorCod_TextChanged);
            // 
            // PesquisaUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 380);
            this.Controls.Add(this.txtPorCod);
            this.Controls.Add(this.txtPorNome);
            this.Controls.Add(this.lblPorCod);
            this.Controls.Add(this.lblPorNome);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.grpPesquisa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaUsuário";
            this.Text = "Pesquisa de Usuário";
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.RadioButton rdAluno;
        private System.Windows.Forms.RadioButton rdProf;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblPorNome;
        private System.Windows.Forms.Label lblPorCod;
        private System.Windows.Forms.TextBox txtPorNome;
        private System.Windows.Forms.MaskedTextBox txtPorCod;
    }
}