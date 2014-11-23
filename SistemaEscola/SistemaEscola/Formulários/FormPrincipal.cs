using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Formulários;

namespace SistemaEscola
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void entrarComoAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AutenticaForm autForm = new AutenticaForm();
            autForm.ShowDialog();
        }

        private void sistemaAcadêmicoAlphaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sobre sobre = new Sobre();
            sobre.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AutenticaForm autentica = new AutenticaForm();
            autentica.Show();            
        }
    }
}
