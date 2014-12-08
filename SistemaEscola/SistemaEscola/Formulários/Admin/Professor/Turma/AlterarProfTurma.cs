using SistemaEscola.Classe;
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
    public partial class AlterarVinculo : Form
    {
        public AlterarVinculo()
        {
            InitializeComponent();
        }

        Prof_TurmaDAO profTurmaDAO = new Prof_TurmaDAO();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            profTurmaDAO.pesquisaProfTurma(dgvDados, txtCod);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            profTurmaDAO.alteraProfTurma(dgvDados, txtCod);
            btnPesquisar_Click(sender, e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos limpa = new LimparCampos();
            limpa.limpaCampos(this);
        }
    }
}
