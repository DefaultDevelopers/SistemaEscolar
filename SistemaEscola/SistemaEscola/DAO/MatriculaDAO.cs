using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using System.Data;
using System.Windows.Forms;
using SistemaEscola.Formulários.Admin.Matricula;
using SistemaEscola.Entidades;
using System;

namespace SistemaEscola.DAO
{
    class MatriculaDAO
    {

        Banco b = new Banco();

        public void comboTipo(ComboBox cmbTipo)
        {            
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            
            string command = "SELECT idTipo, tipo FROM Tipo";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);
            
            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTipo.DataSource = dt;
            cmbTipo.DisplayMember = "tipo";
            cmbTipo.ValueMember = "idTipo";
            
            con.Close();

            cmbTipo.Text = "";
        }

        public void comboCurso(ComboBox cmbCurso, int idTipo, int idTurno)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            
            string command = "SELECT nome, idCurso FROM Curso WHERE Tipo_idTipo = " + idTipo + " AND Turno_idTurno = " + idTurno;
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);
            
            con.Open();
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome";
            cmbCurso.ValueMember = "idCurso";
            
            con.Close();
           
            cmbCurso.Text = "Escolha o curso";
        }

        public void comboTurma(ComboBox cmbTurma, int idCurso)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;
            
            string command = "SELECT DISTINCT idTurma FROM Turma, Curso WHERE Curso_idCurso = " + idCurso;
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);
            
            con.Open();
            
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTurma.DataSource = dt;
            cmbTurma.DisplayMember = "idTurma";
            cmbTurma.ValueMember = "idTurma";
            
            con.Close();
            
            cmbTurma.Text = "Escolha a turma";
        }

        public void salvarMatricula(SistemaEscola.Entidades.Matricula matr)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();
            
            cmd.CommandText = "INSERT INTO Matricula (Aluno_Login_Login, Turma_idTurma) VALUES (@login, @idT)";
            cmd.Parameters.AddWithValue("@login", matr.Login);
            cmd.Parameters.AddWithValue("@idT", matr.IdTurma);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            
            con.Close();

            MessageBox.Show("Matrícula finalizada com sucesso!");
        }

        public void pesquisaMatricula(DataGridView dgvDados)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("SELECT idAluno as 'ID do Aluno', Login_Login as 'Matrícula', Turma_idTurma as 'Turma', nome as 'Nome', email as 'E-mail', cpf as 'CPF', telefone as 'Telefone', data_nascimento as 'Data de Nascimento', endereco as 'Endereço' FROM Login, Aluno, Matricula WHERE Login = Login_Login ORDER BY nome", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }
    }
}