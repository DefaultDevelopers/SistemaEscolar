using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Curso
{
    public partial class CursoForm : Form
    {
        public CursoForm()
        {
            InitializeComponent();
        }

        private void btnCadCurso_Click(object sender, EventArgs e)
        {
            CadastrarCurso cadCurso = new CadastrarCurso();
            cadCurso.Show();
        }
    }
}
