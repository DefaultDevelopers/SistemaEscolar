namespace SistemaEscola.Formulários.Admin.Tarefas
{
    partial class DeletarTarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeletarTarefas));
            this.dgvTarefa = new System.Windows.Forms.DataGridView();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.MaskedTextBox();
            this.lblID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarefa
            // 
            this.dgvTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefa.Location = new System.Drawing.Point(12, 12);
            this.dgvTarefa.Name = "dgvTarefa";
            this.dgvTarefa.Size = new System.Drawing.Size(548, 192);
            this.dgvTarefa.TabIndex = 22;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(463, 210);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(97, 33);
            this.btnDeletar.TabIndex = 23;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(357, 217);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 24;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(132, 218);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(219, 16);
            this.lblID.TabIndex = 25;
            this.lblID.Text = "Digite a ID da tarefa a ser deletada:";
            // 
            // DeletarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 247);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.dgvTarefa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DeletarTarefas";
            this.Text = "Deletar Suas Tarefas";
            this.Load += new System.EventHandler(this.DeletarTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarefa;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.MaskedTextBox txtID;
        private System.Windows.Forms.Label lblID;
    }
}