using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Formulários.Admin;
using SistemaEscola.Formulários.Admin.Matricula;
using SistemaEscola.Formulários.Admin.Professor;
using SistemaEscola.Formulários.Admin.Turma;
using SistemaEscola.Formulários.Admin.Disciplina;
using SistemaEscola.Formulários.Admin.Prof_Turma;
using SistemaEscola.Formulários.Admin.Curso;

namespace SistemaEscola.Formulários
{
    public partial class JanelaDoAdm : Form
    {
        public JanelaDoAdm()
        {
            InitializeComponent();
        }

        private void btnAdmMatr_Click(object sender, EventArgs e)
        {
            Matricula matr = new Matricula();
            matr.ShowDialog();
        }

        private void btnAdmProf_Click(object sender, EventArgs e)
        {
            Professor prof = new Professor();
            prof.ShowDialog();
        }

        private void btnAdmTurma_Click(object sender, EventArgs e)
        {
            Turma turma = new Turma();
            turma.ShowDialog();
        }

        private void btnAdmDisc_Click(object sender, EventArgs e)
        {
            Disciplina disc = new Disciplina();
            disc.ShowDialog();
        }

        private void btnAdmDel_Click(object sender, EventArgs e)
        {
            DeletarUsuário delUser = new DeletarUsuário();
            delUser.ShowDialog();
        }

        private void btnAdmProfTurma_Click(object sender, EventArgs e)
        {
            Prof_Turma profturma = new Prof_Turma();
            profturma.ShowDialog();
        }

        private void btnAdmPesq_Click(object sender, EventArgs e)
        {
            PesquisaUsuário pesqUser = new PesquisaUsuário();
            pesqUser.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CursoForm cursoForm = new CursoForm();
            cursoForm.ShowDialog();
        }
    }
}
