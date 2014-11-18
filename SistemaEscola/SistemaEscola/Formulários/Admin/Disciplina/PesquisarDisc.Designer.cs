namespace SistemaEscola.Formulários.Admin.Disciplina
{
    partial class PesquisarDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisarDisc));
            this.label1 = new System.Windows.Forms.Label();
            this.grpbPesquisaPor = new System.Windows.Forms.GroupBox();
            this.rdCod = new System.Windows.Forms.RadioButton();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.txtDado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.grpbPesquisaPor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o dado correspondente a opção escolhida acima:";
            // 
            // grpbPesquisaPor
            // 
            this.grpbPesquisaPor.Controls.Add(this.rdCod);
            this.grpbPesquisaPor.Controls.Add(this.rdNome);
            this.grpbPesquisaPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbPesquisaPor.Location = new System.Drawing.Point(15, 12);
            this.grpbPesquisaPor.Name = "grpbPesquisaPor";
            this.grpbPesquisaPor.Size = new System.Drawing.Size(515, 48);
            this.grpbPesquisaPor.TabIndex = 1;
            this.grpbPesquisaPor.TabStop = false;
            this.grpbPesquisaPor.Text = "Pesquisar por";
            // 
            // rdCod
            // 
            this.rdCod.AutoSize = true;
            this.rdCod.Location = new System.Drawing.Point(362, 18);
            this.rdCod.Name = "rdCod";
            this.rdCod.Size = new System.Drawing.Size(70, 20);
            this.rdCod.TabIndex = 1;
            this.rdCod.TabStop = true;
            this.rdCod.Text = "Código";
            this.rdCod.UseVisualStyleBackColor = true;
            // 
            // rdNome
            // 
            this.rdNome.AutoSize = true;
            this.rdNome.Location = new System.Drawing.Point(83, 21);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(63, 20);
            this.rdNome.TabIndex = 0;
            this.rdNome.TabStop = true;
            this.rdNome.Text = "Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            // 
            // txtDado
            // 
            this.txtDado.Location = new System.Drawing.Point(363, 73);
            this.txtDado.Name = "txtDado";
            this.txtDado.Size = new System.Drawing.Size(166, 20);
            this.txtDado.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(363, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(15, 140);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(514, 243);
            this.dgvDados.TabIndex = 2;
            // 
            // PesquisarDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 395);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDado);
            this.Controls.Add(this.grpbPesquisaPor);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisarDisc";
            this.Text = "Pesquisar Disciplina";
            this.Load += new System.EventHandler(this.PesquisarDisc_Load);
            this.grpbPesquisaPor.ResumeLayout(false);
            this.grpbPesquisaPor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpbPesquisaPor;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.RadioButton rdCod;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.Button button1;

    }
}