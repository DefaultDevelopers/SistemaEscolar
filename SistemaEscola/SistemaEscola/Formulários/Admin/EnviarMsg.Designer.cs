namespace SistemaEscola.Formulários.Admin
{
    partial class EnviarMsg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarMsg));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPara = new System.Windows.Forms.Label();
            this.lblAnexo = new System.Windows.Forms.Label();
            this.lblAssunto = new System.Windows.Forms.Label();
            this.labelMensagem = new System.Windows.Forms.Label();
            this.txtPara = new System.Windows.Forms.TextBox();
            this.txtAnexo = new System.Windows.Forms.TextBox();
            this.txtAssunto = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnProcurarAnexo = new System.Windows.Forms.Button();
            this.txtCC = new System.Windows.Forms.TextBox();
            this.lblCC = new System.Windows.Forms.Label();
            this.openFileAnexo = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaEscola.Properties.Resources.email;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPara
            // 
            this.lblPara.AutoSize = true;
            this.lblPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPara.Location = new System.Drawing.Point(106, 13);
            this.lblPara.Name = "lblPara";
            this.lblPara.Size = new System.Drawing.Size(40, 16);
            this.lblPara.TabIndex = 1;
            this.lblPara.Text = "Para:";
            // 
            // lblAnexo
            // 
            this.lblAnexo.AutoSize = true;
            this.lblAnexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnexo.Location = new System.Drawing.Point(106, 57);
            this.lblAnexo.Name = "lblAnexo";
            this.lblAnexo.Size = new System.Drawing.Size(49, 16);
            this.lblAnexo.TabIndex = 2;
            this.lblAnexo.Text = "Anexo:";
            // 
            // lblAssunto
            // 
            this.lblAssunto.AutoSize = true;
            this.lblAssunto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssunto.Location = new System.Drawing.Point(106, 109);
            this.lblAssunto.Name = "lblAssunto";
            this.lblAssunto.Size = new System.Drawing.Size(59, 16);
            this.lblAssunto.TabIndex = 3;
            this.lblAssunto.Text = "Assunto:";
            // 
            // labelMensagem
            // 
            this.labelMensagem.AutoSize = true;
            this.labelMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensagem.Location = new System.Drawing.Point(12, 129);
            this.labelMensagem.Name = "labelMensagem";
            this.labelMensagem.Size = new System.Drawing.Size(79, 16);
            this.labelMensagem.TabIndex = 4;
            this.labelMensagem.Text = "Mensagem:";
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(143, 12);
            this.txtPara.MaxLength = 45;
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(267, 20);
            this.txtPara.TabIndex = 5;
            // 
            // txtAnexo
            // 
            this.txtAnexo.Location = new System.Drawing.Point(152, 56);
            this.txtAnexo.MaxLength = 150;
            this.txtAnexo.Name = "txtAnexo";
            this.txtAnexo.Size = new System.Drawing.Size(258, 20);
            this.txtAnexo.TabIndex = 6;
            // 
            // txtAssunto
            // 
            this.txtAssunto.Location = new System.Drawing.Point(161, 108);
            this.txtAssunto.MaxLength = 45;
            this.txtAssunto.Name = "txtAssunto";
            this.txtAssunto.Size = new System.Drawing.Size(249, 20);
            this.txtAssunto.TabIndex = 7;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Location = new System.Drawing.Point(12, 148);
            this.txtMensagem.MaxLength = 1000;
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(398, 245);
            this.txtMensagem.TabIndex = 8;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(56, 409);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(100, 42);
            this.btnEnviar.TabIndex = 9;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(266, 409);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(100, 42);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnProcurarAnexo
            // 
            this.btnProcurarAnexo.Location = new System.Drawing.Point(315, 82);
            this.btnProcurarAnexo.Name = "btnProcurarAnexo";
            this.btnProcurarAnexo.Size = new System.Drawing.Size(95, 23);
            this.btnProcurarAnexo.TabIndex = 11;
            this.btnProcurarAnexo.Text = "Procurar anexo";
            this.btnProcurarAnexo.UseVisualStyleBackColor = true;
            this.btnProcurarAnexo.Click += new System.EventHandler(this.btnProcurarAnexo_Click);
            // 
            // txtCC
            // 
            this.txtCC.Location = new System.Drawing.Point(143, 34);
            this.txtCC.MaxLength = 45;
            this.txtCC.Name = "txtCC";
            this.txtCC.Size = new System.Drawing.Size(267, 20);
            this.txtCC.TabIndex = 13;
            // 
            // lblCC
            // 
            this.lblCC.AutoSize = true;
            this.lblCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCC.Location = new System.Drawing.Point(106, 35);
            this.lblCC.Name = "lblCC";
            this.lblCC.Size = new System.Drawing.Size(29, 16);
            this.lblCC.TabIndex = 12;
            this.lblCC.Text = "CC:";
            // 
            // openFileAnexo
            // 
            this.openFileAnexo.FileName = "openFileAnexo";
            // 
            // EnviarMsg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 466);
            this.Controls.Add(this.txtCC);
            this.Controls.Add(this.lblCC);
            this.Controls.Add(this.btnProcurarAnexo);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtMensagem);
            this.Controls.Add(this.txtAssunto);
            this.Controls.Add(this.txtAnexo);
            this.Controls.Add(this.txtPara);
            this.Controls.Add(this.labelMensagem);
            this.Controls.Add(this.lblAssunto);
            this.Controls.Add(this.lblAnexo);
            this.Controls.Add(this.lblPara);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EnviarMsg";
            this.Text = "Enviar Mensagem";
            this.Load += new System.EventHandler(this.EnviarMsg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPara;
        private System.Windows.Forms.Label lblAnexo;
        private System.Windows.Forms.Label lblAssunto;
        private System.Windows.Forms.Label labelMensagem;
        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.TextBox txtAnexo;
        private System.Windows.Forms.TextBox txtAssunto;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnProcurarAnexo;
        private System.Windows.Forms.TextBox txtCC;
        private System.Windows.Forms.Label lblCC;
        private System.Windows.Forms.OpenFileDialog openFileAnexo;
    }
}