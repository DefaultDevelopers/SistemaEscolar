﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaEscola.Entidades;
using MySql.Data.MySqlClient;
using SistemaEscola.Formulários.Usuarios.AlunoForms;
using SistemaEscola.Formulários.Usuarios.Professor;
using System.Windows.Forms;
using SistemaEscola.Formulários;

namespace SistemaEscola.Classe
{
    class Autenticacao
    {
        Banco b = new Banco();
        private MySqlConnection con;
        FormPrincipal form = new FormPrincipal();

        public Autenticacao()
        {
            con = new MySqlConnection(b.Conex());
        }

        public void verificaLogin(String login, int senha) {

            int Senhabd = senhaBanco(login);
            int TipoUser = tipoUser(login);
            int i = 0;

            while (i == 0)
            {
                if (Senhabd.Equals(senha))
                {

                    if (TipoUser == 1)
                    {
                        JanelaDoAdm adm = new JanelaDoAdm();
                        adm.Show();
                        i = 1;
                    }
                    else if (TipoUser == 2)
                    {
                        SistemaEscola.Formulários.Usuarios.Professor.Professor prof = new Formulários.Usuarios.Professor.Professor();
                        prof.Show();
                        i = 1;
                    }
                    else if (TipoUser == 3)
                    {
                        AlunoForm aluno = new AlunoForm();
                        aluno.Show();
                        i = 1;
                    }
                }
                else
                {
                    MessageBox.Show("Usuário e/ou senha estão incorretos!");
                    i = 0;
                }
                break;
            }
        }

        private int senhaBanco(String login)
        {
            int senhabd = 0;

            String SenhaCmd = "SELECT Senha FROM Login WHERE Login = '" + login + "'";

            MySqlCommand cmd = new MySqlCommand(SenhaCmd, con);
            con.Open();
            MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                senhabd = reader.GetInt32(0);
            }
            con.Close();
            return senhabd;
        }

        private int tipoUser(String login)
        {
            int tipoUser = 0;

            String UserCmd = "SELECT idUser FROM Login WHERE Login = '" + login + "'";

            MySqlCommand cmd2 = new MySqlCommand(UserCmd, con);
            con.Open();
            MySqlDataReader reader2 = cmd2.ExecuteReader();

            if (reader2.Read())
            {
                tipoUser = reader2.GetInt32(0);
            }
            con.Close();
            return tipoUser;
        }
    }
}
