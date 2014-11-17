namespace SistemaEscola.Formulários.Admin.Matricula
{
    partial class AlterarMatricula
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
            this.lblCod = new System.Windows.Forms.Label();
            this.grpbAlterar = new System.Windows.Forms.GroupBox();
            this.grpbTurno = new System.Windows.Forms.GroupBox();
            this.rbMatutino = new System.Windows.Forms.RadioButton();
            this.rbVespertino = new System.Windows.Forms.RadioButton();
            this.rbNoturno = new System.Windows.Forms.RadioButton();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpbAlterar.SuspendLayout();
            this.grpbTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(12, 20);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(88, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Código do Aluno:";
            // 
            // grpbAlterar
            // 
            this.grpbAlterar.Controls.Add(this.comboBox1);
            this.grpbAlterar.Controls.Add(this.lblTipo);
            this.grpbAlterar.Controls.Add(this.lblCurso);
            this.grpbAlterar.Controls.Add(this.cmbTipo);
            this.grpbAlterar.Controls.Add(this.grpbTurno);
            this.grpbAlterar.Location = new System.Drawing.Point(15, 50);
            this.grpbAlterar.Name = "grpbAlterar";
            this.grpbAlterar.Size = new System.Drawing.Size(342, 154);
            this.grpbAlterar.TabIndex = 1;
            this.grpbAlterar.TabStop = false;
            this.grpbAlterar.Text = "Dados a alterar";
            // 
            // grpbTurno
            // 
            this.grpbTurno.Controls.Add(this.rbNoturno);
            this.grpbTurno.Controls.Add(this.rbVespertino);
            this.grpbTurno.Controls.Add(this.rbMatutino);
            this.grpbTurno.Location = new System.Drawing.Point(6, 19);
            this.grpbTurno.Name = "grpbTurno";
            this.grpbTurno.Size = new System.Drawing.Size(327, 48);
            this.grpbTurno.TabIndex = 0;
            this.grpbTurno.TabStop = false;
            this.grpbTurno.Text = "Turno";
            // 
            // rbMatutino
            // 
            this.rbMatutino.AutoSize = true;
            this.rbMatutino.Location = new System.Drawing.Point(6, 19);
            this.rbMatutino.Name = "rbMatutino";
            this.rbMatutino.Size = new System.Drawing.Size(66, 17);
            this.rbMatutino.TabIndex = 0;
            this.rbMatutino.TabStop = true;
            this.rbMatutino.Text = "Matutino";
            this.rbMatutino.UseVisualStyleBackColor = true;
            // 
            // rbVespertino
            // 
            this.rbVespertino.AutoSize = true;
            this.rbVespertino.Location = new System.Drawing.Point(134, 19);
            this.rbVespertino.Name = "rbVespertino";
            this.rbVespertino.Size = new System.Drawing.Size(75, 17);
            this.rbVespertino.TabIndex = 1;
            this.rbVespertino.TabStop = true;
            this.rbVespertino.Text = "Vespertino";
            this.rbVespertino.UseVisualStyleBackColor = true;
            // 
            // rbNoturno
            // 
            this.rbNoturno.AutoSize = true;
            this.rbNoturno.Location = new System.Drawing.Point(260, 19);
            this.rbNoturno.Name = "rbNoturno";
            this.rbNoturno.Size = new System.Drawing.Size(63, 17);
            this.rbNoturno.TabIndex = 2;
            this.rbNoturno.TabStop = true;
            this.rbNoturno.Text = "Noturno";
            this.rbNoturno.UseVisualStyleBackColor = true;
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Integrado",
            "Concomitante",
            "Subsequente"});
            this.cmbTipo.Location = new System.Drawing.Point(43, 85);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(286, 21);
            this.cmbTipo.TabIndex = 2;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(9, 121);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(37, 13);
            this.lblCurso.TabIndex = 4;
            this.lblCurso.Text = "Curso:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(9, 88);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(52, 118);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(277, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(58, 222);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(88, 39);
            this.btnAlterar.TabIndex = 2;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(218, 222);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 39);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(106, 17);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(106, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(218, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AlterarMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 275);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.grpbAlterar);
            this.Controls.Add(this.lblCod);
            this.Name = "AlterarMatricula";
            this.Text = "Alterar Matrícula";
            this.grpbAlterar.ResumeLayout(false);
            this.grpbAlterar.PerformLayout();
            this.grpbTurno.ResumeLayout(false);
            this.grpbTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.GroupBox grpbAlterar;
        private System.Windows.Forms.GroupBox grpbTurno;
        private System.Windows.Forms.RadioButton rbNoturno;
        private System.Windows.Forms.RadioButton rbVespertino;
        private System.Windows.Forms.RadioButton rbMatutino;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button1;
    }
}