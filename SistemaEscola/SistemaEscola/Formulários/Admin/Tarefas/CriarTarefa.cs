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
    public partial class CriarTarefa : Form
    {

        DadosUsuarioEnt ent = new DadosUsuarioEnt();
        TarefaDAO tarefaDAO = new TarefaDAO();
        TarefaEnt tarefaEnt = new TarefaEnt();

        public CriarTarefa(DadosUsuarioEnt entUser)
        {
            InitializeComponent();
            ent = entUser;
        }

        private void CriarTarefa_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataCriado, dataFim;
            String assunto, descricao, login;

            dataCriado = DateTime.Now;
            dataFim = dtpFim.Value;
            assunto = txtAssunto.Text;
            descricao = txtDescricao.Text;
            login = ent.Login;

            tarefaEnt.DataCriada = dataCriado;
            tarefaEnt.DataFim = dataFim;
            tarefaEnt.Assunto = assunto;
            tarefaEnt.Descricao = descricao;
            tarefaEnt.Login = login;

            tarefaDAO.salvar(tarefaEnt);
        }
    }
}
