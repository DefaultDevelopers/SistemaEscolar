﻿using MySql.Data.MySqlClient;
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

        public void salvarMatricula(SistemaEscola.Entidades.Matricula matr, String login, int senha)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();
            
            cmd.CommandText = "INSERT INTO Matricula (Aluno_Login_Login, Turma_idTurma) VALUES (@login, @idT)";
            cmd.Parameters.AddWithValue("@login", matr.Login);
            cmd.Parameters.AddWithValue("@idT", matr.IdTurma);
            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Matrícula finalizada com sucesso! Guarde os dados do usuário com cuidado." + "\n\n" + "Login: " + login + "\n" +"Senha: " + senha);
            }
            catch (Exception el)
            {
                MessageBox.Show("Erro ao matricular." + el.Message);
            }
            finally
            {
                con.Close();
            }                
        }

        public void pesquisaMatricula(DataGridView dgvDados)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());

            con.Open();

            MySqlDataAdapter mySqlDataAdapter;
            mySqlDataAdapter = new MySqlDataAdapter("Select * from matricula", con);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            dgvDados.DataSource = DS.Tables[0];


            con.Close();
        }

        public void deletaMatricula(MaskedTextBox txtIDMatr)
        {
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            String ID = txtIDMatr.Text;

            con.Open();

            cmd.CommandText = "DELETE FROM Matricula WHERE idMatricula = '" + ID + "'";

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

        public void alteraMatricula(MaskedTextBox txtCodAluno, SistemaEscola.Entidades.Matricula matrEnt)
        {
            String loginAluno = txtCodAluno.Text;

            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            con.Open();

            try
            {
                cmd.CommandText = "UPDATE Matricula SET Turma_idTurma = '" + matrEnt.IdTurma + "' WHERE Aluno_Login_Login = '" + loginAluno + "'";
            }
            catch (Exception exp)
            {
                MessageBox.Show("Houve algum erro ao alterar. [Matrícula]" + exp.Message);
            }

            try
            {
                cmd.Prepare();
                cmd.ExecuteNonQuery();
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