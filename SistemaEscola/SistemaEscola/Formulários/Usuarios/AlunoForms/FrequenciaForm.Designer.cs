namespace SistemaEscola.Formulários.Usuarios.AlunoForms
{
    partial class FrequenciaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrequenciaForm));
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvFrequencia = new System.Windows.Forms.DataGridView();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAno = new System.Windows.Forms.TextBox();
            this.picBoxFrequencia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(342, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(129, 23);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvFrequencia
            // 
            this.dgvFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequencia.Location = new System.Drawing.Point(12, 86);
            this.dgvFrequencia.Name = "dgvFrequencia";
            this.dgvFrequencia.Size = new System.Drawing.Size(459, 219);
            this.dgvFrequencia.TabIndex = 13;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(89, 39);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(109, 16);
            this.lblAno.TabIndex = 12;
            this.lblAno.Text = "Selecione o ano:";
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(204, 38);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(132, 20);
            this.txtAno.TabIndex = 11;
            // 
            // picBoxFrequencia
            // 
            this.picBoxFrequencia.Image = global::SistemaEscola.Properties.Resources.frequencia;
            this.picBoxFrequencia.Location = new System.Drawing.Point(12, 12);
            this.picBoxFrequencia.Name = "picBoxFrequencia";
            this.picBoxFrequencia.Size = new System.Drawing.Size(71, 68);
            this.picBoxFrequencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFrequencia.TabIndex = 10;
            this.picBoxFrequencia.TabStop = false;
            // 
            // FrequenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 320);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvFrequencia);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.picBoxFrequencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrequenciaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequência";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrequencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvFrequencia;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.PictureBox picBoxFrequencia;
    }
}