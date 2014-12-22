namespace SistemaEscola.Formulários.Admin.Tarefas
{
    partial class AlterarTarefas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarTarefas));
            this.dgvTarefa = new System.Windows.Forms.DataGridView();
            this.btnSalvar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTarefa
            // 
            this.dgvTarefa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTarefa.Location = new System.Drawing.Point(12, 12);
            this.dgvTarefa.Name = "dgvTarefa";
            this.dgvTarefa.Size = new System.Drawing.Size(581, 253);
            this.dgvTarefa.TabIndex = 0;
            this.dgvTarefa.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dgvTarefa_DataError);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(490, 271);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(103, 42);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // AlterarTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 316);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dgvTarefa);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AlterarTarefas";
            this.Text = "Alterar Suas Tarefas";
            this.Load += new System.EventHandler(this.AlterarTarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTarefa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTarefa;
        private System.Windows.Forms.Button btnSalvar;

    }
}