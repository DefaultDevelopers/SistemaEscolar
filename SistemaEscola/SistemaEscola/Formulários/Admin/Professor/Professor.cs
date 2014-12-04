using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Formulários.Admin.Professor.Disciplina;

namespace SistemaEscola.Formulários.Admin.Professor
{
    public partial class Professor : Form
    {
        public Professor()
        {
            InitializeComponent();
        }

        private void btnTurmaAula_Click(object sender, EventArgs e)
        {
            VincularProfTurma realVinculo = new VincularProfTurma();
            realVinculo.Show();
        }

        private void btnAlterarTurmaAula_Click(object sender, EventArgs e)
        {
            AlterarVinculo altVinculo = new AlterarVinculo();
            altVinculo.Show();
        }

        private void btnDeletarTurmaAula_Click(object sender, EventArgs e)
        {
            DeletarVinculo delVinculo = new DeletarVinculo();
            delVinculo.Show();
        }

        private void btnPesqTurmaAula_Click(object sender, EventArgs e)
        {

        }

        private void btnCadProf_Click(object sender, EventArgs e)
        {
            CadastrarProf cadProf = new CadastrarProf();
            cadProf.Show();
        }

        private void btnAlteraProf_Click(object sender, EventArgs e)
        {
            AlterarProf altProf = new AlterarProf();
            altProf.Show();
        }

        private void btnDiscMinis_Click(object sender, EventArgs e)
        {
            DisciplinaMinistrada discMinis = new DisciplinaMinistrada();
            discMinis.Show();
        }

        private void btnDeletaDiscMinis_Click(object sender, EventArgs e)
        {
            DeletarDiscMinis delDiscMinis = new DeletarDiscMinis();
            delDiscMinis.Show();
        }

        private void btnAlteraDiscMinis_Click(object sender, EventArgs e)
        {
            AlterarDiscMinis altDiscMinis = new AlterarDiscMinis();
            altDiscMinis.Show();
        }

        private void btnPesqDisc_Click(object sender, EventArgs e)
        {
            PesquisaProfDisc pesqProfDisc = new PesquisaProfDisc();
            pesqProfDisc.Show();
        }
    }
}
