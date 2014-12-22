using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using SistemaEscola.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.DAO
{
    class TarefaDAO
    {

        Banco b = new Banco();

        public void salvar (TarefaEnt tarefa)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "INSERT INTO Tarefa (Login_Login, inicio, fim, assunto, descricao) VALUES (@login, @dataInicio, @dataFim, @assunto, @descricao)";
            cmd.Parameters.AddWithValue("@login", tarefa.Login);
            cmd.Parameters.AddWithValue("@dataInicio", tarefa.DataCriada);
            cmd.Parameters.AddWithValue("@dataFim", tarefa.DataFim);
            cmd.Parameters.AddWithValue("@assunto", tarefa.Assunto);
            cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
            
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Tarefa salva com sucesso.");
            }
            catch (Exception exc)
            {
                MessageBox.Show("Houve um erro ao salvar a tarefa." + exc.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void pesquisar(DataGridView dgvDados, TarefaEnt tarefa)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT assunto as 'Assunto', descricao as 'Descrição', inicio as 'Data de Criação', fim as 'Data de Fim' FROM Tarefa WHERE Login_Login = '" + tarefa.Login + "'", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }


            con.Close();
        }

        public void pesquisarComID(DataGridView dgvDados, TarefaEnt tarefa)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT idTarefa as 'ID Da Tarefa', assunto as 'Assunto', descricao as 'Descrição', inicio as 'Data de Criação', fim as 'Data de Fim' FROM Tarefa WHERE Login_Login = '" + tarefa.Login + "'", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
                for (int i = 0; i < dgvDados.Rows.Count - 1; i++)
                {
                    dgvDados.Rows[i].Cells[0].ReadOnly = true;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro" + ex.Message);
            }


            con.Close();
        }

        public void alterar(DataGridView dgvTarefa, TarefaEnt tarefa)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                for (int i = 0; i < dgvTarefa.Rows.Count - 1; i++)
                {
                    cmd.Parameters.Clear();
                    String id = Convert.ToString(dgvTarefa.Rows[i].Cells[0].Value);
                    String assunto = Convert.ToString(dgvTarefa.Rows[i].Cells[1].Value);
                    String descricao = Convert.ToString(dgvTarefa.Rows[i].Cells[2].Value);
                    DateTime data_criado = Convert.ToDateTime(dgvTarefa.Rows[i].Cells[3].Value);
                    DateTime data_aula = Convert.ToDateTime(dgvTarefa.Rows[i].Cells[4].Value);

                    cmd.CommandText = "UPDATE Tarefa SET assunto = @assunto, descricao = @descricao, inicio = @datacriado, fim = @dataaula WHERE idTarefa = @idtarefa";                    
                    cmd.Parameters.AddWithValue("@assunto", assunto);
                    cmd.Parameters.AddWithValue("@descricao", descricao);
                    cmd.Parameters.AddWithValue("@datacriado", data_criado);
                    cmd.Parameters.AddWithValue("@dataaula", data_aula);
                    cmd.Parameters.AddWithValue("@idtarefa", id);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Tarefas alteradas com sucesso.");
            }
            catch (MySqlException abc)
            {
                MessageBox.Show("Você digitou uma turma inexistente." + "\n\n" + abc.Message);
            }
            catch (DataException eb)
            {
                MessageBox.Show("Você digitou uma data válida?" + "\n\n" + eb.Message);
            }
        }

        public void deletar(String ID)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "DELETE FROM Tarefa WHERE idTarefa = '" + ID + "'";

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deletado com sucesso.");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Houve algum erro ao deletar." + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
