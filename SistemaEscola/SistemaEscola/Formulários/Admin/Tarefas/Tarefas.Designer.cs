namespace SistemaEscola.Formulários.Admin.Tarefas
{
    partial class Tarefas
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
            this.btnDeletarTarefas = new System.Windows.Forms.Button();
            this.btnAlterarTarefas = new System.Windows.Forms.Button();
            this.btnVerTarefas = new System.Windows.Forms.Button();
            this.btnCriarTarefa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeletarTarefas
            // 
            this.btnDeletarTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletarTarefas.Location = new System.Drawing.Point(220, 231);
            this.btnDeletarTarefas.Name = "btnDeletarTarefas";
            this.btnDeletarTarefas.Size = new System.Drawing.Size(150, 49);
            this.btnDeletarTarefas.TabIndex = 9;
            this.btnDeletarTarefas.Text = "Deletar Tarefas";
            this.btnDeletarTarefas.UseVisualStyleBackColor = true;
            this.btnDeletarTarefas.Click += new System.EventHandler(this.btnDeletarTarefas_Click);
            // 
            // btnAlterarTarefas
            // 
            this.btnAlterarTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarTarefas.Location = new System.Drawing.Point(38, 231);
            this.btnAlterarTarefas.Name = "btnAlterarTarefas";
            this.btnAlterarTarefas.Size = new System.Drawing.Size(150, 49);
            this.btnAlterarTarefas.TabIndex = 8;
            this.btnAlterarTarefas.Text = "Alterar Tarefas";
            this.btnAlterarTarefas.UseVisualStyleBackColor = true;
            this.btnAlterarTarefas.Click += new System.EventHandler(this.btnAlterarTarefas_Click);
            // 
            // btnVerTarefas
            // 
            this.btnVerTarefas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerTarefas.Location = new System.Drawing.Point(220, 176);
            this.btnVerTarefas.Name = "btnVerTarefas";
            this.btnVerTarefas.Size = new System.Drawing.Size(150, 49);
            this.btnVerTarefas.TabIndex = 7;
            this.btnVerTarefas.Text = "Ver Minhas Tarefas";
            this.btnVerTarefas.UseVisualStyleBackColor = true;
            this.btnVerTarefas.Click += new System.EventHandler(this.btnVerTarefas_Click);
            // 
            // btnCriarTarefa
            // 
            this.btnCriarTarefa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarTarefa.Location = new System.Drawing.Point(38, 176);
            this.btnCriarTarefa.Name = "btnCriarTarefa";
            this.btnCriarTarefa.Size = new System.Drawing.Size(150, 49);
            this.btnCriarTarefa.TabIndex = 6;
            this.btnCriarTarefa.Text = "Criar Tarefa";
            this.btnCriarTarefa.UseVisualStyleBackColor = true;
            this.btnCriarTarefa.Click += new System.EventHandler(this.btnCriarTarefa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaEscola.Properties.Resources.tarefas;
            this.pictureBox1.Location = new System.Drawing.Point(132, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 291);
            this.Controls.Add(this.btnDeletarTarefas);
            this.Controls.Add(this.btnAlterarTarefas);
            this.Controls.Add(this.btnVerTarefas);
            this.Controls.Add(this.btnCriarTarefa);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Tarefas";
            this.Text = "Tarefas";
            this.Load += new System.EventHandler(this.Tarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeletarTarefas;
        private System.Windows.Forms.Button btnAlterarTarefas;
        private System.Windows.Forms.Button btnVerTarefas;
        private System.Windows.Forms.Button btnCriarTarefa;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}