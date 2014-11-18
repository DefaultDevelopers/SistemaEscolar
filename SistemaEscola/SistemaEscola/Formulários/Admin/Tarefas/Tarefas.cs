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
    public partial class Tarefas : Form
    {
        public Tarefas()
        {
            InitializeComponent();
        }

        private void btnCriarTarefa_Click(object sender, EventArgs e)
        {
            CriarTarefa criaTarefa = new CriarTarefa();
            criaTarefa.Show();
        }

        private void btnVerTarefas_Click(object sender, EventArgs e)
        {
            VerTarefas verTarefas = new VerTarefas();
            verTarefas.Show();
        }

        private void btnAlterarTarefas_Click(object sender, EventArgs e)
        {
            AlterarTarefas altTarefa = new AlterarTarefas();
            altTarefa.Show();
        }

        private void btnDeletarTarefas_Click(object sender, EventArgs e)
        {
            DeletarTarefas delTarefa = new DeletarTarefas();
            delTarefa.Show();
        }
    }
}
