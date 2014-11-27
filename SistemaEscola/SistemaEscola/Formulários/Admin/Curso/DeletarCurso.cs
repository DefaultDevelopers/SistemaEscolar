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
    public partial class DeletarCurso : Form
    {
        public DeletarCurso()
        {
            InitializeComponent();
        }

        CursoDAO cursoDAO = new CursoDAO();

        private void DeletarCurso_Load(object sender, EventArgs e)
        {
            cursoDAO.pesquisaCurso(dgvDados);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            cursoDAO.deletaCurso(txtCodCurso);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DeletarCurso_Load(sender, e);
        }
    }
}
