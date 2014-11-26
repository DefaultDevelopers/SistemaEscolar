using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscola.Classe;
using MySql.Data.MySqlClient;
using SistemaEscola.Entidades;
using System.Windows.Forms;

namespace SistemaEscola.DAO
{
    class CursoDAO
    {

        Banco b = new Banco();

        public void salvarCurso(Curso curso)
        {            
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "INSERT INTO Curso (idCurso, nome, descricao) VALUES (@idCurso, @nome, @desc)";
                cmd.Parameters.AddWithValue("@idCurso", curso.IdCurso);
                cmd.Parameters.AddWithValue("@nome",curso.Nome);
                cmd.Parameters.AddWithValue("@desc", curso.Descricao);
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
