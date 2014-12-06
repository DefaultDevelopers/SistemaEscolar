using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Entidades;
using System.Data;

//Classe DAO para o vínculo de professor com disciplina ministrada
namespace SistemaEscola.DAO
{
    class Prof_DiscDAO
    {
        Banco b = new Banco();

        public void salvar(ProfDiscEnt profDiscEnt)
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

            cmd.CommandText = "INSERT INTO Professor_Disciplina (Professor_Login_Login, Disciplina_idDisciplina) values (@login, @idDisc)";
            cmd.Parameters.AddWithValue("@login", profDiscEnt.ProfCod);
            cmd.Parameters.AddWithValue("@idDisc", profDiscEnt.IdDisc);

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso!");
            }
            catch (MySqlException op)
            {
                MessageBox.Show("Código de professor errado!" + op.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void pesquisaProfDisc(DataGridView dgvDadosDisc, MaskedTextBox txtCod)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("SELECT DISTINCT idProfDisc as 'ID do vínculo', Disciplina_idDisciplina as 'Código da Disciplina', nome as 'Nome da disciplina' FROM Professor_Disciplina, Disciplina WHERE Professor_Login_Login = '" +  txtCod.Text + "' AND Disciplina_idDisciplina = idDisciplina", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDadosDisc.DataSource = DS.Tables[0];
            }
            catch (MySqlException es)
            {
                MessageBox.Show("Você não digitou o código." + es.Message);
            }

            con.Close();
        }

        public void deletaProfDisc(MaskedTextBox txtID)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            String ID = txtID.Text;

            con.Open();

            cmd.CommandText = "DELETE FROM Professor_Disciplina WHERE idProfDisc = '" + ID + "'";

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

        public void alteraProfDisc(ComboBox cmbDisc, MaskedTextBox txtID)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "UPDATE Professor_Disciplina SET Disciplina_idDisciplina = '" + cmbDisc.SelectedValue + "' WHERE idProfDisc = '" + txtID.Text + "'";
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
