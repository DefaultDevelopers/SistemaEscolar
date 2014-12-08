using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscola.Entidades;
using MySql.Data.MySqlClient;
using SistemaEscola.Formulários.Usuarios.AlunoForms;
using SistemaEscola.Formulários.Usuarios.Professor;
using System.Windows.Forms;
using SistemaEscola.Formulários;
using SistemaEscola.DAO;

//Classe para checar se o login está correto
namespace SistemaEscola.Classe
{
    class Autenticacao
    {
        Banco b = new Banco();
        private MySqlConnection con;
        FormPrincipal form = new FormPrincipal();
        DadosDeUsuarioDAO dadosUserDAO = new DadosDeUsuarioDAO();

        public Autenticacao()
        {
            con = new MySqlConnection(b.Conex());
        }

        public void verificaLogin(String login, int senha, AutenticaForm form) {

            int Senhabd = senhaBanco(login);
            int TipoUser = tipoUser(login);
             
                if (Senhabd.Equals(senha))
                {
                    if (TipoUser == 1)
                    {
                        JanelaDoAdm adm = new JanelaDoAdm();
                        adm.Show();
                    }
                    else if (TipoUser == 2)
                    {
                        SistemaEscola.Formulários.Usuarios.Professor.Professor profForm = new Formulários.Usuarios.Professor.Professor();
                        profForm.getDados(dadosUserDAO.getProf(login));
                        profForm.Show();
                    }
                    else if (TipoUser == 3)
                    {
                        AlunoForm alunoForm = new AlunoForm();
                        alunoForm.getDados(dadosUserDAO.getAluno(login));
                        alunoForm.Show();
                    }

                    form.Close();
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha estão incorretos!");
                    form.txtSenha.Text = "";
                }
        }

        private int senhaBanco(String login)
        {
            int senhabd = 0;

            String SenhaCmd = "SELECT Senha FROM Login WHERE Login = '" + login + "'";

            MySqlCommand cmd = new MySqlCommand(SenhaCmd, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                senhabd = reader.GetInt32(0);
            }
            con.Close();
            return senhabd;
        }

        private int tipoUser(String login)
        {
            int tipoUser = 0;

            String UserCmd = "SELECT User_idUser FROM Login WHERE Login = '" + login + "'";

            MySqlCommand cmd2 = new MySqlCommand(UserCmd, con);
            con.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.Read())
            {
                tipoUser = reader2.GetInt32(0);
            }
            con.Close();
            return tipoUser;
        }
    }
}
