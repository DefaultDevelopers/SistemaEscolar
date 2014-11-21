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
using SistemaEscola.Formulários.Admin.Tarefas;

namespace SistemaEscola.Formulários.Usuarios.Professor
{
    public partial class Professor : Form
    {
        public Professor()
        {
            InitializeComponent();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            EnviarMsg msg = new EnviarMsg();
            msg.Show();
        }

        private void btnBoletim_Click(object sender, EventArgs e)
        {
            Boletim bolet = new Boletim();
            bolet.Show();
        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            Frequencia freq = new Frequencia();
            freq.Show();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            Tarefas taref = new Tarefas();
            taref.Show();
        }
    }
}
