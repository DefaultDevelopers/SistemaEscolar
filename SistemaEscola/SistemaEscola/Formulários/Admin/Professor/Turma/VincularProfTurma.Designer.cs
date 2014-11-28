namespace SistemaEscola.Formulários.Admin.Professor
{
    partial class VincularProfTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VincularProfTurma));
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCodTurma = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtCodProf = new System.Windows.Forms.MaskedTextBox();
            this.linklblCodProf = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Código da Turma:";
            // 
            // cmbCodTurma
            // 
            this.cmbCodTurma.FormattingEnabled = true;
            this.cmbCodTurma.Location = new System.Drawing.Point(147, 52);
            this.cmbCodTurma.Name = "cmbCodTurma";
            this.cmbCodTurma.Size = new System.Drawing.Size(121, 21);
            this.cmbCodTurma.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(39, 84);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(88, 29);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(180, 82);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(88, 31);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // txtCodProf
            // 
            this.txtCodProf.Location = new System.Drawing.Point(147, 20);
            this.txtCodProf.Mask = "0000000";
            this.txtCodProf.Name = "txtCodProf";
            this.txtCodProf.Size = new System.Drawing.Size(121, 20);
            this.txtCodProf.TabIndex = 6;
            // 
            // linklblCodProf
            // 
            this.linklblCodProf.AutoSize = true;
            this.linklblCodProf.Location = new System.Drawing.Point(36, 23);
            this.linklblCodProf.Name = "linklblCodProf";
            this.linklblCodProf.Size = new System.Drawing.Size(105, 13);
            this.linklblCodProf.TabIndex = 7;
            this.linklblCodProf.TabStop = true;
            this.linklblCodProf.Text = "Código do Professor:";
            this.linklblCodProf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCodProf_LinkClicked);
            // 
            // VincularProfTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 125);
            this.Controls.Add(this.linklblCodProf);
            this.Controls.Add(this.txtCodProf);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbCodTurma);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VincularProfTurma";
            this.Text = "Vincular Professor/Turma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbCodTurma;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.MaskedTextBox txtCodProf;
        private System.Windows.Forms.LinkLabel linklblCodProf;
    }
}