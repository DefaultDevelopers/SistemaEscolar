namespace SistemaEscola.Formulários.Admin.Disciplina
{
    partial class CadastrarDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarDisc));
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscCod = new System.Windows.Forms.Label();
            this.txtDiscNome = new System.Windows.Forms.Label();
            this.txtCargaHor = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDiscSalvar = new System.Windows.Forms.Button();
            this.btnDiscLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite os dados da disciplina:";
            // 
            // txtDiscCod
            // 
            this.txtDiscCod.AutoSize = true;
            this.txtDiscCod.Location = new System.Drawing.Point(12, 41);
            this.txtDiscCod.Name = "txtDiscCod";
            this.txtDiscCod.Size = new System.Drawing.Size(106, 13);
            this.txtDiscCod.TabIndex = 1;
            this.txtDiscCod.Text = "Código da Disciplina:";
            // 
            // txtDiscNome
            // 
            this.txtDiscNome.AutoSize = true;
            this.txtDiscNome.Location = new System.Drawing.Point(12, 73);
            this.txtDiscNome.Name = "txtDiscNome";
            this.txtDiscNome.Size = new System.Drawing.Size(38, 13);
            this.txtDiscNome.TabIndex = 2;
            this.txtDiscNome.Text = "Nome:";
            // 
            // txtCargaHor
            // 
            this.txtCargaHor.AutoSize = true;
            this.txtCargaHor.Location = new System.Drawing.Point(12, 106);
            this.txtCargaHor.Name = "txtCargaHor";
            this.txtCargaHor.Size = new System.Drawing.Size(73, 13);
            this.txtCargaHor.TabIndex = 3;
            this.txtCargaHor.Text = "Carga horária:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.AutoSize = true;
            this.txtDescricao.Location = new System.Drawing.Point(12, 141);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(58, 13);
            this.txtDescricao.TabIndex = 4;
            this.txtDescricao.Text = "Descrição:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(124, 38);
            this.maskedTextBox1.Mask = "000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(161, 20);
            this.maskedTextBox1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(54, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(231, 20);
            this.textBox1.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(91, 103);
            this.maskedTextBox2.Mask = "00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(194, 20);
            this.maskedTextBox2.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(76, 138);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 103);
            this.textBox2.TabIndex = 8;
            // 
            // btnDiscSalvar
            // 
            this.btnDiscSalvar.Location = new System.Drawing.Point(52, 263);
            this.btnDiscSalvar.Name = "btnDiscSalvar";
            this.btnDiscSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnDiscSalvar.TabIndex = 9;
            this.btnDiscSalvar.Text = "Salvar";
            this.btnDiscSalvar.UseVisualStyleBackColor = true;
            // 
            // btnDiscLimpar
            // 
            this.btnDiscLimpar.Location = new System.Drawing.Point(178, 263);
            this.btnDiscLimpar.Name = "btnDiscLimpar";
            this.btnDiscLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnDiscLimpar.TabIndex = 10;
            this.btnDiscLimpar.Text = "Limpar";
            this.btnDiscLimpar.UseVisualStyleBackColor = true;
            // 
            // CadastrarDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 298);
            this.Controls.Add(this.btnDiscLimpar);
            this.Controls.Add(this.btnDiscSalvar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtCargaHor);
            this.Controls.Add(this.txtDiscNome);
            this.Controls.Add(this.txtDiscCod);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CadastrarDisc";
            this.Text = "Cadastro de Disciplinas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtDiscCod;
        private System.Windows.Forms.Label txtDiscNome;
        private System.Windows.Forms.Label txtCargaHor;
        private System.Windows.Forms.Label txtDescricao;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDiscSalvar;
        private System.Windows.Forms.Button btnDiscLimpar;
    }
}