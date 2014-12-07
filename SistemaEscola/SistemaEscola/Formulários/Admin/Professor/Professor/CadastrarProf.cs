using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.DAO;
using MySql.Data.MySqlClient;

namespace SistemaEscola.Formulários.Admin.Professor
{
    public partial class CadastrarProf : Form
    {
        public CadastrarProf()
        {
            InitializeComponent();
        }

        private void CadastrarProf_Load(object sender, EventArgs e)
        {
            int ano = DateTime.Now.Year;
            txtLoginAno.Text = Convert.ToString(ano);
        }

        int user = 2;

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                //LOGIN
                String login;
                int senha;
                LoginDAO loginDAO = new LoginDAO();
                SistemaEscola.Entidades.Login loginEnt = new Entidades.Login();

                login = txtLoginAno.Text + txtLoginNumId.Text;
                senha = Convert.ToInt32(txtSenha.Text);

                loginEnt.Log = login;
                loginEnt.Senha = senha;
                loginEnt.User = user;

                loginDAO.salvarLogin(loginEnt);

                //PROFESSOR
                SistemaEscola.Entidades.Professor profEnt = new Entidades.Professor();
                ProfessorDAO profDAO = new ProfessorDAO();

                String nome, telefone, email, cpf, grauForm, form, dataNasc;

                nome = txtNome.Text;
                telefone = txtTelefone.Text;
                email = txtEmail.Text;
                cpf = txtCPF.Text;
                grauForm = cmbGrauFormacao.Text;
                form = txtFormacao.Text;
                dataNasc = txtDataNasc.Text;

                profEnt.Login = login;
                profEnt.Nome = nome;
                profEnt.Telefone = telefone;
                profEnt.Email = email;
                profEnt.CPF = cpf;
                profEnt.Grau_Form = grauForm;
                profEnt.Form = form;
                profEnt.DataNasc = dataNasc;

                profDAO.salvarProf(profEnt);

                //ENDEREÇO
                SistemaEscola.Entidades.Endereco endEnt = new Entidades.Endereco();
                EnderecoDAO endDAO = new EnderecoDAO();

                String rua, bairro, num, estado, cidade, cep;

                rua = txtRua.Text;
                bairro = txtBairro.Text;
                num = txtNum.Text;
                estado = txtEstado.Text;
                cidade = txtCidade.Text;
                cep = txtCEP.Text;

                endEnt.Login = login;
                endEnt.Rua = rua;
                endEnt.Bairro = bairro;
                endEnt.Num = num;
                endEnt.Estado = estado;
                endEnt.Cidade = cidade;
                endEnt.CEP = cep;

                endDAO.salvarEnd(endEnt);
            }
            catch (MySqlException vc)
            {
                MessageBox.Show("Erro ao cadastrar." + vc.Message);
            }
        }
    }
}
