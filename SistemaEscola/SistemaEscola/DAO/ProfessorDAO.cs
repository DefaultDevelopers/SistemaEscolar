using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaEscola.Entidades;
using SistemaEscola.Classe;
using System.Windows.Forms;
using System.Data;

namespace SistemaEscola.DAO
{
    class ProfessorDAO
    {
        Banco b = new Banco();

        public void salvarProf(Professor professor)
        {            
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            cmd.CommandText = "INSERT INTO Professor (Login_Login, nome, email, cpf, telefone, data_nascimento, grau_formacao, formacao) VALUES (@login, @nome, @email, @cpf, @tel, @data, @grau, @formacao)";
            cmd.Parameters.AddWithValue("@login", professor.Login);
            cmd.Parameters.AddWithValue("@nome", professor.Nome);
            cmd.Parameters.AddWithValue("@email", professor.Email);
            cmd.Parameters.AddWithValue("@cpf", professor.CPF);
            cmd.Parameters.AddWithValue("@tel", professor.Telefone);
            cmd.Parameters.AddWithValue("@data", professor.DataNasc);
            cmd.Parameters.AddWithValue("@grau", professor.Grau_Form);
            cmd.Parameters.AddWithValue("@formacao", professor.Form);

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("O dados do professor foram salvos com sucesso.");
            }
            catch (MySqlException)
            {
                MessageBox.Show("Erro ao salvar dados de professor.");
            }

            con.Close();
        }
        //Retorna os dados de professor na tela de alterar dados de professor
        public void retornaProf(MaskedTextBox txtCodProf, TextBox txtNome, TextBox txtEmail, MaskedTextBox txtCPF, MaskedTextBox txtTel, TextBox txtForm, ComboBox cmbGrauForm, DateTimePicker dtpDataNasc)
        {
            string loginProf = txtCodProf.Text;

            MySqlConnection con = new MySqlConnection(b.Conex());

            String ProfCmd = "SELECT nome, email, cpf, data_nascimento, telefone, grau_formacao, formacao FROM Professor WHERE Login_Login = '" + loginProf + "'";

            MySqlCommand cmd = new MySqlCommand(ProfCmd, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtNome.Text = reader["nome"].ToString();
                txtEmail.Text = reader["email"].ToString();
                txtCPF.Text = reader["cpf"].ToString();
                txtTel.Text = reader["telefone"].ToString();
                txtForm.Text = reader["formacao"].ToString();
                cmbGrauForm.Text = reader["grau_formacao"].ToString();
                dtpDataNasc.Value = Convert.ToDateTime(reader["data_nascimento"].ToString());
            }

            con.Close();
        }

        public void alteraProf(Professor profEnt, MaskedTextBox txtCod)
        {
            String login = txtCod.Text;

            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "UPDATE Professor SET nome = '" + profEnt.Nome + "', email = '" + profEnt.Email + "', cpf = '" + profEnt.CPF + "', data_nascimento =  '" + profEnt.DataNasc + "', telefone = '" + profEnt.Telefone + "', grau_formacao = '" + profEnt.Grau_Form + "', formacao = '" + profEnt.Form + "'";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Houve algum erro ao alterar. [Professor]" + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados de professor alterados com sucesso.");
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

        public void pesquisaProf(DataGridView dgvDados, MaskedTextBox txtPorCod)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            try
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT nome as 'Nome', email as 'E-mail', cpf as 'CPF', telefone as 'Telefone', grau_formacao as 'Grau de Formação', formacao as 'Formação', data_nascimento as 'Data de Nascimento' FROM Professor WHERE Login_Login = '" + txtPorCod.Text + "'", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Você digitou o código?" + ex.Message);
            }


            con.Close();
        }

        public void pesquisaProf(DataGridView dgvDados, TextBox txtPorNome)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            try
            {
                MySqlDataAdapter mySqlDataAdapter;
                mySqlDataAdapter = new MySqlDataAdapter("SELECT Login_Login as 'Código', nome as 'Nome', email as 'E-mail', cpf as 'CPF', telefone as 'Telefone', grau_formacao as 'Grau de Formação', formacao as 'Formação', data_nascimento as 'Data de Nascimento' FROM Professor WHERE nome LIKE '" + txtPorNome.Text + "'", con);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dgvDados.DataSource = DS.Tables[0];
            }
            catch (MySqlException es)
            {
                MessageBox.Show("Você digitou o nome?" + es.Message);
            }


            con.Close();
        }
    }
}
