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
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodTurma = new System.Windows.Forms.Label();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosTurmas)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCursoTurma
            // 
            this.lblCursoTurma.AutoSize = true;
            this.lblCursoTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoTurma.Location = new System.Drawing.Point(58, 19);
            this.lblCursoTurma.Name = "lblCursoTurma";
            this.lblCursoTurma.Size = new System.Drawing.Size(162, 16);
            this.lblCursoTurma.TabIndex = 0;
            this.lblCursoTurma.Text = "Escolha o curso da turma:";
            // 
            // cmbCurso
            // 
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(217, 18);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(181, 21);
            this.cmbCurso.TabIndex = 1;
            this.cmbCurso.SelectedIndexChanged += new System.EventHandler(this.cmbCurso_SelectionChangeCommitted);
            // 
            // dgvDadosTurmas
            // 
            this.dgvDadosTurmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosTurmas.Location = new System.Drawing.Point(12, 116);
            this.dgvDadosTurmas.Name = "dgvDadosTurmas";
            this.dgvDadosTurmas.Size = new System.Drawing.Size(433, 224);
            this.dgvDadosTurmas.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ou";
            // 
            // lblCodTurma
            // 
            this.lblCodTurma.AutoSize = true;
            this.lblCodTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodTurma.Location = new System.Drawing.Point(58, 82);
            this.lblCodTurma.Name = "lblCodTurma";
            this.lblCodTurma.Size = new System.Drawing.Size(110, 16);
            this.lblCodTurma.TabIndex = 4;
            this.lblCodTurma.Text = "Código da turma:";
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(217, 81);
            this.txtCodTurma.Mask = "0000";
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(181, 20);
            this.txtCodTurma.TabIndex = 5;
            this.txtCodTurma.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.txtCodTurma_TextChanged);
            this.txtCodTurma.TextChanged += new System.EventHandler(this.txtCodTurma_TextChanged);
            // 
            // PesquisarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 352);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.lblCodTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDadosTurmas);
            this.Controls.Add(this.cmbCurso);
            this.Controls.Add(this.lblCursoTurma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarTurma";
            this.Text = "Pesquisar Turmas";
            this.Load += new System.EventHandler(this.PesquisarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosTurmas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCursoTurma;
        private System.Windows.Forms.ComboBox cmbCurso;
        private System.Windows.Forms.DataGridView dgvDadosTurmas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodTurma;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
    }
}