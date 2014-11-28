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
        public void salvarLogin(Login login) {

            Banco b = new Banco();
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

            try
            {
                cmd.CommandText = "INSERT INTO Login (Login, Senha, User_idUser) values (@login, @senha, @user)";
                cmd.Parameters.AddWithValue("@login", login.Log);
                cmd.Parameters.AddWithValue("@senha", login.Senha);
                cmd.Parameters.AddWithValue("@user", login.User);                
            }
            catch (MySqlException ep)
            {
                MessageBox.Show("Login já existe. Por favor digite dígitos diferentes no campo." + ep.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("O Login foi salvo com sucesso.");
            }
            catch (MySqlException op) {
                MessageBox.Show("Erro ao salvar. Contate o provedor do seu banco de dados ou tente outro Login." + op.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
