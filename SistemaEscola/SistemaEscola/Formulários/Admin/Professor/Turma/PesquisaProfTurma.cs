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

namespace SistemaEscola.Formulários.Admin.Professor.Turma
{
    public partial class PesquisaProfTurma : Form
    {
        public PesquisaProfTurma()
        {
            InitializeComponent();
        }

        Prof_TurmaDAO profTurmaDAO = new Prof_TurmaDAO();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            profTurmaDAO.pesquisaProfTurma(dgvDados, txtCod);
        }
    }
}
