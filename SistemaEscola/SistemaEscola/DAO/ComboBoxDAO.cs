using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using SistemaEscola.Classe;

namespace SistemaEscola.DAO
{
    class ComboBoxDAO
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

        public void comboCurso(ComboBox cmbCurso, int turno)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string command = "SELECT t.Curso_idCurso, c.nome FROM Turma=t, Curso=c WHERE t.Turno_idTurno = '" + turno + "' AND Curso_idCurso = idCurso";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome";
            cmbCurso.ValueMember = "Curso_idCurso";

            con.Close();

            cmbCurso.Text = "";
        }

        public void comboCurso(ComboBox cmbCurso)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string command = "SELECT idCurso, nome FROM Curso";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome";
            cmbCurso.ValueMember = "idCurso";

            con.Close();

            cmbCurso.Text = "";
        }

        public void comboTurma(ComboBox cmbTurma, String idCurso)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string command = "SELECT DISTINCT idTurma FROM Turma, Curso WHERE Curso_idCurso = '" + idCurso + "'";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            
            cmbTurma.DisplayMember = "idTurma";
            cmbTurma.ValueMember = "idTurma";
            cmbTurma.DataSource = dt;

            con.Close();

            cmbTurma.Text = "";
        }

        public void comboTurno(ComboBox cmbTurno, String tipo)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string command = "SELECT DISTINCT Turno_idTurno, turno FROM Turma, Turno WHERE Tipo_idTipo = '" + tipo + "' AND Turno_idTurno = idTurno";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTurno.DataSource = dt;
            cmbTurno.DisplayMember = "turno";
            cmbTurno.ValueMember = "Turno_idTurno";

            con.Close();

            cmbTurno.Text = "";
        }

        public void comboTurno(ComboBox cmbTurno)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string command = "SELECT turno, idTurno FROM Turno";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTurno.DataSource = dt;
            cmbTurno.DisplayMember = "turno";
            cmbTurno.ValueMember = "idTurno";

            con.Close();

            cmbTurno.Text = "";
        }

        public void comboDisc(ComboBox cmbDisc)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string command = "SELECT nome, idDisciplina FROM Disciplina";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbDisc.DataSource = dt;
            cmbDisc.DisplayMember = "nome";
            cmbDisc.ValueMember = "idDisciplina";

            con.Close();
        }
    }
}
