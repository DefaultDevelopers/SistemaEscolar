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
    public partial class FrequenciaForm : Form
    {
        public FrequenciaForm()
        {
            InitializeComponent();
        }

        DadosUsuarioEnt ent = new DadosUsuarioEnt();
        FrequenciaEnt frequenciaEnt = new FrequenciaEnt();
        FrequenciaDAO frequenciaDAO = new FrequenciaDAO();

        public void getUserObj(DadosUsuarioEnt userData)
        {
            ent = userData;
        }

        private void FrequenciaForm_Load(object sender, EventArgs e)
        {
            String login = ent.Login;
            int turma = ent.IdTurma;

            frequenciaEnt.IdAluno = login;
            frequenciaEnt.IdTurma = turma;

            frequenciaDAO.pesquisaFrequenciaAluno(dgvFrequencia, frequenciaEnt);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
