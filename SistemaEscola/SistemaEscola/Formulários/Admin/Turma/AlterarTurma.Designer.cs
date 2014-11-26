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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.cmbCodCurso = new System.Windows.Forms.ComboBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblCodCurso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblTurno = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbTipo);
            this.groupBox2.Controls.Add(this.cmbTurno);
            this.groupBox2.Controls.Add(this.lblTipo);
            this.groupBox2.Controls.Add(this.lblTurno);
            this.groupBox2.Controls.Add(this.txtSala);
            this.groupBox2.Controls.Add(this.cmbCodCurso);
            this.groupBox2.Controls.Add(this.lblSala);
            this.groupBox2.Controls.Add(this.lblCodCurso);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 166);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados a alterar";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(80, 122);
            this.txtSala.MaxLength = 15;
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(285, 22);
            this.txtSala.TabIndex = 7;
            // 
            // cmbCodCurso
            // 
            this.cmbCodCurso.FormattingEnabled = true;
            this.cmbCodCurso.Location = new System.Drawing.Point(144, 32);
            this.cmbCodCurso.Name = "cmbCodCurso";
            this.cmbCodCurso.Size = new System.Drawing.Size(221, 24);
            this.cmbCodCurso.TabIndex = 5;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(31, 125);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(39, 16);
            this.lblSala.TabIndex = 4;
            this.lblSala.Text = "Sala:";
            // 
            // lblCodCurso
            // 
            this.lblCodCurso.AutoSize = true;
            this.lblCodCurso.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblCodCurso.Location = new System.Drawing.Point(30, 35);
            this.lblCodCurso.Name = "lblCodCurso";
            this.lblCodCurso.Size = new System.Drawing.Size(112, 16);
            this.lblCodCurso.TabIndex = 2;
            this.lblCodCurso.Text = "Código do Curso:";
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
            this.btnAlterar.Location = new System.Drawing.Point(81, 248);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 42);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(220, 247);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 42);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnPesq
            // 
            this.btnPesq.Location = new System.Drawing.Point(299, 25);
            this.btnPesq.Name = "btnPesq";
            this.btnPesq.Size = new System.Drawing.Size(84, 23);
            this.btnPesq.TabIndex = 10;
            this.btnPesq.Text = "Pesquisar";
            this.btnPesq.UseVisualStyleBackColor = true;
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
            this.cmbTipo.Location = new System.Drawing.Point(80, 92);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(285, 24);
            this.cmbTipo.TabIndex = 28;
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(80, 62);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(285, 24);
            this.cmbTurno.TabIndex = 27;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(36, 95);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(39, 16);
            this.lblTipo.TabIndex = 26;
            this.lblTipo.Text = "Tipo:";
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(36, 65);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(46, 16);
            this.lblTurno.TabIndex = 25;
            this.lblTurno.Text = "Turno:";
            // 
            // AlterarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 301);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarTurma";
            this.Text = "Alterar Dados de Turma";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblCodCurso;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.ComboBox cmbCodCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblTurno;
    }
}