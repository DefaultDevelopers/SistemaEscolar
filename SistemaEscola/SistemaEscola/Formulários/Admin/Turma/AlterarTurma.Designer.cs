namespace SistemaEscola.Formulários.Admin.Turma
{
    partial class AlterarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarTurma));
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.cmbCodCurso = new System.Windows.Forms.ComboBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblCodCurso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Código da Turma:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(81, 201);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 42);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(220, 200);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 42);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(299, 25);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(84, 23);
            this.btnPesq.TabIndex = 10;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
            this.btnPesq.Click += new System.EventHandler(this.btnPesq_Click);
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(143, 27);
            this.txtCodTurma.Mask = "0000";
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(147, 20);
            this.txtCodTurma.TabIndex = 21;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(86, 131);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(285, 21);
            this.cmbTipo.TabIndex = 36;
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(86, 101);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(285, 21);
            this.cmbTurno.TabIndex = 35;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(42, 134);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 34;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(42, 104);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 33;
            this.lblTurno.Text = "Turno:";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(86, 161);
            this.txtSala.MaxLength = 15;
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(285, 20);
            this.txtSala.TabIndex = 32;
            // 
            // cmbCodCurso
            // 
            this.cmbCodCurso.FormattingEnabled = true;
            this.cmbCodCurso.Location = new System.Drawing.Point(86, 71);
            this.cmbCodCurso.Name = "cmbCodCurso";
            this.cmbCodCurso.Size = new System.Drawing.Size(285, 21);
            this.cmbCodCurso.TabIndex = 31;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(37, 164);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 13);
            this.lblSala.TabIndex = 30;
            this.lblSala.Text = "Sala:";
            // 
            // lblCodCurso
            // 
            this.lblCodCurso.AutoSize = true;
            this.lblCodCurso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCodCurso.Location = new System.Drawing.Point(36, 74);
            this.lblCodCurso.Name = "lblCodCurso";
            this.lblCodCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCodCurso.TabIndex = 29;
            this.lblCodCurso.Text = "Curso:";
            // 
            // AlterarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 256);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.cmbCodCurso);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblCodCurso);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarTurma";
            this.Text = "Alterar Dados de Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.ComboBox cmbCodCurso;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblCodCurso;
    }
}