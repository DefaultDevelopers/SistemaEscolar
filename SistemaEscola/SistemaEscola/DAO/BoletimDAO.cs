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
    class BoletimDAO
    {
        Banco b = new Banco();

        public void salvarBoletim(DataGridView dgvCod, DataGridView dgvBoletim, BoletimEnt boletim, Form form)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                for (int i = 0; i < dgvBoletim.Rows.Count - 1; i++)
                {
                    cmd.Parameters.Clear();
                    String login = Convert.ToString(dgvCod.Rows[i].Cells[0].Value);
                    int turma = boletim.IdTurma;
                    int ano = DateTime.Now.Year;
                    int disc = boletim.IdDisc;
                    double nota1 = Convert.ToDouble(dgvBoletim.Rows[i].Cells[0].Value);
                    double nota2 = Convert.ToDouble(dgvBoletim.Rows[i].Cells[1].Value);
                    double nota3 = Convert.ToDouble(dgvBoletim.Rows[i].Cells[2].Value);
                    double nota4 = Convert.ToDouble(dgvBoletim.Rows[i].Cells[3].Value);

                    cmd.CommandText = "UPDATE Boletim SET nota1 = '"+ nota1 +"', nota2 = '" + nota2 + "', nota3 = '" + nota3 + "', nota4 = '" + nota4 + "', ano = '" + ano + "' WHERE Aluno_Login_Login = '" + login + "' AND Turma_idTurma = '" + turma + "' AND Disciplina_idDisciplina = '" + disc + "'";
                    
                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Notas inseridas com sucesso.");
                form.Close();
            }
            catch (MySqlException abc)
            {
                MessageBox.Show("Você digitou uma turma inexistente." +"\n\n"+abc.Message);
            }
        }

        public void pesquisaBoletim(DataGridView dgvDados, BoletimEnt boletim)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT nota1, nota2, nota3, nota4 FROM boletim where Disciplina_idDisciplina = '" + boletim.IdDisc + "' AND Turma_idTurma = '" + boletim.IdTurma + "'", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }

        public void pesquisaBoletimAluno(DataGridView dgvDados, BoletimEnt boletim)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT DISTINCT nome as 'Disciplina', nota1 as 'Nota 1º BM', nota2 as 'Nota 2º BM', nota3 as 'Nota 3º BM', nota4 as 'Nota 4º BM' FROM boletim, Disciplina WHERE Aluno_Login_Login = '" + boletim.Login + "' AND Turma_idTurma = '" + boletim.IdTurma + "' AND ano = '" + boletim.Ano + "' AND Disciplina_idDisciplina = idDisciplina", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }
        //Para mostrar os códigos dos alunos
        public void pesqCodigo(DataGridView dgvDados, BoletimEnt boletim)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT DISTINCT Aluno_Login_Login as 'Matrícula', nome as 'Nome' FROM aluno, matricula WHERE Turma_idTurma = '"+ boletim.IdTurma +"' AND Aluno_Login_Login = Login_Login", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }

        public void iniciarBoletim(DataGridView dgvDados, BoletimEnt boletim)
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
                    int turma = boletim.IdTurma;
                    int ano = DateTime.Now.Year;
                    int disc = boletim.IdDisc;

                    cmd.CommandText = "INSERT IGNORE INTO Boletim (Aluno_Login_Login, Turma_idTurma, Disciplina_idDisciplina, nota1, nota2, nota3, nota4, media, ano) VALUES (@login, @turma, @disc, 0, 0, 0, 0, 0, @ano)";
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@turma", turma);
                    cmd.Parameters.AddWithValue("@disc", disc);
                    cmd.Parameters.AddWithValue("@ano", ano);

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (MySqlException abc)
            {
                MessageBox.Show("Iniciar Boletim." + "\n\n" + abc.Message);
            }
        }
    }
}
