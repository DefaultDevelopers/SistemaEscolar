using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscola.Classe;
using MySql.Data.MySqlClient;
using SistemaEscola.Entidades;
using System.Windows.Forms;
using System.Data;

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

        public void pesquisaCurso(DataGridView dgvDados)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("Select idCurso as 'ID do Curso', nome as 'Nome', descricao as 'Descrição' FROM Curso ORDER BY nome", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }

        public void deletaCurso(MaskedTextBox txtCodCurso)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            String ID = txtCodCurso.Text;

            con.Open();

            cmd.CommandText = "DELETE FROM Curso WHERE idCurso = '" + ID + "'";

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

        public void retornaCurso(MaskedTextBox txtCodCurso, TextBox txtNome, TextBox txtDescricao)
        {
            string idCurso = txtCodCurso.Text;

            MySqlConnection con = new MySqlConnection(b.Conex());

            String CursoCmd = "SELECT nome, descricao FROM Curso WHERE idCurso = '" + idCurso + "'";

            MySqlCommand cmd = new MySqlCommand(CursoCmd, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtNome.Text = reader["nome"].ToString();
                txtDescricao.Text = reader["descricao"].ToString();
            }

            con.Close();
        }

        public void alteraCurso(Curso curso, MaskedTextBox txtCodCurso)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "UPDATE Curso SET nome = '" + curso.Nome + "', descricao = '" + curso.Descricao + "' WHERE idCurso = '" + txtCodCurso.Text + "'";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Houve algum erro ao alterar." + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados de curso alterados com sucesso.");
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
