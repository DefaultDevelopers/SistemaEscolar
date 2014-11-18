namespace SistemaEscola.Formulários.Admin.Matricula
{
    partial class DeletarMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarMatricula));
            this.lblCod = new System.Windows.Forms.Label();
            this.btnPesquisarMatr = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeletarMatr = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 25);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(125, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Digite o código do aluno:";
            // 
            // btnPesquisarMatr
            // 
            this.btnPesquisarMatr.Location = new System.Drawing.Point(313, 20);
            this.btnPesquisarMatr.Name = "btnPesquisarMatr";
            this.btnPesquisarMatr.Size = new System.Drawing.Size(99, 23);
            this.btnPesquisarMatr.TabIndex = 2;
            this.btnPesquisarMatr.Text = "Pesquisar";
            this.btnPesquisarMatr.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(134, 22);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(173, 20);
            this.maskedTextBox1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(15, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 202);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnDeletarMatr
            // 
            this.btnDeletarMatr.Location = new System.Drawing.Point(61, 285);
            this.btnDeletarMatr.Name = "btnDeletarMatr";
            this.btnDeletarMatr.Size = new System.Drawing.Size(98, 37);
            this.btnDeletarMatr.TabIndex = 5;
            this.btnDeletarMatr.Text = "Deletar";
            this.btnDeletarMatr.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(271, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 37);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // DeletarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 334);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletarMatr);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnPesquisarMatr);
            this.Controls.Add(this.lblCod);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarMatricula";
            this.Text = "Deletar Matricula";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Button btnPesquisarMatr;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeletarMatr;
        private System.Windows.Forms.Button btnLimpar;
    }
}