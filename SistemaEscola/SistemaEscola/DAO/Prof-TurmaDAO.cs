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
    class Prof_TurmaDAO
    {
        Banco b = new Banco();

        public void salvar(ProfTurmaEnt profTurmaEnt)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            try
            {
                con.Open();
            }
            catch (MySqlException eo)
            {
                MessageBox.Show("Erro no banco de dados. Contate o provedor do seu sistema." + eo.Message);
            }

            cmd.CommandText = "INSERT INTO Professor_Turma (Professor_Login_Login, Turma_idTurma) values (@login, @idTurma)";
            cmd.Parameters.AddWithValue("@login", profTurmaEnt.ProfCod);
            cmd.Parameters.AddWithValue("@idTurma", profTurmaEnt.IdTurma);

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso!");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Você digitou um código de professor inexistente!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
                con.Close();
            }
        }

        public void pesquisaProfTurma(DataGridView dgvDados, MaskedTextBox txtCod)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("SELECT DISTINCT idProfTurma as 'ID do vínculo', Turma_idTurma as 'Turma' FROM Professor_Turma, Turma WHERE Professor_Login_Login = '" + txtCod.Text + "' AND Turma_idTurma = idTurma", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
                //Faz a coluna ID ser não editável
                dgvDados.Columns[0].ReadOnly = true;
            }
            catch (MySqlException es)
            {
                MessageBox.Show("Você não digitou o código." + es.Message);
            }

            con.Close();
        }

        public void deletaProfTurma(MaskedTextBox txtID)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            String ID = txtID.Text;

            con.Open();

            cmd.CommandText = "DELETE FROM Professor_Turma WHERE idProfTurma = " + ID;

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

        public void alteraProfTurma(DataGridView dgvDados, MaskedTextBox txtCodProf)
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
                    int idProfTurma = Convert.ToInt32(dgvDados.Rows[i].Cells[0].Value);
                    int Turma = Convert.ToInt32(dgvDados.Rows[i].Cells[1].Value);

                    cmd.CommandText = "UPDATE Professor_Turma SET Turma_idTurma = '" + Turma + "' WHERE Professor_Login_Login = '" + txtCodProf.Text + "' AND idProfTurma = '" + idProfTurma + "'";

                    cmd.Prepare();
                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Dados alterados com sucesso.");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Você digitou uma turma inexistente.");
            }
        }
    }
}
