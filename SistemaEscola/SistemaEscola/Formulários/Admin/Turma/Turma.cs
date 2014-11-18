using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Turma
{
    public partial class Turma : Form
    {
        public Turma()
        {
            InitializeComponent();
        }

        private void btnCadTurma_Click(object sender, EventArgs e)
        {
            CadastroTurma cadTurma = new CadastroTurma();
            cadTurma.Show();
        }

        private void btnAlteraTurma_Click(object sender, EventArgs e)
        {
            AlterarTurma altTurma = new AlterarTurma();
            altTurma.Show();
        }

        private void btnDelTurma_Click(object sender, EventArgs e)
        {
            DeletarTurma delTurma = new DeletarTurma();
            delTurma.Show();
        }

        private void btnPesquisarTurma_Click(object sender, EventArgs e)
        {
            PesquisarTurma pesqTurma = new PesquisarTurma();
            pesqTurma.Show();
        }
    }
}
