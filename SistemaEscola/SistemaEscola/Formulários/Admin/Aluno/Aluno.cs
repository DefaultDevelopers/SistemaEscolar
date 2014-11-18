using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Aluno
{
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
        }

        private void btnCadAluno_Click(object sender, EventArgs e)
        {
            CadastrarAluno cadAluno = new CadastrarAluno();
            cadAluno.Show();
        }

        private void btnAlteraAluno_Click(object sender, EventArgs e)
        {
            AlteraAluno altAluno = new AlteraAluno();
            altAluno.Show();
        }
    }
}
