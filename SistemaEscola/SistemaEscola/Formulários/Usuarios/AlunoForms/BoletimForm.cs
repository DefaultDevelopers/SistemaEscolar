using SistemaEscola.DAO;
using SistemaEscola.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Usuarios.AlunoForms
{
    public partial class BoletimForm : Form
    {
        public BoletimForm()
        {
            InitializeComponent();
        }

        DadosUsuarioEnt ent = new DadosUsuarioEnt();
        BoletimEnt boletimEnt = new BoletimEnt();
        BoletimDAO boletimDAO = new BoletimDAO();

        public void getUserObj(DadosUsuarioEnt userData)
        {
            ent = userData;
        }

        private void BoletimForm_Load(object sender, EventArgs e)
        {

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            String login = ent.Login;
            int turma = ent.IdTurma;
            int ano = DateTime.Now.Year;

            boletimEnt.Login = login;
            boletimEnt.IdTurma = turma;
            boletimEnt.Ano = ano;
            

            boletimDAO.pesquisaBoletimAluno(dgvBoletim, boletimEnt);
        }
    }
}
