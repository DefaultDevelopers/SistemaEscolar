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

        private void btnAluno_Click(object sender, EventArgs e)
        {
            AutenticaForm autFormAluno = new AutenticaForm();
            autFormAluno.ShowDialog();
        }

        private void btnProfessor_Click(object sender, EventArgs e)
        {
            AutenticaForm autFormProf = new AutenticaForm();
            autFormProf.ShowDialog();
        }
    }
}
