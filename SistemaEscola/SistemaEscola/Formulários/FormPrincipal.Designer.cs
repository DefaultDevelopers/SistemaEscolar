namespace SistemaEscola
{
    partial class FormPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.arrozToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feijãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.realizarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arrozToolStripMenuItem,
            this.feijãoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(106, 48);
            // 
            // arrozToolStripMenuItem
            // 
            this.arrozToolStripMenuItem.Name = "arrozToolStripMenuItem";
            this.arrozToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.arrozToolStripMenuItem.Text = "Arroz";
            // 
            // feijãoToolStripMenuItem
            // 
            this.feijãoToolStripMenuItem.Name = "feijãoToolStripMenuItem";
            this.feijãoToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.feijãoToolStripMenuItem.Text = "Feijão";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(551, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contasToolStripMenuItem
            // 
            this.contasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarCadastroToolStripMenuItem,
            this.alterarCadastroToolStripMenuItem,
            this.deletarCadastroToolStripMenuItem,
            this.pesquisarCadastroToolStripMenuItem});
            this.contasToolStripMenuItem.Name = "contasToolStripMenuItem";
            this.contasToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.contasToolStripMenuItem.Text = "Opções";
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(81, 238);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(141, 53);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.Text = "Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(328, 238);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(141, 53);
            this.btnProfessor.TabIndex = 3;
            this.btnProfessor.Text = "Professor";
            this.btnProfessor.UseVisualStyleBackColor = true;
            // 
            // realizarCadastroToolStripMenuItem
            // 
            this.realizarCadastroToolStripMenuItem.Name = "realizarCadastroToolStripMenuItem";
            this.realizarCadastroToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.realizarCadastroToolStripMenuItem.Text = "Realizar cadastro";
            // 
            // alterarCadastroToolStripMenuItem
            // 
            this.alterarCadastroToolStripMenuItem.Name = "alterarCadastroToolStripMenuItem";
            this.alterarCadastroToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.alterarCadastroToolStripMenuItem.Text = "Alterar cadastro";
            // 
            // deletarCadastroToolStripMenuItem
            // 
            this.deletarCadastroToolStripMenuItem.Name = "deletarCadastroToolStripMenuItem";
            this.deletarCadastroToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.deletarCadastroToolStripMenuItem.Text = "Deletar cadastro";
            // 
            // pesquisarCadastroToolStripMenuItem
            // 
            this.pesquisarCadastroToolStripMenuItem.Name = "pesquisarCadastroToolStripMenuItem";
            this.pesquisarCadastroToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pesquisarCadastroToolStripMenuItem.Text = "Pesquisar cadastro";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 303);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrincipal";
            this.Text = "Sistema Escolar";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arrozToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feijãoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contasToolStripMenuItem;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.ToolStripMenuItem realizarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deletarCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarCadastroToolStripMenuItem;
    }
}

