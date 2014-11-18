namespace SistemaEscola.Formulários.Admin.Turma
{
    partial class PesquisarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarTurma));
            this.lblCursoTurma = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.dgvDadosTurmas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCursoTurma
            // 
            this.lblCursoTurma.AutoSize = true;
            this.lblCursoTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoTurma.Location = new System.Drawing.Point(12, 19);
            this.lblCursoTurma.Name = "lblCursoTurma";
            this.lblCursoTurma.Size = new System.Drawing.Size(162, 16);
            this.lblCursoTurma.TabIndex = 0;
            this.lblCursoTurma.Text = "Escolha o curso da turma:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(171, 18);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(274, 21);
            this.cmbCurso.TabIndex = 1;
            // 
            // dgvDadosTurmas
            // 
            this.dgvDadosTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosTurmas.Location = new System.Drawing.Point(12, 54);
            this.dgvDadosTurmas.Name = "dgvDadosTurmas";
            this.dgvDadosTurmas.Size = new System.Drawing.Size(433, 209);
            this.dgvDadosTurmas.TabIndex = 2;
            // 
            // PesquisarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 273);
            this.Controls.Add(this.dgvDadosTurmas);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.lblCursoTurma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarTurma";
            this.Text = "Pesquisar Turmas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursoTurma;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.DataGridView dgvDadosTurmas;
    }
}