namespace SistemaEscola.Formulários.Admin
{
    partial class DeletarUsuário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarUsuário));
            this.grpbUser = new System.Windows.Forms.GroupBox();
            this.rbProf = new System.Windows.Forms.RadioButton();
            this.rbAluno = new System.Windows.Forms.RadioButton();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.txtDado = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.lblDado = new System.Windows.Forms.Label();
            this.rdNome = new System.Windows.Forms.RadioButton();
            this.rdCod = new System.Windows.Forms.RadioButton();
            this.grpbDeletarPor = new System.Windows.Forms.GroupBox();
            this.lblDadosCorretos = new System.Windows.Forms.Label();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpbUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.grpbDeletarPor.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbUser
            // 
            this.grpbUser.Controls.Add(this.rbProf);
            this.grpbUser.Controls.Add(this.rbAluno);
            this.grpbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbUser.Location = new System.Drawing.Point(15, 13);
            this.grpbUser.Name = "grpbUser";
            this.grpbUser.Size = new System.Drawing.Size(460, 50);
            this.grpbUser.TabIndex = 12;
            this.grpbUser.TabStop = false;
            this.grpbUser.Text = "O usuário é";
            // 
            // rbProf
            // 
            this.rbProf.AutoSize = true;
            this.rbProf.Location = new System.Drawing.Point(248, 24);
            this.rbProf.Name = "rbProf";
            this.rbProf.Size = new System.Drawing.Size(84, 20);
            this.rbProf.TabIndex = 2;
            this.rbProf.TabStop = true;
            this.rbProf.Text = "Professor";
            this.rbProf.UseVisualStyleBackColor = true;
            // 
            // rbAluno
            // 
            this.rbAluno.AutoSize = true;
            this.rbAluno.Location = new System.Drawing.Point(129, 24);
            this.rbAluno.Name = "rbAluno";
            this.rbAluno.Size = new System.Drawing.Size(60, 20);
            this.rbAluno.TabIndex = 3;
            this.rbAluno.TabStop = true;
            this.rbAluno.Text = "Aluno";
            this.rbAluno.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(21, 191);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(454, 245);
            this.dgvDados.TabIndex = 11;
            // 
            // txtDado
            // 
            this.txtDado.Location = new System.Drawing.Point(321, 126);
            this.txtDado.MaxLength = 45;
            this.txtDado.Name = "txtDado";
            this.txtDado.Size = new System.Drawing.Size(154, 20);
            this.txtDado.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(321, 152);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(154, 23);
            this.btnPesquisar.TabIndex = 9;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // lblDado
            // 
            this.lblDado.AutoSize = true;
            this.lblDado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDado.Location = new System.Drawing.Point(12, 127);
            this.lblDado.Name = "lblDado";
            this.lblDado.Size = new System.Drawing.Size(313, 16);
            this.lblDado.TabIndex = 8;
            this.lblDado.Text = "Digite o dado respectivo a opção escolhida acima:";
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
            // grpbDeletarPor
            // 
            this.grpbDeletarPor.Controls.Add(this.rdCod);
            this.grpbDeletarPor.Controls.Add(this.rdNome);
            this.grpbDeletarPor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbDeletarPor.Location = new System.Drawing.Point(15, 69);
            this.grpbDeletarPor.Name = "grpbDeletarPor";
            this.grpbDeletarPor.Size = new System.Drawing.Size(460, 51);
            this.grpbDeletarPor.TabIndex = 7;
            this.grpbDeletarPor.TabStop = false;
            this.grpbDeletarPor.Text = "Deletar por";
            // 
            // lblDadosCorretos
            // 
            this.lblDadosCorretos.AutoSize = true;
            this.lblDadosCorretos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCorretos.Location = new System.Drawing.Point(18, 172);
            this.lblDadosCorretos.Name = "lblDadosCorretos";
            this.lblDadosCorretos.Size = new System.Drawing.Size(222, 16);
            this.lblDadosCorretos.TabIndex = 13;
            this.lblDadosCorretos.Text = "Cheque se os dados estão corretos";
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(77, 463);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(116, 37);
            this.btnDeletar.TabIndex = 14;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(302, 463);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(116, 37);
            this.btnLimpar.TabIndex = 15;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // DeletarUsuário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 512);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.lblDadosCorretos);
            this.Controls.Add(this.grpbUser);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtDado);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.lblDado);
            this.Controls.Add(this.grpbDeletarPor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarUsuário";
            this.Text = "Deletar Usuário";
            this.Load += new System.EventHandler(this.DeletarUsuário_Load);
            this.grpbUser.ResumeLayout(false);
            this.grpbUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.grpbDeletarPor.ResumeLayout(false);
            this.grpbDeletarPor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbUser;
        private System.Windows.Forms.RadioButton rbProf;
        private System.Windows.Forms.RadioButton rbAluno;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.TextBox txtDado;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblDado;
        private System.Windows.Forms.RadioButton rdNome;
        private System.Windows.Forms.RadioButton rdCod;
        private System.Windows.Forms.GroupBox grpbDeletarPor;
        private System.Windows.Forms.Label lblDadosCorretos;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnLimpar;
    }
}