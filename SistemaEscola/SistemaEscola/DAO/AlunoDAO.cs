using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using SistemaEscola.Entidades;
using SistemaEscola.Classe;

namespace SistemaEscola.DAO
{
    class AlunoDAO
    {
        private MySqlConnection con;
        private MySqlCommand cmd;
        Banco b = new Banco();

        public AlunoDAO()
        {
            con = new MySqlConnection(b.Conex());
        }

        public void salvarMatricula(Aluno aluno)
        {
            cmd.Connection = con;
            cmd.CommandText = "INSERT INTO Aluno (LoginAluno, nome, email, cpf, telefone, data_nascimento, endereco) VALUES (@login, @nome, @email, @cpf, @tel, @data, @endereco)";
            cmd.Parameters.AddWithValue("@login", aluno.Login);
            cmd.Parameters.AddWithValue("@nome", aluno.Nome);
            cmd.Parameters.AddWithValue("@email", aluno.Email);
            cmd.Parameters.AddWithValue("@cpf", aluno.CPF);
            cmd.Parameters.AddWithValue("@tel", aluno.Telefone);
            cmd.Parameters.AddWithValue("@data", aluno.DataNasc);
            cmd.Parameters.AddWithValue("@endereco", aluno.Endereco);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }


    }
}
