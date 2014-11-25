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

            //cmbCurso.Text = "Escolha o curso";
        }

        public void comboCurso(ComboBox cmbCurso)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string command = "SELECT nome, idCurso FROM Curso";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);

            con.Open();

            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome";
            cmbCurso.ValueMember = "idCurso";

            con.Close();

            //cmbCurso.Text = "Escolha o curso";
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

        public void comboTurno(ComboBox cmbTurno)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            string command = "SELECT idTurno, turno FROM Turno";
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
    }
}
