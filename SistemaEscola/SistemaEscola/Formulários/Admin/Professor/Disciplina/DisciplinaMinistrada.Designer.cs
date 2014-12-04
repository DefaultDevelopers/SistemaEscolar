namespace SistemaEscola.Formulários.Admin.Professor
{
    partial class DisciplinaMinistrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisciplinaMinistrada));
            this.lblEscolhaDisc = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.MaskedTextBox();
            this.lblEscDisc = new System.Windows.Forms.Label();
            this.cmbEscDisc = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.linklblCodProf = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblEscolhaDisc
            // 
            this.lblEscolhaDisc.AutoSize = true;
            this.lblEscolhaDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaDisc.Location = new System.Drawing.Point(29, 9);
            this.lblEscolhaDisc.Name = "lblEscolhaDisc";
            this.lblEscolhaDisc.Size = new System.Drawing.Size(335, 20);
            this.lblEscolhaDisc.TabIndex = 0;
            this.lblEscolhaDisc.Text = "Escolha a disciplina que o professor ministrará";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(213, 41);
            this.txtCod.Mask = "00000000";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(145, 20);
            this.txtCod.TabIndex = 1;
            // 
            // lblEscDisc
            // 
            this.lblEscDisc.AutoSize = true;
            this.lblEscDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscDisc.Location = new System.Drawing.Point(34, 72);
            this.lblEscDisc.Name = "lblEscDisc";
            this.lblEscDisc.Size = new System.Drawing.Size(131, 16);
            this.lblEscDisc.TabIndex = 7;
            this.lblEscDisc.Text = "Escolha a disciplina:";
            // 
            // cmbEscDisc
            // 
            this.cmbEscDisc.FormattingEnabled = true;
            this.cmbEscDisc.Location = new System.Drawing.Point(213, 71);
            this.cmbEscDisc.Name = "cmbEscDisc";
            this.cmbEscDisc.Size = new System.Drawing.Size(145, 21);
            this.cmbEscDisc.TabIndex = 2;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(73, 98);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 39);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(219, 98);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 39);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // linklblCodProf
            // 
            this.linklblCodProf.AutoSize = true;
            this.linklblCodProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblCodProf.Location = new System.Drawing.Point(34, 42);
            this.linklblCodProf.Name = "linklblCodProf";
            this.linklblCodProf.Size = new System.Drawing.Size(134, 16);
            this.linklblCodProf.TabIndex = 8;
            this.linklblCodProf.TabStop = true;
            this.linklblCodProf.Text = "Código do professor:";
            this.linklblCodProf.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblCodProf_LinkClicked);
            // 
            // DisciplinaMinistrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 149);
            this.Controls.Add(this.linklblCodProf);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbEscDisc);
            this.Controls.Add(this.lblEscDisc);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblEscolhaDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisciplinaMinistrada";
            this.Text = "Determine a disciplina deste professor";
            this.Load += new System.EventHandler(this.DisciplinaMinistrada_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscolhaDisc;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.Label lblEscDisc;
        private System.Windows.Forms.ComboBox cmbEscDisc;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.LinkLabel linklblCodProf;
    }
}