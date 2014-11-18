namespace SistemaEscola.Formulários.Admin.Aluno
{
    partial class Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluno));
            this.btnAlteraAluno = new System.Windows.Forms.Button();
            this.btnCadAluno = new System.Windows.Forms.Button();
            this.picBoxAluno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlteraAluno
            // 
            this.btnAlteraAluno.Location = new System.Drawing.Point(146, 174);
            this.btnAlteraAluno.Name = "btnAlteraAluno";
            this.btnAlteraAluno.Size = new System.Drawing.Size(126, 42);
            this.btnAlteraAluno.TabIndex = 6;
            this.btnAlteraAluno.Text = "Alterar Aluno";
            this.btnAlteraAluno.UseVisualStyleBackColor = true;
            this.btnAlteraAluno.Click += new System.EventHandler(this.btnAlteraAluno_Click);
            // 
            // btnCadAluno
            // 
            this.btnCadAluno.Location = new System.Drawing.Point(12, 174);
            this.btnCadAluno.Name = "btnCadAluno";
            this.btnCadAluno.Size = new System.Drawing.Size(128, 42);
            this.btnCadAluno.TabIndex = 5;
            this.btnCadAluno.Text = "Cadastrar Aluno";
            this.btnCadAluno.UseVisualStyleBackColor = true;
            this.btnCadAluno.Click += new System.EventHandler(this.btnCadAluno_Click);
            // 
            // picBoxAluno
            // 
            this.picBoxAluno.Image = global::SistemaEscola.Properties.Resources.aluno;
            this.picBoxAluno.Location = new System.Drawing.Point(70, 12);
            this.picBoxAluno.Name = "picBoxAluno";
            this.picBoxAluno.Size = new System.Drawing.Size(145, 147);
            this.picBoxAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAluno.TabIndex = 0;
            this.picBoxAluno.TabStop = false;
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 226);
            this.Controls.Add(this.btnAlteraAluno);
            this.Controls.Add(this.btnCadAluno);
            this.Controls.Add(this.picBoxAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aluno";
            this.Text = "Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAluno;
        private System.Windows.Forms.Button btnAlteraAluno;
        private System.Windows.Forms.Button btnCadAluno;
    }
}