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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbTurma = new System.Windows.Forms.ComboBox();
            this.dtpAula = new System.Windows.Forms.DateTimePicker();
            this.btnInserir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrequencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvFrequencia
            // 
            this.dgvFrequencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFrequencia.Location = new System.Drawing.Point(16, 87);
            this.dgvFrequencia.Name = "dgvFrequencia";
            this.dgvFrequencia.Size = new System.Drawing.Size(559, 219);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Selecione a turma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Aula ministrada em:";
            // 
            // cmbTurma
            // 
            this.cmbTurma.FormattingEnabled = true;
            this.cmbTurma.Location = new System.Drawing.Point(276, 12);
            this.cmbTurma.Name = "cmbTurma";
            this.cmbTurma.Size = new System.Drawing.Size(164, 21);
            this.cmbTurma.TabIndex = 16;
            // 
            // dtpAula
            // 
            this.dtpAula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAula.Location = new System.Drawing.Point(276, 39);
            this.dtpAula.Name = "dtpAula";
            this.dtpAula.Size = new System.Drawing.Size(164, 20);
            this.dtpAula.TabIndex = 17;
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(476, 312);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(99, 37);
            this.btnInserir.TabIndex = 19;
            this.btnInserir.Text = "Inserir Frequência";
            this.btnInserir.UseVisualStyleBackColor = true;
            // 
            // InserirFrequencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 359);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.dtpAula);
            this.Controls.Add(this.cmbTurma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvFrequencia);
            this.Controls.Add(this.picBoxFrequencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InserirFrequencia";
            this.Text = "Frequência";
            this.Load += new System.EventHandler(this.InserirFrequencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFrequencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxFrequencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvFrequencia;
        private System.Windows.Forms.PictureBox picBoxFrequencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbTurma;
        private System.Windows.Forms.DateTimePicker dtpAula;
        private System.Windows.Forms.Button btnInserir;
    }
}