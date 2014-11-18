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
            this.grpbTipo = new System.Windows.Forms.GroupBox();
            this.rbIntegrado = new System.Windows.Forms.RadioButton();
            this.rbConcomitante = new System.Windows.Forms.RadioButton();
            this.rbSubsequente = new System.Windows.Forms.RadioButton();
            this.grpbTurno = new System.Windows.Forms.GroupBox();
            this.rbNoturno = new System.Windows.Forms.RadioButton();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.cmbSerie = new System.Windows.Forms.ComboBox();
            this.cmbCodCurso = new System.Windows.Forms.ComboBox();
            this.lblSala = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.lblCodCurso = new System.Windows.Forms.Label();
            this.dgvDadosCursos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDuvida = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnPesq = new System.Windows.Forms.Button();
            this.grpbPesqCodTurma = new System.Windows.Forms.GroupBox();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2.SuspendLayout();
            this.grpbTipo.SuspendLayout();
            this.grpbTurno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCursos)).BeginInit();
            this.grpbPesqCodTurma.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grpbTipo);
            this.groupBox2.Controls.Add(this.grpbTurno);
            this.groupBox2.Controls.Add(this.txtSala);
            this.groupBox2.Controls.Add(this.cmbSerie);
            this.groupBox2.Controls.Add(this.cmbCodCurso);
            this.groupBox2.Controls.Add(this.lblSala);
            this.groupBox2.Controls.Add(this.lblSerie);
            this.groupBox2.Controls.Add(this.lblCodCurso);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 75);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 275);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados a alterar";
            // 
            // grpbTipo
            // 
            this.grpbTipo.Controls.Add(this.rbIntegrado);
            this.grpbTipo.Controls.Add(this.rbConcomitante);
            this.grpbTipo.Controls.Add(this.rbSubsequente);
            this.grpbTipo.Location = new System.Drawing.Point(12, 172);
            this.grpbTipo.Name = "grpbTipo";
            this.grpbTipo.Size = new System.Drawing.Size(130, 98);
            this.grpbTipo.TabIndex = 9;
            this.grpbTipo.TabStop = false;
            this.grpbTipo.Text = "Tipo";
            // 
            // rbIntegrado
            // 
            this.rbIntegrado.AutoSize = true;
            this.rbIntegrado.Location = new System.Drawing.Point(6, 21);
            this.rbIntegrado.Name = "rbIntegrado";
            this.rbIntegrado.Size = new System.Drawing.Size(83, 20);
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
            this.rbConcomitante.Size = new System.Drawing.Size(108, 20);
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
            this.rbSubsequente.Size = new System.Drawing.Size(106, 20);
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
            this.grpbTurno.Location = new System.Drawing.Point(12, 111);
            this.grpbTurno.Name = "grpbTurno";
            this.grpbTurno.Size = new System.Drawing.Size(253, 55);
            this.grpbTurno.TabIndex = 8;
            this.grpbTurno.TabStop = false;
            this.grpbTurno.Text = "Turno";
            // 
            // rbNoturno
            // 
            this.rbNoturno.AutoSize = true;
            this.rbNoturno.Location = new System.Drawing.Point(180, 21);
            this.rbNoturno.Name = "rbNoturno";
            this.rbNoturno.Size = new System.Drawing.Size(73, 20);
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
            this.rbVespertino.Size = new System.Drawing.Size(91, 20);
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
            this.rbMatutino.Size = new System.Drawing.Size(76, 20);
            this.rbMatutino.TabIndex = 0;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(80, 83);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(185, 22);
            this.txtSala.TabIndex = 7;
            // 
            // cmbSerie
            // 
            this.cmbSerie.FormattingEnabled = true;
            this.cmbSerie.Items.AddRange(new object[] {
            "Primeiro Ano",
            "Segundo Ano",
            "Terceiro Ano"});
            this.cmbSerie.Location = new System.Drawing.Point(80, 58);
            this.cmbSerie.Name = "cmbSerie";
            this.cmbSerie.Size = new System.Drawing.Size(185, 24);
            this.cmbSerie.TabIndex = 6;
            // 
            // cmbCodCurso
            // 
            this.cmbCodCurso.FormattingEnabled = true;
            this.cmbCodCurso.Location = new System.Drawing.Point(144, 32);
            this.cmbCodCurso.Name = "cmbCodCurso";
            this.cmbCodCurso.Size = new System.Drawing.Size(121, 24);
            this.cmbCodCurso.TabIndex = 5;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(31, 86);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(39, 16);
            this.lblSala.TabIndex = 4;
            this.lblSala.Text = "Sala:";
            // 
            // lblSerie
            // 
            this.lblSerie.AutoSize = true;
            this.lblSerie.Location = new System.Drawing.Point(31, 61);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(43, 16);
            this.lblSerie.TabIndex = 3;
            this.lblSerie.Text = "Série:";
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
            // dgvDadosCursos
            // 
            this.dgvDadosCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosCursos.Location = new System.Drawing.Point(299, 84);
            this.dgvDadosCursos.Name = "dgvDadosCursos";
            this.dgvDadosCursos.Size = new System.Drawing.Size(244, 204);
            this.dgvDadosCursos.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(299, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dados dos Cursos";
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
            // btnDuvida
            // 
            this.btnDuvida.Image = global::SistemaEscola.Properties.Resources.question1;
            this.btnDuvida.Location = new System.Drawing.Point(6, 25);
            this.btnDuvida.Name = "btnDuvida";
            this.btnDuvida.Size = new System.Drawing.Size(42, 28);
            this.btnDuvida.TabIndex = 6;
            this.btnDuvida.UseVisualStyleBackColor = true;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(299, 303);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(105, 42);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(438, 303);
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
            // grpbPesqCodTurma
            // 
            this.grpbPesqCodTurma.Controls.Add(this.btnDuvida);
            this.grpbPesqCodTurma.Location = new System.Drawing.Point(438, 12);
            this.grpbPesqCodTurma.Name = "grpbPesqCodTurma";
            this.grpbPesqCodTurma.Size = new System.Drawing.Size(104, 58);
            this.grpbPesqCodTurma.TabIndex = 11;
            this.grpbPesqCodTurma.TabStop = false;
            this.grpbPesqCodTurma.Text = "Pesquise códigos de turma aqui";
            // 
            // txtCodTurma
            // 
            this.txtCodTurma.Location = new System.Drawing.Point(143, 27);
            this.txtCodTurma.Mask = "0000";
            this.txtCodTurma.Name = "txtCodTurma";
            this.txtCodTurma.Size = new System.Drawing.Size(147, 20);
            this.txtCodTurma.TabIndex = 21;
            // 
            // AlterarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 360);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.btnPesq);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvDadosCursos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpbPesqCodTurma);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AlterarTurma";
            this.Text = "Alterar Dados de Turma";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.grpbTipo.ResumeLayout(false);
            this.grpbTipo.PerformLayout();
            this.grpbTurno.ResumeLayout(false);
            this.grpbTurno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCursos)).EndInit();
            this.grpbPesqCodTurma.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label lblCodCurso;
        private System.Windows.Forms.DataGridView dgvDadosCursos;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.ComboBox cmbSerie;
        private System.Windows.Forms.ComboBox cmbCodCurso;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDuvida;
        private System.Windows.Forms.GroupBox grpbTipo;
        private System.Windows.Forms.RadioButton rbIntegrado;
        private System.Windows.Forms.RadioButton rbConcomitante;
        private System.Windows.Forms.RadioButton rbSubsequente;
        private System.Windows.Forms.GroupBox grpbTurno;
        private System.Windows.Forms.RadioButton rbNoturno;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnPesq;
        private System.Windows.Forms.GroupBox grpbPesqCodTurma;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
    }
}