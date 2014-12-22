using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Entidades;
using SistemaEscola.Classe;

namespace SistemaEscola.DAO
{
    class FrequenciaDAO
    {
        Banco b = new Banco();

        public void inserirFrequencia(Frequencia freq)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "INSERT INTO Frequencia (Aluno_Login_Login,Turma_idTurma,Disciplina_idDisciplina, data_aula, falta, data_criado) VALUES (@AlunoLogin, @Turma, @Disciplina, @dataAula, @falta, @dataCriado)";
                cmd.Parameters.AddWithValue("@AlunoLogin", freq.IdAluno);
                cmd.Parameters.AddWithValue("@Turma", freq.IdTurma);
                cmd.Parameters.AddWithValue("@Disciplina", freq.IdDisciplina);
                cmd.Parameters.AddWithValue("@dataAula", freq.DataAula);
                cmd.Parameters.AddWithValue("@falta", freq.Falta);
                cmd.Parameters.AddWithValue("@dataCriado", freq.DataCriado);
                //Lembrar: falta mudar no banco e adicionar idDisciplina (fk de Disciplina) à tabela Frequencia
            }
            catch (Exception exp)
            {
                MessageBox.Show("Cheque se digitou seus dados corretamente." + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Cadastro de curso realizado com sucesso.");
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
    }
}
