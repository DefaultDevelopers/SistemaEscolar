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
    public partial class DeletarTarefas : Form
    {
        public DeletarTarefas(DadosUsuarioEnt entUser)
        {
            InitializeComponent();
            ent = entUser;
        }

        DadosUsuarioEnt ent = new DadosUsuarioEnt();
        TarefaDAO tarefaDAO = new TarefaDAO();
        TarefaEnt tarefaEnt = new TarefaEnt();

        private void DeletarTarefas_Load(object sender, EventArgs e)
        {
            String login = ent.Login;
            tarefaEnt.Login = login;
            tarefaDAO.pesquisarComID(dgvTarefa, tarefaEnt);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            String ID = txtID.Text;
            tarefaDAO.deletar(ID);

            DeletarTarefas_Load(sender, e);
        }
    }
}
