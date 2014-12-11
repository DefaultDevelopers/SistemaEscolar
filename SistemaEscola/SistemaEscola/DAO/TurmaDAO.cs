using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscola.Classe;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using SistemaEscola.Entidades;

namespace SistemaEscola.DAO
{
    class TurmaDAO
    {

        Banco b = new Banco();

        public void salvarTurma(SistemaEscola.Entidades.TurmaEnt turma)
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
        //Pesquisa de turma baseado no curso
        public void pesquisaTurma(DataGridView dgvDados, ComboBox cmbCurso)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT idTurma as 'Turma', Curso_idCurso as 'ID do Curso', turno as 'Turno', tipo as 'Tipo', sala as 'Sala' FROM Turma, Turno, Tipo WHERE Tipo_idTipo = idTipo AND Turno_idTurno = idTurno AND Curso_idCurso = '" + cmbCurso.SelectedValue + "'", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro." + ex.Message);
            }


            con.Close();
        }
        //Pesquisa de turma baseado no código da turma
        public void pesquisaTurma(DataGridView dgvDados)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT idTurma as 'Turma', nome as 'Curso', turno as 'Turno', tipo as 'Tipo', sala as 'Sala' FROM Turma, Curso, Turno, Tipo WHERE Tipo_idTipo = idTipo AND Turno_idTurno = idTurno AND Curso_idCurso = idCurso", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro." + ex.Message);
            }


            con.Close();
        }

        public void pesquisaTurma(DataGridView dgvDados, MaskedTextBox txtCodTurma)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT nome as 'Curso', turno as 'Turno', tipo as 'Tipo', sala as 'Sala' FROM Turma, Curso, Turno, Tipo WHERE Tipo_idTipo = idTipo AND Turno_idTurno = idTurno AND Curso_idCurso = idCurso AND idTurma = '" + txtCodTurma.Text + "'", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro." + ex.Message);
            }


            con.Close();
        }

        public void retornaTurma(MaskedTextBox txtCodTurma, ComboBox cmbCurso, ComboBox cmbTurno, ComboBox cmbTipo, TextBox sala)
        {
            string loginAluno = txtCodTurma.Text;

            MySqlConnection con = new MySqlConnection(b.Conex());

            String TurmaCmd = "SELECT nome, turno, tipo, sala FROM Turma, Curso, Tipo, Turno WHERE Turno_idTurno = idTurno AND Tipo_idTipo = idTipo AND Curso_idCurso = idCurso AND idTurma = '" + txtCodTurma.Text + "'";

            MySqlCommand cmd = new MySqlCommand(TurmaCmd, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                cmbCurso.Text = reader["nome"].ToString();
                cmbTurno.Text = reader["turno"].ToString();
                cmbTipo.Text = reader["tipo"].ToString();
                sala.Text = reader["sala"].ToString();
            }

            con.Close();
        }

        public void alteraTurma(TurmaEnt turma)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();
          
            cmd.CommandText = "UPDATE Turma SET Curso_idCurso = '" + turma.IdCurso + "', Turno_idTurno = '" + turma.Turno + "', Tipo_idTipo = '" + turma.Tipo + "', sala = '" + turma.Sala + "' WHERE idTurma = '" + turma.IdTurma + "'";
            

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Sucesso.");
            }
            catch (MySqlException exc)
            {
                MessageBox.Show("Houve algum erro ao alterar. [Turma]" + exc.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void deletaTurma(MaskedTextBox txtCodTurma)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            String ID = txtCodTurma.Text;

            con.Open();

            cmd.CommandText = "DELETE FROM Turma WHERE idTurma = '" + ID + "'";

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
