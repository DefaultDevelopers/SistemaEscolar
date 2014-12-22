namespace SistemaEscola.Formulários.Usuarios.Professor
{
    partial class InserirBoletim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirBoletim));
            this.picBoxBoletim = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.cmbDisc = new System.Windows.Forms.ComboBox();
            this.btnTurma = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.dgvBoletim = new System.Windows.Forms.DataGridView();
            this.dgvCod = new System.Windows.Forms.DataGridView();
            this.btnDisc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBoletim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCod)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(103, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Selecione a turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Selecione a disciplina:";
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(228, 31);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(157, 21);
            this.cmbTurma.TabIndex = 11;
            // 
            // cmbDisc
            // 
            this.cmbDisc.Enabled = false;
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.Location = new System.Drawing.Point(252, 60);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(133, 21);
            this.cmbDisc.TabIndex = 12;
            // 
            // btnTurma
            // 
            this.btnTurma.Location = new System.Drawing.Point(391, 29);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(110, 23);
            this.btnTurma.TabIndex = 13;
            this.btnTurma.Text = "Pesquisar Turma";
            this.btnTurma.UseVisualStyleBackColor = true;
            this.btnTurma.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(523, 311);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(137, 33);
            this.btnInserir.TabIndex = 14;
            this.btnInserir.Text = "Inserir Boletim";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dgvBoletim
            // 
            this.dgvBoletim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBoletim.Enabled = false;
            this.dgvBoletim.Location = new System.Drawing.Point(218, 86);
            this.dgvBoletim.Name = "dgvBoletim";
            this.dgvBoletim.RowHeadersVisible = false;
            this.dgvBoletim.Size = new System.Drawing.Size(442, 219);
            this.dgvBoletim.TabIndex = 15;
            // 
            // dgvCod
            // 
            this.dgvCod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCod.Location = new System.Drawing.Point(12, 86);
            this.dgvCod.Name = "dgvCod";
            this.dgvCod.RowHeadersVisible = false;
            this.dgvCod.Size = new System.Drawing.Size(200, 219);
            this.dgvCod.TabIndex = 16;
            // 
            // btnDisc
            // 
            this.btnDisc.Enabled = false;
            this.btnDisc.Location = new System.Drawing.Point(391, 58);
            this.btnDisc.Name = "btnDisc";
            this.btnDisc.Size = new System.Drawing.Size(110, 23);
            this.btnDisc.TabIndex = 17;
            this.btnDisc.Text = "Pesquisar Disciplina";
            this.btnDisc.UseVisualStyleBackColor = true;
            this.btnDisc.Click += new System.EventHandler(this.btnDisc_Click);
            // 
            // InserirBoletim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 349);
            this.Controls.Add(this.btnDisc);
            this.Controls.Add(this.dgvCod);
            this.Controls.Add(this.dgvBoletim);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnTurma);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picBoxBoletim);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirBoletim";
            this.Text = "Boletim";
            this.Load += new System.EventHandler(this.Boletim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBoletim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBoletim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxBoletim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.ComboBox cmbDisc;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.DataGridView dgvBoletim;
        private System.Windows.Forms.DataGridView dgvCod;
        private System.Windows.Forms.Button btnDisc;
    }
}