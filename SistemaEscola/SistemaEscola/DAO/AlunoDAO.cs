using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaEscola.Entidades;
using SistemaEscola.Classe;
using System.Windows.Forms;
using System.Data;

//Possui os métodos de acesso ao banco de dados do aluno
namespace SistemaEscola.DAO
{
    class AlunoDAO
    {
        Banco b = new Banco();

        //Salvar novo aluno
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
        //Retorna os dados de aluno na tela de alterar dados de aluno
        public void retornaAluno(MaskedTextBox txtCodAluno, TextBox txtNome, MaskedTextBox txtTel, TextBox txtEmail, MaskedTextBox txtNasc, MaskedTextBox txtCPF)
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
                txtNasc.Text = reader["data_nascimento"].ToString();
            }

            con.Close();
        }
        //Altera os dados do aluno
        public void alteraAluno(Aluno aluno, MaskedTextBox txtCodAluno)
        {
            String loginAluno = txtCodAluno.Text;
            
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "UPDATE Aluno SET nome = '" + aluno.Nome + "', email = '" + aluno.Email + "', cpf = '" + aluno.CPF + "', telefone = '" + aluno.Telefone + "', data_nascimento = '" + aluno.DataNasc + "' WHERE Login_Login = '" + loginAluno + "'";

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados de aluno alterados com sucesso.");
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
        //Pesquisa de aluno por código
        public void pesquisaAluno(DataGridView dgvDados, MaskedTextBox txtPorCod)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT nome as 'Nome', email as 'E-mail', cpf as 'CPF', telefone as 'Telefone', data_nascimento as 'Data de Nascimento' FROM Aluno WHERE Login_Login = '" + txtPorCod.Text + "'", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Você digitou o código?" + ex.Message);
            }


            con.Close();
        }
        //Pesquisa de aluno por nome
        public void pesquisaAluno(DataGridView dgvDados, TextBox txtPorNome)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("SELECT Login_Login as 'Matricula', nome as 'Nome', email as 'E-mail', cpf as 'CPF', telefone as 'Telefone', data_nascimento as 'Data de Nascimento' FROM Aluno WHERE nome LIKE '" + txtPorNome.Text + "'", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
            }
            catch (MySqlException es)
            {
                MessageBox.Show("Você digitou o nome?" + es.Message);
            }


            con.Close();
        }
    }
}
