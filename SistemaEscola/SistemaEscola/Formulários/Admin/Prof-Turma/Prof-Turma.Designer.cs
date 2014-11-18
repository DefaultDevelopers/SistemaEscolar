namespace SistemaEscola.Formulários.Admin.Prof_Turma
{
    partial class Prof_Turma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prof_Turma));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVincular = new System.Windows.Forms.Button();
            this.btnAlterarVinculo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaEscola.Properties.Resources.Prof_TurmaIcon1;
            this.pictureBox1.Location = new System.Drawing.Point(79, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnVincular
            // 
            this.btnVincular.Location = new System.Drawing.Point(27, 187);
            this.btnVincular.Name = "btnVincular";
            this.btnVincular.Size = new System.Drawing.Size(89, 37);
            this.btnVincular.TabIndex = 1;
            this.btnVincular.Text = "Vincular";
            this.btnVincular.UseVisualStyleBackColor = true;
            // 
            // btnAlterarVinculo
            // 
            this.btnAlterarVinculo.Location = new System.Drawing.Point(168, 187);
            this.btnAlterarVinculo.Name = "btnAlterarVinculo";
            this.btnAlterarVinculo.Size = new System.Drawing.Size(89, 37);
            this.btnAlterarVinculo.TabIndex = 2;
            this.btnAlterarVinculo.Text = "Vínculo";
            this.btnAlterarVinculo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Designação da turma em que cada professor dará aula";
            // 
            // Prof_Turma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlterarVinculo);
            this.Controls.Add(this.btnVincular);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Prof_Turma";
            this.Text = "Professor/Turma";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVincular;
        private System.Windows.Forms.Button btnAlterarVinculo;
        private System.Windows.Forms.Label label1;
    }
}