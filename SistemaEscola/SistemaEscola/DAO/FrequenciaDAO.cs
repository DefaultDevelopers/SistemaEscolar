using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Entidades;
using SistemaEscola.Classe;
using System.Data;

namespace SistemaEscola.DAO
{
    class FrequenciaDAO
    {
        Banco b = new Banco();

        public void inserirFrequencia(DataGridView dgvCod, DataGridView dgvFrequencia, FrequenciaEnt freq, Form form)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                for (int i = 0; i < dgvFrequencia.Rows.Count - 1; i++)
                {
                    cmd.Parameters.Clear();
                    String login = Convert.ToString(dgvCod.Rows[i].Cells[0].Value);
                    int falta = Convert.ToInt32(dgvFrequencia.Rows[i].Cells[0].Value);
                    int turma = freq.IdTurma;
                    int disc = freq.IdDisciplina;
                    DateTime data_criado = freq.DataCriado;
                    DateTime data_aula = freq.DataAula;

                    cmd.CommandText = "UPDATE Frequencia SET falta = '" + falta + "', data_aula = @dataaula, data_criado = @datacriado WHERE Aluno_Login_Login = '" + login + "' AND Turma_idTurma = '" + turma + "' AND Disciplina_idDisciplina = '" + disc + "'";
                    cmd.Parameters.AddWithValue("@dataaula", data_aula);
                    cmd.Parameters.AddWithValue("@datacriado", data_criado);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Frequência adicionada com sucesso.");
                form.Close();                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Frequência" + "\n\n" + exc.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void pesqCodigo(DataGridView dgvDados, FrequenciaEnt frequencia)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT DISTINCT Aluno_Login_Login as 'Matrícula', nome as 'Nome' FROM aluno, matricula WHERE Turma_idTurma = '" + frequencia.IdTurma + "' AND Aluno_Login_Login = Login_Login", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }

        public void iniciarFrequencia(DataGridView dgvDados, FrequenciaEnt frequencia)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                for (int i = 0; i < dgvDados.Rows.Count - 1; i++)
                {
                    cmd.Parameters.Clear();
                    String login = Convert.ToString(dgvDados.Rows[i].Cells[0].Value);
                    int turma = frequencia.IdTurma;
                    int disc = frequencia.IdDisciplina;

                    cmd.CommandText = "INSERT IGNORE INTO Frequencia (Aluno_Login_Login, Turma_idTurma, Disciplina_idDisciplina, data_aula, data_criado, falta) VALUES (@login, @turma, @disc, null, null, 0)";
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@turma", turma);
                    cmd.Parameters.AddWithValue("@disc", disc);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException abc)
            {
                MessageBox.Show("Iniciar Boletim." + "\n\n" + abc.Message);
            }
        }

        public void pesquisaFrequencia(DataGridView dgvDados, FrequenciaEnt frequencia)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT falta FROM Frequencia WHERE Disciplina_idDisciplina = '" + frequencia.IdDisciplina + "' AND Turma_idTurma = '" + frequencia.IdTurma + "'", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }

        public void pesquisaFrequenciaAluno(DataGridView dgvDados, FrequenciaEnt frequencia)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT nome as 'Disciplina', falta as 'Total de Faltas' FROM Frequencia, Disciplina WHERE Disciplina_idDisciplina = idDisciplina AND Turma_idTurma = '" + frequencia.IdTurma + "' AND Aluno_Login_Login = '" + frequencia.IdAluno + "'", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }
    }
}
