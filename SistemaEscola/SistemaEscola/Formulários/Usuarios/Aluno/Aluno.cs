using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Formulários.Admin.Tarefas;
using SistemaEscola.Formulários.Admin;

namespace SistemaEscola.Formulários.Usuarios
{
    public partial class Aluno : Form
    {
        public Aluno()
        {
            InitializeComponent();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            Tarefas tarefas = new Tarefas();
            tarefas.Show();
        }

        private void btnBoletim_Click(object sender, EventArgs e)
        {
            Boletim boletim = new Boletim();
            boletim.Show();
        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            Frequencia freq = new Frequencia();
            freq.Show();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            EnviarMsg msg = new EnviarMsg();
            msg.Show();
        }
    }
}
