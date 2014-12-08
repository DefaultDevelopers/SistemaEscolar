using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaEscola.Entidades;
using SistemaEscola.Classe;
using System.Windows.Forms;

namespace SistemaEscola.DAO
{
    class LoginDAO
    {
        Banco b = new Banco();

        public Boolean salvarLogin(Login login) {            
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
            }
            catch (MySqlException eo)
            {
                MessageBox.Show("Erro no banco de dados. Contate o provedor do seu sistema." + eo.Message);
            }

            cmd.CommandText = "INSERT INTO Login (Login, Senha, User_idUser) values (@login, @senha, @user)";
            cmd.Parameters.AddWithValue("@login", login.Log);
            cmd.Parameters.AddWithValue("@senha", login.Senha);
            cmd.Parameters.AddWithValue("@user", login.User);

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Login foi salvo com sucesso.");
                return true;
            }
            catch (MySqlException op) {
                MessageBox.Show("O login que você digitou já está cadastrado no sistema. Tente outro." + "\n" + op.Message);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}