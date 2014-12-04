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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdAluno = new System.Windows.Forms.RadioButton();
            this.rdProf = new System.Windows.Forms.RadioButton();
            this.btnPorNome = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblPorNome = new System.Windows.Forms.Label();
            this.lblPorCod = new System.Windows.Forms.Label();
            this.txtPorNome = new System.Windows.Forms.TextBox();
            this.btnPorCod = new System.Windows.Forms.Button();
            this.txtPorCod = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdAluno);
            this.groupBox1.Controls.Add(this.rdProf);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(63, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
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
            // btnPorNome
            // 
            this.btnPorNome.Location = new System.Drawing.Point(176, 110);
            this.btnPorNome.Name = "btnPorNome";
            this.btnPorNome.Size = new System.Drawing.Size(100, 26);
            this.btnPorNome.TabIndex = 3;
            this.btnPorNome.Text = "Pesquisar";
            this.btnPorNome.UseVisualStyleBackColor = true;
            this.btnPorNome.Click += new System.EventHandler(this.btnPorNome_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(18, 142);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(552, 226);
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
            // 
            // btnPorCod
            // 
            this.btnPorCod.Location = new System.Drawing.Point(423, 107);
            this.btnPorCod.Name = "btnPorCod";
            this.btnPorCod.Size = new System.Drawing.Size(100, 26);
            this.btnPorCod.TabIndex = 9;
            this.btnPorCod.Text = "Pesquisar";
            this.btnPorCod.UseVisualStyleBackColor = true;
            this.btnPorCod.Click += new System.EventHandler(this.btnPorCod_Click);
            // 
            // txtPorCod
            // 
            this.txtPorCod.Location = new System.Drawing.Point(385, 80);
            this.txtPorCod.Mask = "00000000000";
            this.txtPorCod.Name = "txtPorCod";
            this.txtPorCod.Size = new System.Drawing.Size(138, 20);
            this.txtPorCod.TabIndex = 10;
            // 
            // PesquisaUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 380);
            this.Controls.Add(this.txtPorCod);
            this.Controls.Add(this.btnPorCod);
            this.Controls.Add(this.txtPorNome);
            this.Controls.Add(this.lblPorCod);
            this.Controls.Add(this.lblPorNome);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.btnPorNome);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaUsuário";
            this.Text = "Pesquisa de Usuário";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdAluno;
        private System.Windows.Forms.RadioButton rdProf;
        private System.Windows.Forms.Button btnPorNome;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblPorNome;
        private System.Windows.Forms.Label lblPorCod;
        private System.Windows.Forms.TextBox txtPorNome;
        private System.Windows.Forms.Button btnPorCod;
        private System.Windows.Forms.MaskedTextBox txtPorCod;
    }
}