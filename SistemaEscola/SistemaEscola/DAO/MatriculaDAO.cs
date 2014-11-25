using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using System.Data;
using System.Windows.Forms;
using SistemaEscola.Formulários.Admin.Matricula;
using SistemaEscola.Entidades;
using System;

namespace SistemaEscola.DAO
{
    class MatriculaDAO
    {

        Banco b = new Banco();

        

        public void salvarMatricula(SistemaEscola.Entidades.Matricula matr, String login, int senha)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();
            
            cmd.CommandText = "INSERT INTO Matricula (Aluno_Login_Login, Turma_idTurma) VALUES (@login, @idT)";
            cmd.Parameters.AddWithValue("@login", matr.Login);
            cmd.Parameters.AddWithValue("@idT", matr.IdTurma);
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Matrícula finalizada com sucesso! Guarde os dados do usuário com cuidado." + "\n" + "Login: " + login + "Senha: " + senha);
            }
            catch (Exception el)
            {
                MessageBox.Show("Erro ao matricular." + el.Message);
            }
            finally
            {
                con.Close();
            }                
        }

        public void pesquisaMatricula(DataGridView dgvDados)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT idAluno as 'ID do Aluno', Login_Login as 'Matrícula', Turma_idTurma as 'Turma', nome as 'Nome', email as 'E-mail', cpf as 'CPF', telefone as 'Telefone', data_nascimento as 'Data de Nascimento', endereco as 'Endereço' FROM Login, Aluno, Matricula WHERE Login = Login_Login ORDER BY nome", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }
    }
}