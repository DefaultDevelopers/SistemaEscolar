namespace SistemaEscola.Formulários.Admin.Turma
{
    partial class DeletarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarTurma));
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnDeletarMatr = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisarTurma = new System.Windows.Forms.Button();
            this.lblCod = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(268, 287);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 37);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnDeletarMatr
            // 
            this.btnDeletarMatr.Location = new System.Drawing.Point(58, 287);
            this.btnDeletarMatr.Name = "btnDeletarMatr";
            this.btnDeletarMatr.Size = new System.Drawing.Size(98, 37);
            this.btnDeletarMatr.TabIndex = 11;
            this.btnDeletarMatr.Text = "Deletar";
            this.btnDeletarMatr.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 68);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(397, 202);
            this.dgvDados.TabIndex = 10;
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(140, 23);
            this.txtCodTurma.Mask = "0000";
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(164, 20);
            this.txtCodTurma.TabIndex = 9;
            // 
            // btnPesquisarTurma
            // 
            this.btnPesquisarTurma.Location = new System.Drawing.Point(310, 21);
            this.btnPesquisarTurma.Name = "btnPesquisarTurma";
            this.btnPesquisarTurma.Size = new System.Drawing.Size(99, 23);
            this.btnPesquisarTurma.TabIndex = 8;
            this.btnPesquisarTurma.Text = "Pesquisar";
            this.btnPesquisarTurma.UseVisualStyleBackColor = true;
            // 
            // lblCod
            // 
            this.lblCod.Location = new System.Drawing.Point(0, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(100, 23);
            this.lblCod.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Digite o código da turma:";
            // 
            // DeletarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 340);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletarMatr);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.btnPesquisarTurma);
            this.Controls.Add(this.lblCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarTurma";
            this.Text = "Deletar Turma";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDeletarMatr;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
        private System.Windows.Forms.Button btnPesquisarTurma;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label1;
    }
}