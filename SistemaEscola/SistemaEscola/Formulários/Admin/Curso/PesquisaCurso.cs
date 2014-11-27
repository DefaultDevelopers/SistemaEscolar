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
namespace SistemaEscola.Formulários.Admin.Curso
{
    public partial class PesquisaCurso : Form
    {
        public PesquisaCurso()
        {
            InitializeComponent();
        }

        CursoDAO cursoDAO = new CursoDAO();

        private void PesquisaCurso_Load(object sender, EventArgs e)
        {
            cursoDAO.pesquisaCurso(dgvDados);
        }
    }
}
