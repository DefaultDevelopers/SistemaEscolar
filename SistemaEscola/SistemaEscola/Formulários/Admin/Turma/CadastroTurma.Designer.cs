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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.grpbTipo = new System.Windows.Forms.GroupBox();
            this.rbIntegrado = new System.Windows.Forms.RadioButton();
            this.rbConcomitante = new System.Windows.Forms.RadioButton();
            this.rbSubsequente = new System.Windows.Forms.RadioButton();
            this.grpbTurno = new System.Windows.Forms.GroupBox();
            this.rbNoturno = new System.Windows.Forms.RadioButton();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDadosCursos = new System.Windows.Forms.DataGridView();
            this.cmbCodCurso = new System.Windows.Forms.ComboBox();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
            this.grpbTipo.SuspendLayout();
            this.grpbTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCursos)).BeginInit();
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código da Turma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Código do Curso:";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(72, 130);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(185, 20);
            this.txtSala.TabIndex = 11;
            // 
            // cmbSerie
            // 
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Items.AddRange(new object[] {
            "Primeiro Ano",
            "Segundo Ano",
            "Terceiro Ano"});
            this.cmbSerie.Location = new System.Drawing.Point(72, 106);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(185, 21);
            this.cmbSerie.TabIndex = 10;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(21, 133);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 13);
            this.lblSala.TabIndex = 9;
            this.lblSala.Text = "Sala:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(21, 109);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(34, 13);
            this.lblSerie.TabIndex = 8;
            this.lblSerie.Text = "Série:";
            // 
            // grpbTipo
            // 
            this.grpbTipo.Controls.Add(this.rbIntegrado);
            this.grpbTipo.Controls.Add(this.rbConcomitante);
            this.grpbTipo.Controls.Add(this.rbSubsequente);
            this.grpbTipo.Location = new System.Drawing.Point(24, 217);
            this.grpbTipo.Name = "grpbTipo";
            this.grpbTipo.Size = new System.Drawing.Size(130, 98);
            this.grpbTipo.TabIndex = 13;
            this.grpbTipo.TabStop = false;
            this.grpbTipo.Text = "Tipo";
            // 
            // rbIntegrado
            // 
            this.rbIntegrado.AutoSize = true;
            this.rbIntegrado.Location = new System.Drawing.Point(6, 21);
            this.rbIntegrado.Name = "rbIntegrado";
            this.rbIntegrado.Size = new System.Drawing.Size(70, 17);
            this.rbIntegrado.TabIndex = 3;
            this.rbIntegrado.TabStop = true;
            this.rbIntegrado.Text = "Integrado";
            this.rbIntegrado.UseVisualStyleBackColor = true;
            // 
            // rbConcomitante
            // 
            this.rbConcomitante.AutoSize = true;
            this.rbConcomitante.Location = new System.Drawing.Point(6, 47);
            this.rbConcomitante.Name = "rbConcomitante";
            this.rbConcomitante.Size = new System.Drawing.Size(90, 17);
            this.rbConcomitante.TabIndex = 4;
            this.rbConcomitante.TabStop = true;
            this.rbConcomitante.Text = "Concomitante";
            this.rbConcomitante.UseVisualStyleBackColor = true;
            // 
            // rbSubsequente
            // 
            this.rbSubsequente.AutoSize = true;
            this.rbSubsequente.Location = new System.Drawing.Point(6, 71);
            this.rbSubsequente.Name = "rbSubsequente";
            this.rbSubsequente.Size = new System.Drawing.Size(88, 17);
            this.rbSubsequente.TabIndex = 5;
            this.rbSubsequente.TabStop = true;
            this.rbSubsequente.Text = "Subsequente";
            this.rbSubsequente.UseVisualStyleBackColor = true;
            // 
            // grpbTurno
            // 
            this.grpbTurno.Controls.Add(this.rbNoturno);
            this.grpbTurno.Controls.Add(this.rbVespertino);
            this.grpbTurno.Controls.Add(this.rbMatutino);
            this.grpbTurno.Location = new System.Drawing.Point(24, 156);
            this.grpbTurno.Name = "grpbTurno";
            this.grpbTurno.Size = new System.Drawing.Size(253, 55);
            this.grpbTurno.TabIndex = 12;
            this.grpbTurno.TabStop = false;
            this.grpbTurno.Text = "Turno";
            // 
            // rbNoturno
            // 
            this.rbNoturno.AutoSize = true;
            this.rbNoturno.Location = new System.Drawing.Point(180, 21);
            this.rbNoturno.Name = "rbNoturno";
            this.rbNoturno.Size = new System.Drawing.Size(63, 17);
            this.rbNoturno.TabIndex = 2;
            this.rbNoturno.TabStop = true;
            this.rbNoturno.Text = "Noturno";
            this.rbNoturno.UseVisualStyleBackColor = true;
            // 
            // rbVespertino
            // 
            this.rbVespertino.AutoSize = true;
            this.rbVespertino.Location = new System.Drawing.Point(86, 21);
            this.rbVespertino.Name = "rbVespertino";
            this.rbVespertino.Size = new System.Drawing.Size(75, 17);
            this.rbVespertino.TabIndex = 1;
            this.rbVespertino.TabStop = true;
            this.rbVespertino.Text = "Vespertino";
            this.rbVespertino.UseVisualStyleBackColor = true;
            // 
            // rbMatutino
            // 
            this.rbMatutino.AutoSize = true;
            this.rbMatutino.Location = new System.Drawing.Point(6, 21);
            this.rbMatutino.Name = "rbMatutino";
            this.rbMatutino.Size = new System.Drawing.Size(66, 17);
            this.rbMatutino.TabIndex = 0;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(182, 227);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 38);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(182, 276);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 40);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Dados dos Cursos";
            // 
            // dgvDadosCursos
            // 
            this.dgvDadosCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosCursos.Location = new System.Drawing.Point(283, 51);
            this.dgvDadosCursos.Name = "dgvDadosCursos";
            this.dgvDadosCursos.Size = new System.Drawing.Size(244, 264);
            this.dgvDadosCursos.TabIndex = 16;
            // 
            // cmbCodCurso
            // 
            this.cmbCodCurso.FormattingEnabled = true;
            this.cmbCodCurso.Location = new System.Drawing.Point(110, 81);
            this.cmbCodCurso.Name = "cmbCodCurso";
            this.cmbCodCurso.Size = new System.Drawing.Size(147, 21);
            this.cmbCodCurso.TabIndex = 19;
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(110, 56);
            this.txtCodTurma.Mask = "0000";
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(147, 20);
            this.txtCodTurma.TabIndex = 20;
            // 
            // CadastroTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 334);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.cmbCodCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDadosCursos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.grpbTipo);
            this.Controls.Add(this.grpbTurno);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.cmbSerie);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.lblSerie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroTurma";
            this.Text = "Cadastro de Turmas";
            this.grpbTipo.ResumeLayout(false);
            this.grpbTipo.PerformLayout();
            this.grpbTurno.ResumeLayout(false);
            this.grpbTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.GroupBox grpbTipo;
        private System.Windows.Forms.RadioButton rbIntegrado;
        private System.Windows.Forms.RadioButton rbConcomitante;
        private System.Windows.Forms.RadioButton rbSubsequente;
        private System.Windows.Forms.GroupBox grpbTurno;
        private System.Windows.Forms.RadioButton rbNoturno;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDadosCursos;
        private System.Windows.Forms.ComboBox cmbCodCurso;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
    }
}