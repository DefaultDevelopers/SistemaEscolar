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
    public partial class PesquisarMatricula : Form
    {
        public PesquisarMatricula()
        {
            InitializeComponent();
        }

        MatriculaDAO matrDAO = new MatriculaDAO();

        private void PesquisarMatricula_Load(object sender, EventArgs e)
        {
            matrDAO.pesquisaMatricula(dgvDados);
        }
    }
}
