namespace SistemaEscola.Formulários
{
    partial class Sobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sobre));
            this.lblParaDesktop = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.lblDireitos = new System.Windows.Forms.Label();
            this.linklblClique = new System.Windows.Forms.LinkLabel();
            this.lblContribua = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblParaDesktop
            // 
            this.lblParaDesktop.AutoSize = true;
            this.lblParaDesktop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParaDesktop.Location = new System.Drawing.Point(241, 57);
            this.lblParaDesktop.Name = "lblParaDesktop";
            this.lblParaDesktop.Size = new System.Drawing.Size(250, 20);
            this.lblParaDesktop.TabIndex = 0;
            this.lblParaDesktop.Text = "Sistema Acadêmico para Desktop";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaEscola.Properties.Resources.IFMA;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblVersao
            // 
            this.lblVersao.AutoSize = true;
            this.lblVersao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersao.Location = new System.Drawing.Point(241, 86);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(105, 20);
            this.lblVersao.TabIndex = 2;
            this.lblVersao.Text = "Versão Alpha";
            // 
            // lblDireitos
            // 
            this.lblDireitos.AutoSize = true;
            this.lblDireitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireitos.Location = new System.Drawing.Point(241, 115);
            this.lblDireitos.Name = "lblDireitos";
            this.lblDireitos.Size = new System.Drawing.Size(379, 20);
            this.lblDireitos.TabIndex = 3;
            this.lblDireitos.Text = "Todos os direitos reservados a Default Developers ®";
            // 
            // linklblClique
            // 
            this.linklblClique.AutoSize = true;
            this.linklblClique.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linklblClique.Location = new System.Drawing.Point(544, 153);
            this.linklblClique.Name = "linklblClique";
            this.linklblClique.Size = new System.Drawing.Size(88, 16);
            this.linklblClique.TabIndex = 4;
            this.linklblClique.TabStop = true;
            this.linklblClique.Text = "clicando aqui";
            this.linklblClique.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblClique_LinkClicked);
            // 
            // lblContribua
            // 
            this.lblContribua.AutoSize = true;
            this.lblContribua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContribua.Location = new System.Drawing.Point(12, 153);
            this.lblContribua.Name = "lblContribua";
            this.lblContribua.Size = new System.Drawing.Size(541, 16);
            this.lblContribua.TabIndex = 5;
            this.lblContribua.Text = "Você pode contribuir com nosso projeto acessando nosso repositório no GitHub. Ace" +
    "sse ";
            // 
            // Sobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 184);
            this.Controls.Add(this.linklblClique);
            this.Controls.Add(this.lblDireitos);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblParaDesktop);
            this.Controls.Add(this.lblContribua);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Sobre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sobre";
            this.Load += new System.EventHandler(this.Sobre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblParaDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.Label lblDireitos;
        private System.Windows.Forms.LinkLabel linklblClique;
        private System.Windows.Forms.Label lblContribua;
    }
}