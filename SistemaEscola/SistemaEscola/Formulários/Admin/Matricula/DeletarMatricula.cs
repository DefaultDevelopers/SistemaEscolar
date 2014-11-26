using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using SistemaEscola.DAO;

namespace SistemaEscola.Formulários.Admin.Matricula
{
    public partial class DeletarMatricula : Form
    {
        public DeletarMatricula()
        {
            InitializeComponent();
        }

        MatriculaDAO matrDAO = new MatriculaDAO();

        private void btnDeletarMatr_Click(object sender, EventArgs e)
        {
            matrDAO.deletaMatricula(txtIDMatr);
        }

        private void DeletarMatricula_Load(object sender, EventArgs e)
        {
            matrDAO.pesquisaMatricula(dgvDados);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DeletarMatricula_Load(sender, e);
        }
    }
}
