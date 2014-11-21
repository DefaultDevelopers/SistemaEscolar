namespace SistemaEscola.Formulários.Usuarios.Professor
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
            this.dgvBoletim = new System.Windows.Forms.DataGridView();
            this.picBoxBoletim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.cmbDisc = new System.Windows.Forms.ComboBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBoletim)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBoletim
            // 
            this.dgvBoletim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletim.Location = new System.Drawing.Point(14, 86);
            this.dgvBoletim.Name = "dgvBoletim";
            this.dgvBoletim.Size = new System.Drawing.Size(459, 219);
            this.dgvBoletim.TabIndex = 8;
            // 
            // picBoxBoletim
            // 
            this.picBoxBoletim.Image = global::SistemaEscola.Properties.Resources.boletim;
            this.picBoxBoletim.Location = new System.Drawing.Point(14, 12);
            this.picBoxBoletim.Name = "picBoxBoletim";
            this.picBoxBoletim.Size = new System.Drawing.Size(71, 68);
            this.picBoxBoletim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBoletim.TabIndex = 5;
            this.picBoxBoletim.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione a turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione a disciplina:";
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(232, 23);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(157, 21);
            this.cmbTurma.TabIndex = 11;
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.Location = new System.Drawing.Point(256, 51);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(133, 21);
            this.cmbDisc.TabIndex = 12;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(398, 49);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 13;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(338, 314);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(137, 33);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Inserir Frequência";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // Boletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 357);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBoletim);
            this.Controls.Add(this.picBoxBoletim);
            this.Name = "Boletim";
            this.Text = "Boletim";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBoletim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBoletim;
        private System.Windows.Forms.PictureBox picBoxBoletim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.ComboBox cmbDisc;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnInserir;
    }
}