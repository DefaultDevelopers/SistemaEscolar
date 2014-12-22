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

namespace SistemaEscola.Formulários.Admin.Tarefas
{
    public partial class VerTarefas : Form
    {
        DadosUsuarioEnt ent = new DadosUsuarioEnt();

        public VerTarefas(DadosUsuarioEnt entUser)
        {
            InitializeComponent();
            ent = entUser;
        }

        TarefaDAO tarefasDAO = new TarefaDAO();
        TarefaEnt tarefaEnt = new TarefaEnt();

        private void VerTarefas_Load(object sender, EventArgs e)
        {
            String login = ent.Login;
            tarefaEnt.Login = login;
            tarefasDAO.pesquisar(dgvTarefas, tarefaEnt);
        }
    }
}
