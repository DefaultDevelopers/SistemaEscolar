using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using SistemaEscola.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.DAO
{
    class DadosDeUsuarioDAO
    {
        Banco b = new Banco();

        public DadosUsuarioEnt getAluno(String login)
        {
            DadosUsuarioEnt dadosUserEnt = new DadosUsuarioEnt();
            String loginPesq = login;

            MySqlConnection con = new MySqlConnection(b.Conex());

            String AlunoCmd = "SELECT Login_Login, nome, email, cpf, telefone, Turma_idTurma FROM Aluno, Matricula WHERE Aluno_Login_Login = Login_Login AND Login_Login = '" + loginPesq + "'";

            MySqlCommand cmd = new MySqlCommand(AlunoCmd, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dadosUserEnt.Login = reader["Login_Login"].ToString();
                dadosUserEnt.Nome = reader["nome"].ToString();
                dadosUserEnt.Email = reader["email"].ToString();
                dadosUserEnt.Telefone = reader["telefone"].ToString();
                dadosUserEnt.IdTurma = Convert.ToInt32(reader["Turma_idTurma"].ToString());
            }

            con.Close();

            return dadosUserEnt;
        }

        public DadosUsuarioEnt getProf(String login)
        {
            DadosUsuarioEnt dadosUserEnt = new DadosUsuarioEnt();
            String loginPesq = login;

            MySqlConnection con = new MySqlConnection(b.Conex());

            String AlunoCmd = "SELECT Login_Login, nome, email, cpf, telefone FROM Professor WHERE Login_Login = '" + loginPesq + "'";

            MySqlCommand cmd = new MySqlCommand(AlunoCmd, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                dadosUserEnt.Login = reader["Login_Login"].ToString();
                dadosUserEnt.Nome = reader["nome"].ToString();
                dadosUserEnt.Email = reader["email"].ToString();
                dadosUserEnt.Telefone = reader["telefone"].ToString();
            }

            con.Close();

            return dadosUserEnt;
        }
    }
}
