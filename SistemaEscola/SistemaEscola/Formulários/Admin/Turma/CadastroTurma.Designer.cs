namespace SistemaEscola.Formulários.Admin.Turma
{
    partial class CadastroTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroTurma));
            this.label1 = new System.Windows.Forms.Label();
            this.lblCodTurma = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.cmbCodCurso = new System.Windows.Forms.ComboBox();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
            this.lblTurno = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite os dados da turma:";
            // 
            // lblCodTurma
            // 
            this.lblCodTurma.AutoSize = true;
            this.lblCodTurma.Location = new System.Drawing.Point(21, 59);
            this.lblCodTurma.Name = "lblCodTurma";
            this.lblCodTurma.Size = new System.Drawing.Size(91, 13);
            this.lblCodTurma.TabIndex = 1;
            this.lblCodTurma.Text = "Código da Turma:";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(21, 84);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Curso:";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(72, 159);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(219, 20);
            this.txtSala.TabIndex = 11;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(21, 162);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 13);
            this.lblSala.TabIndex = 9;
            this.lblSala.Text = "Sala:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(46, 195);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 44);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(166, 195);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 44);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // cmbCodCurso
            // 
            this.cmbCodCurso.FormattingEnabled = true;
            this.cmbCodCurso.Location = new System.Drawing.Point(110, 81);
            this.cmbCodCurso.Name = "cmbCodCurso";
            this.cmbCodCurso.Size = new System.Drawing.Size(181, 21);
            this.cmbCodCurso.TabIndex = 19;
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(110, 56);
            this.txtCodTurma.Mask = "000";
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(181, 20);
            this.txtCodTurma.TabIndex = 20;
            // 
            // lblTurno
            // 
            this.lblTurno.AutoSize = true;
            this.lblTurno.Location = new System.Drawing.Point(21, 110);
            this.lblTurno.Name = "lblTurno";
            this.lblTurno.Size = new System.Drawing.Size(38, 13);
            this.lblTurno.TabIndex = 21;
            this.lblTurno.Text = "Turno:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(21, 135);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 22;
            this.lblTipo.Text = "Tipo:";
            // 
            // cmbTurno
            // 
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(65, 107);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(226, 21);
            this.cmbTurno.TabIndex = 23;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Location = new System.Drawing.Point(65, 132);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(226, 21);
            this.cmbTipo.TabIndex = 24;
            // 
            // CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 252);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.cmbTurno);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblTurno);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.cmbCodCurso);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.lblCodTurma);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroTurma";
            this.Text = "Cadastro de Turmas";
            this.Load += new System.EventHandler(this.CadastroTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCodTurma;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ComboBox cmbCodCurso;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
        private System.Windows.Forms.Label lblTurno;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}