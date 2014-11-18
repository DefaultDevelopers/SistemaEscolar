namespace SistemaEscola.Formulários.Admin.Matricula
{
    partial class Matricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matricula));
            this.picBoxMatricula = new System.Windows.Forms.PictureBox();
            this.btnCadMatr = new System.Windows.Forms.Button();
            this.btnAlteraMatr = new System.Windows.Forms.Button();
            this.btnDelMatr = new System.Windows.Forms.Button();
            this.btnPesquisarMatr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMatricula)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxMatricula
            // 
            this.picBoxMatricula.Image = global::SistemaEscola.Properties.Resources.MatriculaIcon1;
            this.picBoxMatricula.Location = new System.Drawing.Point(74, 12);
            this.picBoxMatricula.Name = "picBoxMatricula";
            this.picBoxMatricula.Size = new System.Drawing.Size(128, 128);
            this.picBoxMatricula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxMatricula.TabIndex = 0;
            this.picBoxMatricula.TabStop = false;
            // 
            // btnCadMatr
            // 
            this.btnCadMatr.Location = new System.Drawing.Point(12, 158);
            this.btnCadMatr.Name = "btnCadMatr";
            this.btnCadMatr.Size = new System.Drawing.Size(128, 42);
            this.btnCadMatr.TabIndex = 4;
            this.btnCadMatr.Text = "Realizar Matrícula";
            this.btnCadMatr.UseVisualStyleBackColor = true;
            this.btnCadMatr.Click += new System.EventHandler(this.btnCadMatr_Click);
            // 
            // btnAlteraMatr
            // 
            this.btnAlteraMatr.Location = new System.Drawing.Point(146, 158);
            this.btnAlteraMatr.Name = "btnAlteraMatr";
            this.btnAlteraMatr.Size = new System.Drawing.Size(126, 42);
            this.btnAlteraMatr.TabIndex = 5;
            this.btnAlteraMatr.Text = "Alterar Matrícula";
            this.btnAlteraMatr.UseVisualStyleBackColor = true;
            this.btnAlteraMatr.Click += new System.EventHandler(this.btnAlteraMatr_Click);
            // 
            // btnDelMatr
            // 
            this.btnDelMatr.Location = new System.Drawing.Point(12, 206);
            this.btnDelMatr.Name = "btnDelMatr";
            this.btnDelMatr.Size = new System.Drawing.Size(128, 42);
            this.btnDelMatr.TabIndex = 6;
            this.btnDelMatr.Text = "Deletar Matrícula";
            this.btnDelMatr.UseVisualStyleBackColor = true;
            this.btnDelMatr.Click += new System.EventHandler(this.btnDelMatr_Click);
            // 
            // btnPesquisarMatr
            // 
            this.btnPesquisarMatr.Location = new System.Drawing.Point(146, 206);
            this.btnPesquisarMatr.Name = "btnPesquisarMatr";
            this.btnPesquisarMatr.Size = new System.Drawing.Size(128, 42);
            this.btnPesquisarMatr.TabIndex = 7;
            this.btnPesquisarMatr.Text = "Pesquisar Matrícula";
            this.btnPesquisarMatr.UseVisualStyleBackColor = true;
            this.btnPesquisarMatr.Click += new System.EventHandler(this.btnPesquisarMatr_Click);
            // 
            // Matricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnPesquisarMatr);
            this.Controls.Add(this.btnDelMatr);
            this.Controls.Add(this.btnAlteraMatr);
            this.Controls.Add(this.btnCadMatr);
            this.Controls.Add(this.picBoxMatricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Matricula";
            this.Text = "Matrícula";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxMatricula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxMatricula;
        private System.Windows.Forms.Button btnCadMatr;
        private System.Windows.Forms.Button btnAlteraMatr;
        private System.Windows.Forms.Button btnDelMatr;
        private System.Windows.Forms.Button btnPesquisarMatr;
    }
}