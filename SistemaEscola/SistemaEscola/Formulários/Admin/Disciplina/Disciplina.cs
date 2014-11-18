using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Disciplina
{
    public partial class Disciplina : Form
    {
        public Disciplina()
        {
            InitializeComponent();
        }

        private void btnCadDisc_Click(object sender, EventArgs e)
        {
            CadastrarDisc cadDisc = new CadastrarDisc();
            cadDisc.Show();
        }

        private void btnAlteraDisc_Click(object sender, EventArgs e)
        {
            AlterarDisc altDisc = new AlterarDisc();
            altDisc.Show();
        }

        private void btnDelDisc_Click(object sender, EventArgs e)
        {
            DeletarDisc delDisc = new DeletarDisc();
            delDisc.Show();
        }

        private void btnPesquisarDisc_Click(object sender, EventArgs e)
        {
            PesquisarDisc pesqDisc = new PesquisarDisc();
            pesqDisc.Show();
        }
    }
}
