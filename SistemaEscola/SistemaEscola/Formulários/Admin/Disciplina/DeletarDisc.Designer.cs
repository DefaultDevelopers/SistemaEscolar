namespace SistemaEscola.Formulários.Admin.Disciplina
{
    partial class DeletarDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarDisc));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblCodDel = new System.Windows.Forms.Label();
            this.txtCodDel = new System.Windows.Forms.MaskedTextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 12);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(629, 229);
            this.dgvDados.TabIndex = 6;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(199, 303);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(97, 43);
            this.btnDeletar.TabIndex = 7;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(355, 303);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(97, 43);
            this.btnLimpar.TabIndex = 8;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // lblCodDel
            // 
            this.lblCodDel.AutoSize = true;
            this.lblCodDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodDel.Location = new System.Drawing.Point(166, 270);
            this.lblCodDel.Name = "lblCodDel";
            this.lblCodDel.Size = new System.Drawing.Size(234, 16);
            this.lblCodDel.TabIndex = 9;
            this.lblCodDel.Text = "Digite o código da discplina a deletar:";
            // 
            // txtCodDel
            // 
            this.txtCodDel.Location = new System.Drawing.Point(406, 269);
            this.txtCodDel.Mask = "000";
            this.txtCodDel.Name = "txtCodDel";
            this.txtCodDel.Size = new System.Drawing.Size(100, 20);
            this.txtCodDel.TabIndex = 10;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(537, 247);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(104, 23);
            this.btnAtualizar.TabIndex = 11;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // DeletarDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 352);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtCodDel);
            this.Controls.Add(this.lblCodDel);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.dgvDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarDisc";
            this.Text = "Deletar Discicplina";
            this.Load += new System.EventHandler(this.DeletarDisc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblCodDel;
        private System.Windows.Forms.MaskedTextBox txtCodDel;
        private System.Windows.Forms.Button btnAtualizar;
    }
}