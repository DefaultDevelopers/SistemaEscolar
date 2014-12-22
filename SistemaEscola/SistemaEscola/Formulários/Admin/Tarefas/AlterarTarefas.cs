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
    public partial class AlterarTarefas : Form
    {
        public AlterarTarefas(DadosUsuarioEnt entUser)
        {
            InitializeComponent();
            ent = entUser;
        }

        DadosUsuarioEnt ent = new DadosUsuarioEnt();
        TarefaDAO tarefaDAO = new TarefaDAO();
        TarefaEnt tarefaEnt = new TarefaEnt();

        private void AlterarTarefas_Load(object sender, EventArgs e)
        {
            String login = ent.Login;
            tarefaEnt.Login = login;
            tarefaDAO.pesquisarComID(dgvTarefa, tarefaEnt);
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {           
            DateTime dataCriada = DateTime.Now.Date;
            tarefaEnt.DataCriada = dataCriada;

            tarefaDAO.alterar(dgvTarefa, tarefaEnt);

            AlterarTarefas_Load(sender, e);
        }

        private void dgvTarefa_DataError(object sender, DataGridViewDataErrorEventArgs anError)
        {
            MessageBox.Show("Você digitou uma data e hora válidas?");

            if (anError.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("Commit error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("Cell change");
            }
            if (anError.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("parsing error");
            }
            if (anError.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("leave control error");
            }

            if ((anError.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[anError.RowIndex].ErrorText = "an error";
                view.Rows[anError.RowIndex].Cells[anError.ColumnIndex].ErrorText = "an error";                

                anError.ThrowException = false;
            }
        }
    }
}
