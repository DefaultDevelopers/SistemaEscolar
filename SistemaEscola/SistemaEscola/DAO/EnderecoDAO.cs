using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using SistemaEscola.Entidades;


namespace SistemaEscola.DAO
{
    class EnderecoDAO
    {
        Banco b = new Banco();

        public void salvarEnd(Endereco endEnt)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "INSERT INTO endereco (Login_Login, rua, bairro, num, estado, cidade, cep) VALUES (@login, @rua, @bairro, @num, @est, @cid, @cep)";
                cmd.Parameters.AddWithValue("@login", endEnt.Login);
                cmd.Parameters.AddWithValue("@rua", endEnt.Rua);
                cmd.Parameters.AddWithValue("@bairro", endEnt.Bairro);
                cmd.Parameters.AddWithValue("@num", endEnt.Num);
                cmd.Parameters.AddWithValue("@est", endEnt.Estado);
                cmd.Parameters.AddWithValue("@cid", endEnt.Cidade);
                cmd.Parameters.AddWithValue("@cep", endEnt.CEP);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Erro ao salvar endereço." + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("O endereço foi salvo com sucesso.");
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
        //Retorna os dados de endereço na tela de alterar dados de endereço
        public void retornaEnd(MaskedTextBox txtCodAluno, TextBox txtRua, TextBox txtBairro, TextBox txtNum, TextBox txtEstado, TextBox txtCidade, MaskedTextBox txtCEP)
        {
            string loginAluno = txtCodAluno.Text;

            MySqlConnection con = new MySqlConnection(b.Conex());

            String AlunoCmd = "SELECT rua, bairro, num, estado, cidade, cep FROM Endereco WHERE Login_Login = " + loginAluno;

            MySqlCommand cmd = new MySqlCommand(AlunoCmd, con);

            con.Open();

            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                txtRua.Text = reader["rua"].ToString();
                txtBairro.Text = reader["bairro"].ToString();
                txtNum.Text = reader["num"].ToString();
                txtEstado.Text = reader["estado"].ToString();
                txtCidade.Text = reader["cidade"].ToString();
                txtCEP.Text = reader["cep"].ToString();
            }

            con.Close();
        }

        public void alteraEnd(Endereco endEnt, MaskedTextBox txtCodAluno)
        {
            String login = txtCodAluno.Text;

            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "UPDATE endereco SET rua = '" + endEnt.Rua + "', bairro = '" + endEnt.Bairro + "', num = '" + endEnt.Num + "', estado = '" + endEnt.Estado + "', cidade = '" + endEnt.Cidade + "', cep = '" + endEnt.CEP + "' WHERE Login_Login = '" + login + "'";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Houve algum erro ao alterar. [Endereço]" + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Dados de endereço alterado com sucesso.");
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
