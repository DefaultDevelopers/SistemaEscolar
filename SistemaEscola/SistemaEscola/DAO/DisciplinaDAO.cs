using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using System.Windows.Forms;
using SistemaEscola.Entidades;
using System.Data;

namespace SistemaEscola.DAO
{
    class DisciplinaDAO
    {
        Banco b = new Banco();

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

        public void pesqDisc(DataGridView dgvDados)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT idDisciplina as 'ID da Disciplina', nome as 'Nome', carga_horaria as 'Carga Horária (em horas aula)', descricao as 'Descrição' FROM Disciplina ORDER BY nome", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }

        public void deletaDisc(MaskedTextBox txtCodDel)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            String cod = txtCodDel.Text;

            con.Open();

            cmd.CommandText = "DELETE FROM Disciplina WHERE idDisciplina = '" + cod + "'";

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
