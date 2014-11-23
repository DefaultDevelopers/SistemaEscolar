using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using System.Data;
using System.Windows.Forms;

namespace SistemaEscola.DAO
{
    class MatriculaDAO
    {

        private MySqlConnection con;
        private MySqlConnection con2;
        //private MySqlCommand cmd;
        Banco b = new Banco();

        public MatriculaDAO()
        {
            con = new MySqlConnection(b.Conex());
            //con2 = new MySqlConnection(b.Conex());
        }
      

        public void comboTipo(ComboBox cmbTipo, String turno)
        {
            
            string command = "SELECT idTipo, tipo FROM Tipo";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbTipo.DataSource = dt;
            cmbTipo.DisplayMember = "tipo";
            cmbTipo.ValueMember = "idTipo";
            con.Close();
        }

        public void comboCurso(ComboBox cmbCurso)
        {
            string command = "SELECT nome, idCurso FROM Curso";
            MySqlDataAdapter da = new MySqlDataAdapter(command, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            cmbCurso.DataSource = dt;
            cmbCurso.DisplayMember = "nome";
            cmbCurso.ValueMember = "idCurso";
            con.Close();
        }
    }
}
