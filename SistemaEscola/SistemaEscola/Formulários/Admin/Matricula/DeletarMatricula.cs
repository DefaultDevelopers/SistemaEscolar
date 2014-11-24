using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using SistemaEscola.DAO;

namespace SistemaEscola.Formulários.Admin.Matricula
{
    public partial class DeletarMatricula : Form
    {
        public DeletarMatricula()
        {
            InitializeComponent();
        }

        MatriculaDAO matrDAO = new MatriculaDAO();

        private void btnDeletarMatr_Click(object sender, EventArgs e)
        {
            Banco b = new Banco();
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            String cod = txtCodDel.Text;

            con.Open();

            cmd.CommandText = "DELETE FROM Login WHERE Login = '" + cod + "'";

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

        private void DeletarMatricula_Load(object sender, EventArgs e)
        {
            matrDAO.pesquisaMatricula(dgvDados);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            matrDAO.pesquisaMatricula(dgvDados);
        }
    }
}
