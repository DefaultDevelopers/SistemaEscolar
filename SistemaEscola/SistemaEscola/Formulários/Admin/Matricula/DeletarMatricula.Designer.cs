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
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnDeletarMatr = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblConfirme = new System.Windows.Forms.Label();
            this.txtIDMatr = new System.Windows.Forms.MaskedTextBox();
            this.lblCodDel = new System.Windows.Forms.Label();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(15, 28);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(611, 208);
            this.dgvDados.TabIndex = 4;
            // 
            // btnDeletarMatr
            // 
            this.btnDeletarMatr.Location = new System.Drawing.Point(165, 293);
            this.btnDeletarMatr.Name = "btnDeletarMatr";
            this.btnDeletarMatr.Size = new System.Drawing.Size(98, 37);
            this.btnDeletarMatr.TabIndex = 5;
            this.btnDeletarMatr.Text = "Deletar";
            this.btnDeletarMatr.UseVisualStyleBackColor = true;
            this.btnDeletarMatr.Click += new System.EventHandler(this.btnDeletarMatr_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(375, 293);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(98, 37);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblConfirme
            // 
            this.lblConfirme.AutoSize = true;
            this.lblConfirme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirme.Location = new System.Drawing.Point(12, 9);
            this.lblConfirme.Name = "lblConfirme";
            this.lblConfirme.Size = new System.Drawing.Size(121, 16);
            this.lblConfirme.TabIndex = 7;
            this.lblConfirme.Text = "Confirme os dados";
            // 
            // txtIDMatr
            // 
            this.txtIDMatr.Location = new System.Drawing.Point(350, 267);
            this.txtIDMatr.Mask = "00000000000";
            this.txtIDMatr.Name = "txtIDMatr";
            this.txtIDMatr.Size = new System.Drawing.Size(173, 20);
            this.txtIDMatr.TabIndex = 9;
            // 
            // lblCodDel
            // 
            this.lblCodDel.AutoSize = true;
            this.lblCodDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodDel.Location = new System.Drawing.Point(116, 268);
            this.lblCodDel.Name = "lblCodDel";
            this.lblCodDel.Size = new System.Drawing.Size(205, 16);
            this.lblCodDel.TabIndex = 8;
            this.lblCodDel.Text = "Digite a ID da matrícula a deletar:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(530, 242);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(96, 23);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // DeletarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 338);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtIDMatr);
            this.Controls.Add(this.lblCodDel);
            this.Controls.Add(this.lblConfirme);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletarMatr);
            this.Controls.Add(this.dgvDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarMatricula";
            this.Text = "Deletar Matricula";
            this.Load += new System.EventHandler(this.DeletarMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnDeletarMatr;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblConfirme;
        private System.Windows.Forms.MaskedTextBox txtIDMatr;
        private System.Windows.Forms.Label lblCodDel;
        private System.Windows.Forms.Button btnAtualizar;
    }
}