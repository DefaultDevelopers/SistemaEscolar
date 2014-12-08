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

namespace SistemaEscola.Formulários.Admin.Professor
{
    public partial class DeletarVinculo : Form
    {
        public DeletarVinculo()
        {
            InitializeComponent();
        }

        Prof_TurmaDAO profTurmaDAO = new Prof_TurmaDAO();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            profTurmaDAO.pesquisaProfTurma(dgvDados, txtCod);
        }

        private void btnDeletarVinculo_Click(object sender, EventArgs e)
        {
            profTurmaDAO.deletaProfTurma(txtIDVinculo);
            btnPesquisar_Click(sender, e);
        }
    }
}
