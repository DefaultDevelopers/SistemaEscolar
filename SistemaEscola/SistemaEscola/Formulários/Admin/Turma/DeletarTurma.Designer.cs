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
            this.lblCod = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(266, 266);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 37);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnDeletarMatr
            // 
            this.btnDeletarMatr.Location = new System.Drawing.Point(56, 266);
            this.btnDeletarMatr.Name = "btnDeletarMatr";
            this.btnDeletarMatr.Size = new System.Drawing.Size(98, 37);
            this.btnDeletarMatr.TabIndex = 11;
            this.btnDeletarMatr.Text = "Deletar";
            this.btnDeletarMatr.UseVisualStyleBackColor = true;
            this.btnDeletarMatr.Click += new System.EventHandler(this.btnDeletarMatr_Click);
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(397, 202);
            this.dgvDados.TabIndex = 10;
            // 
            // lblCod
            // 
            this.lblCod.Location = new System.Drawing.Point(0, 0);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(100, 23);
            this.lblCod.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(86, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Digite o código da turma a deletar:";
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(296, 240);
            this.txtCodTurma.Mask = "0000";
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(38, 20);
            this.txtCodTurma.TabIndex = 15;
            // 
            // DeletarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 318);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletarMatr);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.lblCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarTurma";
            this.Text = "Deletar Turma";
            this.Load += new System.EventHandler(this.DeletarTurma_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnDeletarMatr;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
    }
}