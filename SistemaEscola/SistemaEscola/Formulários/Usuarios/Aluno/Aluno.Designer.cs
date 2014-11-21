namespace SistemaEscola.Formulários.Usuarios
{
    partial class Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Aluno));
            this.btnBoletim = new System.Windows.Forms.Button();
            this.btnTarefas = new System.Windows.Forms.Button();
            this.btnFrequencia = new System.Windows.Forms.Button();
            this.btnMensagem = new System.Windows.Forms.Button();
            this.picBoxAluno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBoletim
            // 
            this.btnBoletim.Location = new System.Drawing.Point(39, 219);
            this.btnBoletim.Name = "btnBoletim";
            this.btnBoletim.Size = new System.Drawing.Size(111, 51);
            this.btnBoletim.TabIndex = 1;
            this.btnBoletim.Text = "Boletim";
            this.btnBoletim.UseVisualStyleBackColor = true;
            this.btnBoletim.Click += new System.EventHandler(this.btnBoletim_Click);
            // 
            // btnTarefas
            // 
            this.btnTarefas.Location = new System.Drawing.Point(181, 219);
            this.btnTarefas.Name = "btnTarefas";
            this.btnTarefas.Size = new System.Drawing.Size(111, 51);
            this.btnTarefas.TabIndex = 2;
            this.btnTarefas.Text = "Tarefas";
            this.btnTarefas.UseVisualStyleBackColor = true;
            this.btnTarefas.Click += new System.EventHandler(this.btnTarefas_Click);
            // 
            // btnFrequencia
            // 
            this.btnFrequencia.Location = new System.Drawing.Point(39, 276);
            this.btnFrequencia.Name = "btnFrequencia";
            this.btnFrequencia.Size = new System.Drawing.Size(111, 51);
            this.btnFrequencia.TabIndex = 3;
            this.btnFrequencia.Text = "Frequência";
            this.btnFrequencia.UseVisualStyleBackColor = true;
            this.btnFrequencia.Click += new System.EventHandler(this.btnFrequencia_Click);
            // 
            // btnMensagem
            // 
            this.btnMensagem.Location = new System.Drawing.Point(181, 276);
            this.btnMensagem.Name = "btnMensagem";
            this.btnMensagem.Size = new System.Drawing.Size(111, 51);
            this.btnMensagem.TabIndex = 4;
            this.btnMensagem.Text = "Enviar Mensagem";
            this.btnMensagem.UseVisualStyleBackColor = true;
            this.btnMensagem.Click += new System.EventHandler(this.btnMensagem_Click);
            // 
            // picBoxAluno
            // 
            this.picBoxAluno.Image = global::SistemaEscola.Properties.Resources.aluno1;
            this.picBoxAluno.Location = new System.Drawing.Point(71, 12);
            this.picBoxAluno.Name = "picBoxAluno";
            this.picBoxAluno.Size = new System.Drawing.Size(188, 187);
            this.picBoxAluno.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxAluno.TabIndex = 0;
            this.picBoxAluno.TabStop = false;
            // 
            // Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 355);
            this.Controls.Add(this.btnMensagem);
            this.Controls.Add(this.btnFrequencia);
            this.Controls.Add(this.btnTarefas);
            this.Controls.Add(this.btnBoletim);
            this.Controls.Add(this.picBoxAluno);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Aluno";
            this.Text = "Aluno";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxAluno;
        private System.Windows.Forms.Button btnBoletim;
        private System.Windows.Forms.Button btnTarefas;
        private System.Windows.Forms.Button btnFrequencia;
        private System.Windows.Forms.Button btnMensagem;
    }
}