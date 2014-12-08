namespace SistemaEscola.Formulários.Admin.Matricula
{
    partial class PesquisarMatricula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarMatricula));
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.lblPorCod = new System.Windows.Forms.Label();
            this.txtPorCod = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisaGeral = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(12, 56);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(584, 249);
            this.dgvDados.TabIndex = 3;
            // 
            // lblPorCod
            // 
            this.lblPorCod.AutoSize = true;
            this.lblPorCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPorCod.Location = new System.Drawing.Point(12, 18);
            this.lblPorCod.Name = "lblPorCod";
            this.lblPorCod.Size = new System.Drawing.Size(77, 16);
            this.lblPorCod.TabIndex = 4;
            this.lblPorCod.Text = "Por código:";
            // 
            // txtPorCod
            // 
            this.txtPorCod.Location = new System.Drawing.Point(95, 17);
            this.txtPorCod.Mask = "00000000000";
            this.txtPorCod.Name = "txtPorCod";
            this.txtPorCod.Size = new System.Drawing.Size(87, 20);
            this.txtPorCod.TabIndex = 5;
            this.txtPorCod.TextChanged += new System.EventHandler(this.txtPorCod_TextChanged);
            // 
            // btnPesquisaGeral
            // 
            this.btnPesquisaGeral.Location = new System.Drawing.Point(494, 27);
            this.btnPesquisaGeral.Name = "btnPesquisaGeral";
            this.btnPesquisaGeral.Size = new System.Drawing.Size(102, 23);
            this.btnPesquisaGeral.TabIndex = 6;
            this.btnPesquisaGeral.Text = "Pesquisa Geral";
            this.btnPesquisaGeral.UseVisualStyleBackColor = true;
            this.btnPesquisaGeral.Click += new System.EventHandler(this.btnPesquisaGeral_Click);
            // 
            // PesquisarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 318);
            this.Controls.Add(this.btnPesquisaGeral);
            this.Controls.Add(this.txtPorCod);
            this.Controls.Add(this.lblPorCod);
            this.Controls.Add(this.dgvDados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarMatricula";
            this.Text = "Pesquisar Matrícula";
            this.Load += new System.EventHandler(this.PesquisarMatricula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label lblPorCod;
        private System.Windows.Forms.MaskedTextBox txtPorCod;
        private System.Windows.Forms.Button btnPesquisaGeral;
    }
}