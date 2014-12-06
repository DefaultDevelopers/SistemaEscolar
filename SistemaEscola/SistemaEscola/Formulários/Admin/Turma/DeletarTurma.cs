using SistemaEscola.DAO;
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
    public partial class DeletarTurma : Form
    {
        public DeletarTurma()
        {
            InitializeComponent();
        }

        TurmaDAO turmaDAO = new TurmaDAO();

        private void DeletarTurma_Load(object sender, EventArgs e)
        {
            turmaDAO.pesquisaTurma(dgvDados);
        }

        private void txtCodTurma_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            MessageBox.Show("Você só pode escrever números aqui.");
        }

        private void btnDeletarMatr_Click(object sender, EventArgs e)
        {
            turmaDAO.deletaTurma(txtCodTurma);
            DeletarTurma_Load(sender, e);
        }
    }
}
