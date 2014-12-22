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
            this.dgvFrequencia = new System.Windows.Forms.DataGridView();
            this.picBoxFrequencia = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrequencia
            // 
            this.dgvFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequencia.Location = new System.Drawing.Point(89, 12);
            this.dgvFrequencia.Name = "dgvFrequencia";
            this.dgvFrequencia.Size = new System.Drawing.Size(459, 219);
            this.dgvFrequencia.TabIndex = 13;
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
            this.ClientSize = new System.Drawing.Size(560, 239);
            this.Controls.Add(this.picBoxFrequencia);
            this.Controls.Add(this.dgvFrequencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrequenciaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frequência";
            this.Load += new System.EventHandler(this.FrequenciaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrequencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrequencia;
        private System.Windows.Forms.PictureBox picBoxFrequencia;
    }
}