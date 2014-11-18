using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Matricula
{
    public partial class Matricula : Form
    {
        public Matricula()
        {
            InitializeComponent();
        }

        private void btnCadMatr_Click(object sender, EventArgs e)
        {
            MatricularAluno matrAluno = new MatricularAluno();
            matrAluno.Show();
        }

        private void btnAlteraMatr_Click(object sender, EventArgs e)
        {
            AlterarMatricula altMatr = new AlterarMatricula();
            altMatr.Show();
        }

        private void btnDelMatr_Click(object sender, EventArgs e)
        {
            DeletarMatricula delMatr = new DeletarMatricula();
            delMatr.Show();
        }

        private void btnPesquisarMatr_Click(object sender, EventArgs e)
        {
            PesquisarMatricula pesqMatr = new PesquisarMatricula();
            pesqMatr.Show();
        }
    }
}
