using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscola.Classe;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace SistemaEscola.DAO
{
    class TurmaDAO
    {

        Banco b = new Banco();

        public void salvarTurma(SistemaEscola.Entidades.Turma turma)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "INSERT INTO Turma (idTurma, Curso_idCurso, Turno_idTurno, Tipo_idTipo, sala) VALUES (@idTurma, @idCurso, @idTurno, @idTipo, @sala)";
                cmd.Parameters.AddWithValue("@idTurma", turma.IdTurma);  
                cmd.Parameters.AddWithValue("@idCurso", turma.IdCurso);
                cmd.Parameters.AddWithValue("@idTurno", turma.Turno);
                cmd.Parameters.AddWithValue("@idTipo", turma.Tipo);
                cmd.Parameters.AddWithValue("@sala", turma.Sala);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Cheque se digitou seus dados corretamente." + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Turma cadastrada com sucesso.");
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
