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
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProf)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAlteraProf
            // 
            this.btnAlteraProf.Location = new System.Drawing.Point(146, 190);
            this.btnAlteraProf.Name = "btnAlteraProf";
            this.btnAlteraProf.Size = new System.Drawing.Size(126, 42);
            this.btnAlteraProf.TabIndex = 9;
            this.btnAlteraProf.Text = "Alterar Dados do Professor";
            this.btnAlteraProf.UseVisualStyleBackColor = true;
            // 
            // btnCadProf
            // 
            this.btnCadProf.Location = new System.Drawing.Point(12, 190);
            this.btnCadProf.Name = "btnCadProf";
            this.btnCadProf.Size = new System.Drawing.Size(128, 42);
            this.btnCadProf.TabIndex = 8;
            this.btnCadProf.Text = "Cadastrar Professor";
            this.btnCadProf.UseVisualStyleBackColor = true;
            // 
            // btnDiscMinis
            // 
            this.btnDiscMinis.Location = new System.Drawing.Point(12, 238);
            this.btnDiscMinis.Name = "btnDiscMinis";
            this.btnDiscMinis.Size = new System.Drawing.Size(128, 42);
            this.btnDiscMinis.TabIndex = 10;
            this.btnDiscMinis.Text = "Disciplina ministrada";
            this.btnDiscMinis.UseVisualStyleBackColor = true;
            // 
            // btnAlteraDiscMinis
            // 
            this.btnAlteraDiscMinis.Location = new System.Drawing.Point(146, 238);
            this.btnAlteraDiscMinis.Name = "btnAlteraDiscMinis";
            this.btnAlteraDiscMinis.Size = new System.Drawing.Size(128, 42);
            this.btnAlteraDiscMinis.TabIndex = 11;
            this.btnAlteraDiscMinis.Text = "Alterar Disciplina Ministrada";
            this.btnAlteraDiscMinis.UseVisualStyleBackColor = true;
            // 
            // btnDeletaDiscMinis
            // 
            this.btnDeletaDiscMinis.Location = new System.Drawing.Point(12, 286);
            this.btnDeletaDiscMinis.Name = "btnDeletaDiscMinis";
            this.btnDeletaDiscMinis.Size = new System.Drawing.Size(260, 42);
            this.btnDeletaDiscMinis.TabIndex = 12;
            this.btnDeletaDiscMinis.Text = "Deletar Disciplina Ministrada";
            this.btnDeletaDiscMinis.UseVisualStyleBackColor = true;
            // 
            // picBoxProf
            // 
            this.picBoxProf.Image = global::SistemaEscola.Properties.Resources.ProfButton1;
            this.picBoxProf.Location = new System.Drawing.Point(70, 28);
            this.picBoxProf.Name = "picBoxProf";
            this.picBoxProf.Size = new System.Drawing.Size(145, 147);
            this.picBoxProf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxProf.TabIndex = 7;
            this.picBoxProf.TabStop = false;
            // 
            // Professor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 351);
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

        }

        #endregion

        private System.Windows.Forms.Button btnAlteraProf;
        private System.Windows.Forms.Button btnCadProf;
        private System.Windows.Forms.PictureBox picBoxProf;
        private System.Windows.Forms.Button btnDiscMinis;
        private System.Windows.Forms.Button btnAlteraDiscMinis;
        private System.Windows.Forms.Button btnDeletaDiscMinis;
    }
}