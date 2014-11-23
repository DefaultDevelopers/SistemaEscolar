using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaEscola.Entidades;
using SistemaEscola.Classe;

namespace SistemaEscola.DAO
{
    class LoginDAO
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        Banco b = new Banco();

        public LoginDAO() {
        con = new MySqlConnection(b.Conex());
        }

        public void salvarLogin(Login login) {
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into Login (Login, Senha) values (@login, @senha)";
            cmd.Parameters.AddWithValue("@login", login.Log);
            cmd.Parameters.AddWithValue("@senha", login.Senha);


        }
    }
}
