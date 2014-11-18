namespace SistemaEscola.Formulários.Admin.Disciplina
{
    partial class Disciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Disciplina));
            this.picBoxDisc = new System.Windows.Forms.PictureBox();
            this.btnCadDisc = new System.Windows.Forms.Button();
            this.btnAlteraDisc = new System.Windows.Forms.Button();
            this.btnDelDisc = new System.Windows.Forms.Button();
            this.btnPesquisarDisc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxDisc
            // 
            this.picBoxDisc.Image = global::SistemaEscola.Properties.Resources.disc1;
            this.picBoxDisc.Location = new System.Drawing.Point(75, 21);
            this.picBoxDisc.Name = "picBoxDisc";
            this.picBoxDisc.Size = new System.Drawing.Size(128, 128);
            this.picBoxDisc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picBoxDisc.TabIndex = 0;
            this.picBoxDisc.TabStop = false;
            // 
            // btnCadDisc
            // 
            this.btnCadDisc.Location = new System.Drawing.Point(12, 164);
            this.btnCadDisc.Name = "btnCadDisc";
            this.btnCadDisc.Size = new System.Drawing.Size(128, 42);
            this.btnCadDisc.TabIndex = 1;
            this.btnCadDisc.Text = "Cadastrar Disciplina";
            this.btnCadDisc.UseVisualStyleBackColor = true;
            this.btnCadDisc.Click += new System.EventHandler(this.btnCadDisc_Click);
            // 
            // btnAlteraDisc
            // 
            this.btnAlteraDisc.Location = new System.Drawing.Point(146, 164);
            this.btnAlteraDisc.Name = "btnAlteraDisc";
            this.btnAlteraDisc.Size = new System.Drawing.Size(126, 42);
            this.btnAlteraDisc.TabIndex = 2;
            this.btnAlteraDisc.Text = "Alterar Disciplina";
            this.btnAlteraDisc.UseVisualStyleBackColor = true;
            this.btnAlteraDisc.Click += new System.EventHandler(this.btnAlteraDisc_Click);
            // 
            // btnDelDisc
            // 
            this.btnDelDisc.Location = new System.Drawing.Point(12, 212);
            this.btnDelDisc.Name = "btnDelDisc";
            this.btnDelDisc.Size = new System.Drawing.Size(128, 42);
            this.btnDelDisc.TabIndex = 3;
            this.btnDelDisc.Text = "Deletar Disciplina";
            this.btnDelDisc.UseVisualStyleBackColor = true;
            this.btnDelDisc.Click += new System.EventHandler(this.btnDelDisc_Click);
            // 
            // btnPesquisarDisc
            // 
            this.btnPesquisarDisc.Location = new System.Drawing.Point(146, 212);
            this.btnPesquisarDisc.Name = "btnPesquisarDisc";
            this.btnPesquisarDisc.Size = new System.Drawing.Size(128, 42);
            this.btnPesquisarDisc.TabIndex = 4;
            this.btnPesquisarDisc.Text = "Pesquisar Disciplina";
            this.btnPesquisarDisc.UseVisualStyleBackColor = true;
            this.btnPesquisarDisc.Click += new System.EventHandler(this.btnPesquisarDisc_Click);
            // 
            // Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 264);
            this.Controls.Add(this.btnPesquisarDisc);
            this.Controls.Add(this.btnDelDisc);
            this.Controls.Add(this.btnAlteraDisc);
            this.Controls.Add(this.btnCadDisc);
            this.Controls.Add(this.picBoxDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Disciplina";
            this.Text = "Disciplina";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxDisc;
        private System.Windows.Forms.Button btnCadDisc;
        private System.Windows.Forms.Button btnAlteraDisc;
        private System.Windows.Forms.Button btnDelDisc;
        private System.Windows.Forms.Button btnPesquisarDisc;
    }
}