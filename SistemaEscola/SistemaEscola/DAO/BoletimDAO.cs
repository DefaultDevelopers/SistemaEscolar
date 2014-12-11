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

        public void salvarBoletim(BoletimEnt boletim)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "INSERT INTO Boletim (Aluno_Login_Login, Professor_Login_Login, Turma_idTurma, Disciplina_idDisciplina, ano, nota1, nota2, nota3, nota4, media) values (@Alunologin, null, @idTurma, null, null, null, null, null, null, null);";
            cmd.Parameters.AddWithValue("@Alunologin", boletim.AlunoLogin);
            cmd.Parameters.AddWithValue("@idTurma", boletim.IdTurma);
            
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Boletim" + "\n\n" + exc.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void pesquisaBoletim(DataGridView dgvDados, BoletimEnt boletim)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT Aluno_Login_Login as 'Matrícula', nome as 'Nome', nota1 as 'Nota 1º BM', nota2 as 'Nota 2º BM', nota3 as 'Nota 3º BM', nota4 as 'Nota 4º BM', media as 'Média' FROM Boletim, Aluno WHERE Login_Login = Aluno_Login_Login AND Turma_idTurma = '" + boletim.IdTurma + "' ORDER BY nome", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }
    }
}
