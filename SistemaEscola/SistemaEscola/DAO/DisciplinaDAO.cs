using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using System.Windows.Forms;
using SistemaEscola.Entidades;

namespace SistemaEscola.DAO
{
    class DisciplinaDAO
    {
        public void salvarDisc(Disciplina disc)
        {
            Banco b = new Banco();
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
            }
            catch (MySqlException eo)
            {
                MessageBox.Show("Erro no banco de dados. Contate o provedor do seu sistema." + "\n" +eo.Message);
            }

            try
            {
                cmd.CommandText = "INSERT INTO Disciplina (idDisciplina, nome, carga_horaria, descricao) values (@idDisc, @nome, @cargaHor, @desc)";
                cmd.Parameters.AddWithValue("@idDisc", disc.IdDisciplina);
                cmd.Parameters.AddWithValue("@nome", disc.Nome);
                cmd.Parameters.AddWithValue("@cargaHor", disc.Carga_Hor);
                cmd.Parameters.AddWithValue("@desc", disc.Descricao);
            }
            catch (MySqlException ep)
            {
                MessageBox.Show("Ocorreu algum erro ao salvar." + "\n" + ep.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Disciplina cadastrada com sucesso.");
            }
            catch (MySqlException op)
            {
                MessageBox.Show("Erro ao salvar. Contate o provedor do seu banco de dados." + "\n" + op.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
