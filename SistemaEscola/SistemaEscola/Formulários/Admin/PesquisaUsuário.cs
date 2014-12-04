using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.DAO;

namespace SistemaEscola.Formulários.Admin
{
    public partial class PesquisaUsuário : Form
    {
        public PesquisaUsuário()
        {
            InitializeComponent();
        }

        AlunoDAO alunoDAO = new AlunoDAO();
        ProfessorDAO profDAO = new ProfessorDAO();       

        private void btnPorNome_Click(object sender, EventArgs e)
        {
            if (rdAluno.Checked)
            {
                alunoDAO.pesquisaAluno(dgvDados, txtPorNome);
            }
            else
            {
                profDAO.pesquisaProf(dgvDados, txtPorNome);
            }
        }

        private void btnPorCod_Click(object sender, EventArgs e)
        {
            if (rdAluno.Checked)
            {
                alunoDAO.pesquisaAluno(dgvDados, txtPorCod);
            }
            else
            {
                profDAO.pesquisaProf(dgvDados, txtPorCod);
            }
        }
    }
}
