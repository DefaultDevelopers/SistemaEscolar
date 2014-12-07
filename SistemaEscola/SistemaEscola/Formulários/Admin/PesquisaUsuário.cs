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

        //Método executado quando o texto muda
        private void txtPorNome_TextChanged(object sender, EventArgs e)
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
        //Método executado quando o código muda
        private void txtPorCod_TextChanged(object sender, EventArgs e)
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
        //Método que limpa os campos de nome e código quando muda a escolha de pesquisa
        private void grpPesquisa_CheckedChanged(object sender, EventArgs e)
        {
            txtPorCod.Clear();
            txtPorNome.Clear();
        }
    }
}
