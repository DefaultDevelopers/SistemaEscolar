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
    }
}