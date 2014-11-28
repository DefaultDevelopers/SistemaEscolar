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
        Banco b = new Banco();

        public void salvarAluno(Aluno aluno)
        {            
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            
            con.Open();

            try
            {
                cmd.CommandText = "INSERT INTO Aluno (Login_Login, nome, email, cpf, telefone, data_nascimento) VALUES (@login, @nome, @email, @cpf, @tel, @data)";
                cmd.Parameters.AddWithValue("@login", aluno.Login);
                cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@email", aluno.Email);
                cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
                cmd.Parameters.AddWithValue("@tel", aluno.Telefone);
                cmd.Parameters.AddWithValue("@data", aluno.DataNasc);
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
        }

        public void retornaAluno(MaskedTextBox txtCodAluno, TextBox txtNome, MaskedTextBox txtTel, TextBox txtEmail, DateTimePicker dtpNasc, MaskedTextBox txtCPF)
        {
            string loginAluno = txtCodAluno.Text;

            MySqlConnection con = new MySqlConnection(b.Conex());

            String AlunoCmd = "SELECT nome, email, cpf, telefone, data_nascimento FROM Aluno WHERE Login_Login = " + loginAluno;

            MySqlCommand cmd = new MySqlCommand(AlunoCmd, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtNome.Text = reader["nome"].ToString();
                txtEmail.Text = reader["email"].ToString();
                txtCPF.Text = reader["cpf"].ToString();
                txtTel.Text = reader["telefone"].ToString();
                dtpNasc.Value = Convert.ToDateTime(reader["data_nascimento"].ToString());
            }

            con.Close();
        }

        public void alteraAluno(Aluno aluno, MaskedTextBox txtCodAluno)
        {
            String loginAluno = txtCodAluno.Text;
            
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "UPDATE Aluno SET nome = '" + aluno.Nome + "', email = '" + aluno.Email + "', cpf = '" + aluno.CPF + "', telefone = '" + aluno.Telefone + "', data_nascimento = '" + aluno.DataNasc + "' WHERE Login_Login = '" + loginAluno + "'";
            }
            catch (MySqlException exp)
            {
                MessageBox.Show("Houve algum erro ao alterar. [Aluno]" + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
