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
            this.lblCod = new System.Windows.Forms.Label();
            this.lblEscDisc = new System.Windows.Forms.Label();
            this.cmbEscDisc = new System.Windows.Forms.ComboBox();
            this.dgvDadosDisc = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEscolhaDisc
            // 
            this.lblEscolhaDisc.AutoSize = true;
            this.lblEscolhaDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaDisc.Location = new System.Drawing.Point(12, 9);
            this.lblEscolhaDisc.Name = "lblEscolhaDisc";
            this.lblEscolhaDisc.Size = new System.Drawing.Size(335, 20);
            this.lblEscolhaDisc.TabIndex = 0;
            this.lblEscolhaDisc.Text = "Escolha a disciplina que o professor ministrará";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(202, 73);
            this.txtCod.Mask = "0000000";
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(117, 20);
            this.txtCod.TabIndex = 6;
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCod.Location = new System.Drawing.Point(23, 74);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(181, 16);
            this.lblCod.TabIndex = 5;
            this.lblCod.Text = "Digite o código do professor:";
            // 
            // lblEscDisc
            // 
            this.lblEscDisc.AutoSize = true;
            this.lblEscDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscDisc.Location = new System.Drawing.Point(23, 104);
            this.lblEscDisc.Name = "lblEscDisc";
            this.lblEscDisc.Size = new System.Drawing.Size(131, 16);
            this.lblEscDisc.TabIndex = 7;
            this.lblEscDisc.Text = "Escolha a disciplina:";
            // 
            // cmbEscDisc
            // 
            this.cmbEscDisc.FormattingEnabled = true;
            this.cmbEscDisc.Location = new System.Drawing.Point(160, 103);
            this.cmbEscDisc.Name = "cmbEscDisc";
            this.cmbEscDisc.Size = new System.Drawing.Size(159, 21);
            this.cmbEscDisc.TabIndex = 8;
            // 
            // dgvDadosDisc
            // 
            this.dgvDadosDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDadosDisc.Location = new System.Drawing.Point(325, 53);
            this.dgvDadosDisc.Name = "dgvDadosDisc";
            this.dgvDadosDisc.Size = new System.Drawing.Size(283, 150);
            this.dgvDadosDisc.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Dados de disciplinas:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(45, 164);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(93, 39);
            this.btnSalvar.TabIndex = 11;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(191, 164);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(93, 39);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // DisciplinaMinistrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 222);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvDadosDisc);
            this.Controls.Add(this.cmbEscDisc);
            this.Controls.Add(this.lblEscDisc);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.lblCod);
            this.Controls.Add(this.lblEscolhaDisc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisciplinaMinistrada";
            this.Text = "Determine a disciplina deste professor";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDadosDisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEscolhaDisc;
        private System.Windows.Forms.MaskedTextBox txtCod;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblEscDisc;
        private System.Windows.Forms.ComboBox cmbEscDisc;
        private System.Windows.Forms.DataGridView dgvDadosDisc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
    }
}