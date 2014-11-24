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
    class AlunoDAO
    {
        public void salvarAluno(Aluno aluno)
        {
            Banco b = new Banco();
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            
            con.Open();

            try
            {
                cmd.CommandText = "INSERT INTO Aluno (Login_Login, nome, email, cpf, telefone, data_nascimento, endereco) VALUES (@login, @nome, @email, @cpf, @tel, @data, @end)";
                cmd.Parameters.AddWithValue("@login", aluno.Login);
                cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@email", aluno.Email);
                cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
                cmd.Parameters.AddWithValue("@tel", aluno.Telefone);
                cmd.Parameters.AddWithValue("@data", aluno.DataNasc);
                cmd.Parameters.AddWithValue("@end", aluno.Endereco);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Cheque se digitou seus dados corretamente." + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                con.Close();
            }

            MessageBox.Show("Tudo certo com os dados do aluno. Siga para o próximo passo.");
        }


    }
}
