namespace SistemaEscola.Formulários.Usuarios.Professor
{
    partial class InserirFrequencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InserirFrequencia));
            this.dgvFrequencia = new System.Windows.Forms.DataGridView();
            this.picBoxFrequencia = new System.Windows.Forms.PictureBox();
            this.lblTurma = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.dtpAula = new System.Windows.Forms.DateTimePicker();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvCod = new System.Windows.Forms.DataGridView();
            this.lblDisc = new System.Windows.Forms.Label();
            this.cmbDisc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCod)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrequencia
            // 
            this.dgvFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequencia.Location = new System.Drawing.Point(262, 105);
            this.dgvFrequencia.Name = "dgvFrequencia";
            this.dgvFrequencia.RowHeadersVisible = false;
            this.dgvFrequencia.Size = new System.Drawing.Size(103, 219);
            this.dgvFrequencia.TabIndex = 13;
            // 
            // picBoxFrequencia
            // 
            this.picBoxFrequencia.Image = global::SistemaEscola.Properties.Resources.frequencia;
            this.picBoxFrequencia.Location = new System.Drawing.Point(16, 13);
            this.picBoxFrequencia.Name = "picBoxFrequencia";
            this.picBoxFrequencia.Size = new System.Drawing.Size(71, 68);
            this.picBoxFrequencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxFrequencia.TabIndex = 10;
            this.picBoxFrequencia.TabStop = false;
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.Location = new System.Drawing.Point(90, 28);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(119, 16);
            this.lblTurma.TabIndex = 14;
            this.lblTurma.Text = "Selecione a turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Aula ministrada em:";
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(205, 28);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(159, 21);
            this.cmbTurma.TabIndex = 16;
            // 
            // dtpAula
            // 
            this.dtpAula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAula.Location = new System.Drawing.Point(170, 335);
            this.dtpAula.Name = "dtpAula";
            this.dtpAula.Size = new System.Drawing.Size(84, 20);
            this.dtpAula.TabIndex = 17;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(267, 335);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(99, 37);
            this.btnInserir.TabIndex = 19;
            this.btnInserir.Text = "Inserir Frequência";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(268, 76);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "Pesquisa";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // dgvCod
            // 
            this.dgvCod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCod.Location = new System.Drawing.Point(57, 105);
            this.dgvCod.Name = "dgvCod";
            this.dgvCod.RowHeadersVisible = false;
            this.dgvCod.Size = new System.Drawing.Size(199, 219);
            this.dgvCod.TabIndex = 21;
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.Location = new System.Drawing.Point(90, 52);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(143, 16);
            this.lblDisc.TabIndex = 22;
            this.lblDisc.Text = "Selecione a disciplina:";
            // 
            // cmbDisc
            // 
            this.cmbDisc.FormattingEnabled = true;
            this.cmbDisc.Location = new System.Drawing.Point(232, 51);
            this.cmbDisc.Name = "cmbDisc";
            this.cmbDisc.Size = new System.Drawing.Size(132, 21);
            this.cmbDisc.TabIndex = 23;
            // 
            // InserirFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 375);
            this.Controls.Add(this.cmbDisc);
            this.Controls.Add(this.lblDisc);
            this.Controls.Add(this.dgvCod);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dtpAula);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.dgvFrequencia);
            this.Controls.Add(this.picBoxFrequencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirFrequencia";
            this.Text = "Frequência";
            this.Load += new System.EventHandler(this.InserirFrequencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrequencia;
        private System.Windows.Forms.PictureBox picBoxFrequencia;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.DateTimePicker dtpAula;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dgvCod;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.ComboBox cmbDisc;
    }
}