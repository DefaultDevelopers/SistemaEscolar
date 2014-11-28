namespace SistemaEscola.Formulários.Admin.Professor
{
    partial class Professor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Professor));
            this.btnAlteraProf = new System.Windows.Forms.Button();
            this.btnCadProf = new System.Windows.Forms.Button();
            this.btnDiscMinis = new System.Windows.Forms.Button();
            this.btnAlteraDiscMinis = new System.Windows.Forms.Button();
            this.btnDeletaDiscMinis = new System.Windows.Forms.Button();
            this.picBoxProf = new System.Windows.Forms.PictureBox();
            this.btnPesqProf = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.lblProf = new System.Windows.Forms.Label();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblDisciplina = new System.Windows.Forms.Label();
            this.btnDeletarTurmaAula = new System.Windows.Forms.Button();
            this.btnAlterarTurmaAula = new System.Windows.Forms.Button();
            this.btnTurmaAula = new System.Windows.Forms.Button();
            this.btnPesqTurmaAula = new System.Windows.Forms.Button();
            this.btnPesqDisc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlteraProf
            // 
            this.btnAlteraProf.Location = new System.Drawing.Point(147, 218);
            this.btnAlteraProf.Name = "btnAlteraProf";
            this.btnAlteraProf.Size = new System.Drawing.Size(126, 42);
            this.btnAlteraProf.TabIndex = 9;
            this.btnAlteraProf.Text = "Alterar Dados do Professor";
            this.btnAlteraProf.UseVisualStyleBackColor = true;
            this.btnAlteraProf.Click += new System.EventHandler(this.btnAlteraProf_Click);
            // 
            // btnCadProf
            // 
            this.btnCadProf.Location = new System.Drawing.Point(13, 218);
            this.btnCadProf.Name = "btnCadProf";
            this.btnCadProf.Size = new System.Drawing.Size(128, 42);
            this.btnCadProf.TabIndex = 8;
            this.btnCadProf.Text = "Cadastrar Professor";
            this.btnCadProf.UseVisualStyleBackColor = true;
            this.btnCadProf.Click += new System.EventHandler(this.btnCadProf_Click);
            // 
            // btnDiscMinis
            // 
            this.btnDiscMinis.Location = new System.Drawing.Point(279, 218);
            this.btnDiscMinis.Name = "btnDiscMinis";
            this.btnDiscMinis.Size = new System.Drawing.Size(128, 42);
            this.btnDiscMinis.TabIndex = 10;
            this.btnDiscMinis.Text = "Disciplina ministrada";
            this.btnDiscMinis.UseVisualStyleBackColor = true;
            // 
            // btnAlteraDiscMinis
            // 
            this.btnAlteraDiscMinis.Location = new System.Drawing.Point(413, 218);
            this.btnAlteraDiscMinis.Name = "btnAlteraDiscMinis";
            this.btnAlteraDiscMinis.Size = new System.Drawing.Size(126, 42);
            this.btnAlteraDiscMinis.TabIndex = 11;
            this.btnAlteraDiscMinis.Text = "Alterar Disciplina Ministrada";
            this.btnAlteraDiscMinis.UseVisualStyleBackColor = true;
            // 
            // btnDeletaDiscMinis
            // 
            this.btnDeletaDiscMinis.Location = new System.Drawing.Point(279, 266);
            this.btnDeletaDiscMinis.Name = "btnDeletaDiscMinis";
            this.btnDeletaDiscMinis.Size = new System.Drawing.Size(128, 42);
            this.btnDeletaDiscMinis.TabIndex = 12;
            this.btnDeletaDiscMinis.Text = "Deletar Disciplina Ministrada";
            this.btnDeletaDiscMinis.UseVisualStyleBackColor = true;
            // 
            // picBoxProf
            // 
            this.picBoxProf.Image = global::SistemaEscola.Properties.Resources.ProfButton1;
            this.picBoxProf.Location = new System.Drawing.Point(323, 12);
            this.picBoxProf.Name = "picBoxProf";
            this.picBoxProf.Size = new System.Drawing.Size(178, 175);
            this.picBoxProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProf.TabIndex = 7;
            this.picBoxProf.TabStop = false;
            // 
            // btnPesqProf
            // 
            this.btnPesqProf.Location = new System.Drawing.Point(147, 266);
            this.btnPesqProf.Name = "btnPesqProf";
            this.btnPesqProf.Size = new System.Drawing.Size(126, 42);
            this.btnPesqProf.TabIndex = 14;
            this.btnPesqProf.Text = "Pesquisar Professor";
            this.btnPesqProf.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(13, 266);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(128, 42);
            this.btnDeletar.TabIndex = 13;
            this.btnDeletar.Text = "Deletar Professor";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // lblProf
            // 
            this.lblProf.AutoSize = true;
            this.lblProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProf.Location = new System.Drawing.Point(12, 199);
            this.lblProf.Name = "lblProf";
            this.lblProf.Size = new System.Drawing.Size(66, 16);
            this.lblProf.TabIndex = 15;
            this.lblProf.Text = "Professor";
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(550, 199);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(47, 16);
            this.lblTurma.TabIndex = 16;
            this.lblTurma.Text = "Turma";
            // 
            // lblDisciplina
            // 
            this.lblDisciplina.AutoSize = true;
            this.lblDisciplina.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisciplina.Location = new System.Drawing.Point(276, 199);
            this.lblDisciplina.Name = "lblDisciplina";
            this.lblDisciplina.Size = new System.Drawing.Size(67, 16);
            this.lblDisciplina.TabIndex = 17;
            this.lblDisciplina.Text = "Disciplina";
            // 
            // btnDeletarTurmaAula
            // 
            this.btnDeletarTurmaAula.Location = new System.Drawing.Point(553, 266);
            this.btnDeletarTurmaAula.Name = "btnDeletarTurmaAula";
            this.btnDeletarTurmaAula.Size = new System.Drawing.Size(128, 42);
            this.btnDeletarTurmaAula.TabIndex = 20;
            this.btnDeletarTurmaAula.Text = "Deletar Turma";
            this.btnDeletarTurmaAula.UseVisualStyleBackColor = true;
            this.btnDeletarTurmaAula.Click += new System.EventHandler(this.btnDeletarTurmaAula_Click);
            // 
            // btnAlterarTurmaAula
            // 
            this.btnAlterarTurmaAula.Location = new System.Drawing.Point(687, 218);
            this.btnAlterarTurmaAula.Name = "btnAlterarTurmaAula";
            this.btnAlterarTurmaAula.Size = new System.Drawing.Size(126, 42);
            this.btnAlterarTurmaAula.TabIndex = 19;
            this.btnAlterarTurmaAula.Text = "Alterar Turma";
            this.btnAlterarTurmaAula.UseVisualStyleBackColor = true;
            this.btnAlterarTurmaAula.Click += new System.EventHandler(this.btnAlterarTurmaAula_Click);
            // 
            // btnTurmaAula
            // 
            this.btnTurmaAula.Location = new System.Drawing.Point(553, 218);
            this.btnTurmaAula.Name = "btnTurmaAula";
            this.btnTurmaAula.Size = new System.Drawing.Size(128, 42);
            this.btnTurmaAula.TabIndex = 18;
            this.btnTurmaAula.Text = "Turma a dar aula";
            this.btnTurmaAula.UseVisualStyleBackColor = true;
            this.btnTurmaAula.Click += new System.EventHandler(this.btnTurmaAula_Click);
            // 
            // btnPesqTurmaAula
            // 
            this.btnPesqTurmaAula.Location = new System.Drawing.Point(687, 266);
            this.btnPesqTurmaAula.Name = "btnPesqTurmaAula";
            this.btnPesqTurmaAula.Size = new System.Drawing.Size(128, 42);
            this.btnPesqTurmaAula.TabIndex = 21;
            this.btnPesqTurmaAula.Text = "Pesquisa Turma";
            this.btnPesqTurmaAula.UseVisualStyleBackColor = true;
            this.btnPesqTurmaAula.Click += new System.EventHandler(this.btnPesqTurmaAula_Click);
            // 
            // btnPesqDisc
            // 
            this.btnPesqDisc.Location = new System.Drawing.Point(413, 266);
            this.btnPesqDisc.Name = "btnPesqDisc";
            this.btnPesqDisc.Size = new System.Drawing.Size(126, 42);
            this.btnPesqDisc.TabIndex = 22;
            this.btnPesqDisc.Text = "Pesquisar Disciplina";
            this.btnPesqDisc.UseVisualStyleBackColor = true;
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 317);
            this.Controls.Add(this.btnPesqDisc);
            this.Controls.Add(this.btnPesqTurmaAula);
            this.Controls.Add(this.btnDeletarTurmaAula);
            this.Controls.Add(this.btnAlterarTurmaAula);
            this.Controls.Add(this.btnTurmaAula);
            this.Controls.Add(this.lblDisciplina);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblProf);
            this.Controls.Add(this.btnPesqProf);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnDeletaDiscMinis);
            this.Controls.Add(this.btnAlteraDiscMinis);
            this.Controls.Add(this.btnDiscMinis);
            this.Controls.Add(this.btnAlteraProf);
            this.Controls.Add(this.btnCadProf);
            this.Controls.Add(this.picBoxProf);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Professor";
            this.Text = "Professor";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlteraProf;
        private System.Windows.Forms.Button btnCadProf;
        private System.Windows.Forms.PictureBox picBoxProf;
        private System.Windows.Forms.Button btnDiscMinis;
        private System.Windows.Forms.Button btnAlteraDiscMinis;
        private System.Windows.Forms.Button btnDeletaDiscMinis;
        private System.Windows.Forms.Button btnPesqProf;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Label lblProf;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblDisciplina;
        private System.Windows.Forms.Button btnDeletarTurmaAula;
        private System.Windows.Forms.Button btnAlterarTurmaAula;
        private System.Windows.Forms.Button btnTurmaAula;
        private System.Windows.Forms.Button btnPesqTurmaAula;
        private System.Windows.Forms.Button btnPesqDisc;
    }
}