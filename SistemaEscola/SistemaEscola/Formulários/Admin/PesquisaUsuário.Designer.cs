﻿namespace SistemaEscola.Formulários.Admin
{
    partial class PesquisaUsuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PesquisaUsuário));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdCod = new System.Windows.Forms.RadioButton();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.lblDado = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtDado = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdCod);
            this.groupBox1.Controls.Add(this.rdNome);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 51);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por";
            // 
            // rdCod
            // 
            this.rdCod.AutoSize = true;
            this.rdCod.Location = new System.Drawing.Point(248, 21);
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
            this.rdNome.Location = new System.Drawing.Point(129, 21);
            this.rdNome.Name = "rdNome";
            this.rdNome.Size = new System.Drawing.Size(63, 20);
            this.rdNome.TabIndex = 0;
            this.rdNome.TabStop = true;
            this.rdNome.Text = "Nome";
            this.rdNome.UseVisualStyleBackColor = true;
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado.Location = new System.Drawing.Point(9, 70);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(313, 16);
            this.lblDado.TabIndex = 2;
            this.lblDado.Text = "Digite o dado respectivo a opção escolhida acima:";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(318, 95);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(154, 23);
            this.btnPesquisar.TabIndex = 3;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtDado
            // 
            this.txtDado.Location = new System.Drawing.Point(318, 69);
            this.txtDado.MaxLength = 45;
            this.txtDado.Name = "txtDado";
            this.txtDado.Size = new System.Drawing.Size(154, 20);
            this.txtDado.TabIndex = 4;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(18, 134);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(454, 234);
            this.dgvDados.TabIndex = 5;
            // 
            // PesquisaUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 380);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtDado);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblDado);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PesquisaUsuário";
            this.Text = "Pesquisa de Usuário";
            this.Load += new System.EventHandler(this.PesquisaUsuário_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdCod;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.Label lblDado;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}