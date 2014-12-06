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
    public partial class PesquisarTurma : Form
    {
        public PesquisarTurma()
        {
            InitializeComponent();
        }

        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
        TurmaDAO turmaDAO = new TurmaDAO();

        private void PesquisarTurma_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboCurso(cmbCurso);
        }

        private void cmbCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            turmaDAO.pesquisaTurma(dgvDadosTurmas, cmbCurso);
        }

        private void txtCodTurma_TextChanged(object sender, EventArgs e)
        {
            turmaDAO.pesquisaTurma(dgvDadosTurmas, txtCodTurma);
            cmbCurso.Text = "";
        }
    }
}
