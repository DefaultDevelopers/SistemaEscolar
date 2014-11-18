namespace SistemaEscola.Formulários.Admin.Turma
{
    partial class Turma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Turma));
            this.btnPesquisarTurma = new System.Windows.Forms.Button();
            this.btnDelTurma = new System.Windows.Forms.Button();
            this.btnAlteraTurma = new System.Windows.Forms.Button();
            this.btnCadTurma = new System.Windows.Forms.Button();
            this.picBoxMatricula = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarTurma
            // 
            this.btnPesquisarTurma.Location = new System.Drawing.Point(146, 199);
            this.btnPesquisarTurma.Name = "btnPesquisarTurma";
            this.btnPesquisarTurma.Size = new System.Drawing.Size(128, 42);
            this.btnPesquisarTurma.TabIndex = 11;
            this.btnPesquisarTurma.Text = "Pesquisar Turma";
            this.btnPesquisarTurma.UseVisualStyleBackColor = true;
            this.btnPesquisarTurma.Click += new System.EventHandler(this.btnPesquisarTurma_Click);
            // 
            // btnDelTurma
            // 
            this.btnDelTurma.Location = new System.Drawing.Point(12, 199);
            this.btnDelTurma.Name = "btnDelTurma";
            this.btnDelTurma.Size = new System.Drawing.Size(128, 42);
            this.btnDelTurma.TabIndex = 10;
            this.btnDelTurma.Text = "Deletar Turma";
            this.btnDelTurma.UseVisualStyleBackColor = true;
            this.btnDelTurma.Click += new System.EventHandler(this.btnDelTurma_Click);
            // 
            // btnAlteraTurma
            // 
            this.btnAlteraTurma.Location = new System.Drawing.Point(146, 151);
            this.btnAlteraTurma.Name = "btnAlteraTurma";
            this.btnAlteraTurma.Size = new System.Drawing.Size(126, 42);
            this.btnAlteraTurma.TabIndex = 9;
            this.btnAlteraTurma.Text = "Alterar dados da Turma";
            this.btnAlteraTurma.UseVisualStyleBackColor = true;
            this.btnAlteraTurma.Click += new System.EventHandler(this.btnAlteraTurma_Click);
            // 
            // btnCadTurma
            // 
            this.btnCadTurma.Location = new System.Drawing.Point(12, 151);
            this.btnCadTurma.Name = "btnCadTurma";
            this.btnCadTurma.Size = new System.Drawing.Size(128, 42);
            this.btnCadTurma.TabIndex = 8;
            this.btnCadTurma.Text = "Cadastrar Turma";
            this.btnCadTurma.UseVisualStyleBackColor = true;
            this.btnCadTurma.Click += new System.EventHandler(this.btnCadTurma_Click);
            // 
            // picBoxMatricula
            // 
            this.picBoxMatricula.Image = global::SistemaEscola.Properties.Resources.TumaIcon1;
            this.picBoxMatricula.Location = new System.Drawing.Point(78, 17);
            this.picBoxMatricula.Name = "picBoxMatricula";
            this.picBoxMatricula.Size = new System.Drawing.Size(128, 128);
            this.picBoxMatricula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxMatricula.TabIndex = 12;
            this.picBoxMatricula.TabStop = false;
            // 
            // Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picBoxMatricula);
            this.Controls.Add(this.btnPesquisarTurma);
            this.Controls.Add(this.btnDelTurma);
            this.Controls.Add(this.btnAlteraTurma);
            this.Controls.Add(this.btnCadTurma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Turma";
            this.Text = "Turma";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarTurma;
        private System.Windows.Forms.Button btnDelTurma;
        private System.Windows.Forms.Button btnAlteraTurma;
        private System.Windows.Forms.Button btnCadTurma;
        private System.Windows.Forms.PictureBox picBoxMatricula;
    }
}