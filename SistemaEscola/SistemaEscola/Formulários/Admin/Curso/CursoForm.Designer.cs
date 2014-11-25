namespace SistemaEscola.Formulários.Admin.Curso
{
    partial class CursoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CursoForm));
            this.btnPesquisarCurso = new System.Windows.Forms.Button();
            this.btnDelCurso = new System.Windows.Forms.Button();
            this.btnAlteraCurso = new System.Windows.Forms.Button();
            this.btnCadCurso = new System.Windows.Forms.Button();
            this.picBoxDisc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisarCurso
            // 
            this.btnPesquisarCurso.Location = new System.Drawing.Point(145, 205);
            this.btnPesquisarCurso.Name = "btnPesquisarCurso";
            this.btnPesquisarCurso.Size = new System.Drawing.Size(128, 42);
            this.btnPesquisarCurso.TabIndex = 9;
            this.btnPesquisarCurso.Text = "Pesquisar Curso";
            this.btnPesquisarCurso.UseVisualStyleBackColor = true;
            // 
            // btnDelCurso
            // 
            this.btnDelCurso.Location = new System.Drawing.Point(11, 205);
            this.btnDelCurso.Name = "btnDelCurso";
            this.btnDelCurso.Size = new System.Drawing.Size(128, 42);
            this.btnDelCurso.TabIndex = 8;
            this.btnDelCurso.Text = "Deletar Curso";
            this.btnDelCurso.UseVisualStyleBackColor = true;
            // 
            // btnAlteraCurso
            // 
            this.btnAlteraCurso.Location = new System.Drawing.Point(145, 157);
            this.btnAlteraCurso.Name = "btnAlteraCurso";
            this.btnAlteraCurso.Size = new System.Drawing.Size(126, 42);
            this.btnAlteraCurso.TabIndex = 7;
            this.btnAlteraCurso.Text = "Alterar Curso";
            this.btnAlteraCurso.UseVisualStyleBackColor = true;
            // 
            // btnCadCurso
            // 
            this.btnCadCurso.Location = new System.Drawing.Point(11, 157);
            this.btnCadCurso.Name = "btnCadCurso";
            this.btnCadCurso.Size = new System.Drawing.Size(128, 42);
            this.btnCadCurso.TabIndex = 6;
            this.btnCadCurso.Text = "Cadastrar Curso";
            this.btnCadCurso.UseVisualStyleBackColor = true;
            this.btnCadCurso.Click += new System.EventHandler(this.btnCadCurso_Click);
            // 
            // picBoxDisc
            // 
            this.picBoxDisc.Image = global::SistemaEscola.Properties.Resources.Preciso_do_diploma2;
            this.picBoxDisc.Location = new System.Drawing.Point(74, 14);
            this.picBoxDisc.Name = "picBoxDisc";
            this.picBoxDisc.Size = new System.Drawing.Size(133, 137);
            this.picBoxDisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxDisc.TabIndex = 5;
            this.picBoxDisc.TabStop = false;
            // 
            // CursoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPesquisarCurso);
            this.Controls.Add(this.btnDelCurso);
            this.Controls.Add(this.btnAlteraCurso);
            this.Controls.Add(this.btnCadCurso);
            this.Controls.Add(this.picBoxDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CursoForm";
            this.Text = "Cursos";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDisc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisarCurso;
        private System.Windows.Forms.Button btnDelCurso;
        private System.Windows.Forms.Button btnAlteraCurso;
        private System.Windows.Forms.Button btnCadCurso;
        private System.Windows.Forms.PictureBox picBoxDisc;
    }
}