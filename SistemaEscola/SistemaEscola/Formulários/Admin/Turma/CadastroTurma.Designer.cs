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
            this.lblSala = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDadosCursos = new System.Windows.Forms.DataGridView();
            this.cmbCodCurso = new System.Windows.Forms.ComboBox();
            this.txtCodTurma = new System.Windows.Forms.MaskedTextBox();
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
            this.txtSala.Location = new System.Drawing.Point(72, 108);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(185, 20);
            this.txtSala.TabIndex = 11;
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Location = new System.Drawing.Point(21, 111);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(31, 13);
            this.lblSala.TabIndex = 9;
            this.lblSala.Text = "Sala:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(35, 174);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(104, 44);
            this.btnSalvar.TabIndex = 14;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(155, 174);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(102, 44);
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
            this.dgvDadosCursos.Size = new System.Drawing.Size(244, 167);
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
            this.ClientSize = new System.Drawing.Size(539, 233);
            this.Controls.Add(this.txtCodTurma);
            this.Controls.Add(this.cmbCodCurso);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDadosCursos);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastroTurma";
            this.Text = "Cadastro de Turmas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvDadosCursos;
        private System.Windows.Forms.ComboBox cmbCodCurso;
        private System.Windows.Forms.MaskedTextBox txtCodTurma;
    }
}