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
using SistemaEscola.Entidades;

namespace SistemaEscola.Formulários.Usuarios.AlunoForms
{
    public partial class AlunoForm : Form
    {

        public AlunoForm()
        {
            InitializeComponent();
        }

        DadosUsuarioEnt userData = new DadosUsuarioEnt();

        public void getDados(DadosUsuarioEnt dados)
        {
            userData = dados;
        }

        private void btnBoletim_Click(object sender, EventArgs e)
        {
            BoletimForm bol = new BoletimForm();
            bol.Show();
        }

        private void btnTarefas_Click(object sender, EventArgs e)
        {
            Tarefas tar = new Tarefas();
            tar.Show();
        }

        private void btnFrequencia_Click(object sender, EventArgs e)
        {
            FrequenciaForm freq = new FrequenciaForm();
            freq.Show();
        }

        private void btnMensagem_Click(object sender, EventArgs e)
        {
            EnviarMsg msg = new EnviarMsg();
            msg.getUserObj(userData);
            msg.Show();
        }
    }
}
