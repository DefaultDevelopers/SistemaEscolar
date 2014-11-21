namespace SistemaEscola.Formulários.Usuarios
{
    partial class Boletim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Boletim));
            this.txtAno = new System.Windows.Forms.TextBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.dgvBoletim = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.picBoxBoletim = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBoletim)).BeginInit();
            this.SuspendLayout();
            // 
            // txtAno
            // 
            this.txtAno.Location = new System.Drawing.Point(204, 38);
            this.txtAno.MaxLength = 4;
            this.txtAno.Name = "txtAno";
            this.txtAno.Size = new System.Drawing.Size(132, 20);
            this.txtAno.TabIndex = 1;
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(89, 39);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(109, 16);
            this.lblAno.TabIndex = 2;
            this.lblAno.Text = "Selecione o ano:";
            // 
            // dgvBoletim
            // 
            this.dgvBoletim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletim.Location = new System.Drawing.Point(12, 86);
            this.dgvBoletim.Name = "dgvBoletim";
            this.dgvBoletim.Size = new System.Drawing.Size(459, 219);
            this.dgvBoletim.TabIndex = 3;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(342, 36);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(129, 23);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // picBoxBoletim
            // 
            this.picBoxBoletim.Image = global::SistemaEscola.Properties.Resources.boletim;
            this.picBoxBoletim.Location = new System.Drawing.Point(12, 12);
            this.picBoxBoletim.Name = "picBoxBoletim";
            this.picBoxBoletim.Size = new System.Drawing.Size(71, 68);
            this.picBoxBoletim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBoletim.TabIndex = 0;
            this.picBoxBoletim.TabStop = false;
            // 
            // Boletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 317);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.dgvBoletim);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.txtAno);
            this.Controls.Add(this.picBoxBoletim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Boletim";
            this.Text = "Boletim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBoletim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBoletim;
        private System.Windows.Forms.TextBox txtAno;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.DataGridView dgvBoletim;
        private System.Windows.Forms.Button btnPesquisar;
    }
}