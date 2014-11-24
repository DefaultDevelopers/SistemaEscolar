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
    class ProfessorDAO
    {   
        public void salvarProf(Professor professor)
        {
            Banco b = new Banco();
            MySqlConnection con = new MySqlConnection(b.Conex());
            MySqlCommand cmd = new MySqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into Professor (Login_Login, nome, email, cpf, telefone, data_nascimento, grau_formacao, formacao, endereco) values (@login, @nome, @email, @cpf, @tel, @data, @grau, @formacao, @endereco)";
            cmd.Parameters.AddWithValue("@login", professor.Login);
            cmd.Parameters.AddWithValue("@nm", professor.Nome);
            cmd.Parameters.AddWithValue("@email", professor.Email);
            cmd.Parameters.AddWithValue("@cpf", professor.CPF);
            cmd.Parameters.AddWithValue("@telefone", professor.Telefone);
            cmd.Parameters.AddWithValue("@data_nascimento", professor.DataNasc);
            cmd.Parameters.AddWithValue("@grau_formacao", professor.Grau_Form);
            cmd.Parameters.AddWithValue("@formacao", professor.Form);
            cmd.Parameters.AddWithValue("@endereco", professor.Endereco);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }
    }
}
