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
using SistemaEscola.Entidades;

namespace SistemaEscola.Formulários.Usuarios.Professor
{
    public partial class Professor : Form
    {
        public Professor()
        {
            InitializeComponent();
        }

        DadosUsuarioEnt userData = new DadosUsuarioEnt();

        public void getDados(DadosUsuarioEnt dados)
        {
            userData = dados;
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            EnviarMsg msg = new EnviarMsg();
            msg.getUserObj(userData);
            msg.Show();
        }

        private void btnBoletim_Click(object sender, EventArgs e)
        {
            InserirBoletim bolet = new InserirBoletim();
            bolet.Show();
        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            InserirFrequencia freq = new InserirFrequencia();
            freq.Show();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            Tarefas taref = new Tarefas();
            taref.getUserObj(userData);
            taref.Show();
        }

        private void Professor_Load(object sender, EventArgs e)
        {

        }
    }
}
