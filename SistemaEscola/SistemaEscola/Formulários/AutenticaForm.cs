using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Classe;

namespace SistemaEscola.Formulários
{
    public partial class AutenticaForm : Form
    {
        public AutenticaForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Autenticacao aut = new Autenticacao();

            String login = txtAutLogin.Text;
            int senha = Convert.ToInt32(txtAutSenha.Text);

            aut.verificaLogin(login, senha, this);

            //this.Close();
        }

        public MaskedTextBox txtSenha
        {
            get
            {
                return txtAutSenha;
            }

            set
            {
                txtAutSenha = value;
            }
        }
    }
}
