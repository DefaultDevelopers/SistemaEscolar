using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Aluno
    {
        String  login, nome, telefone, email, cpf, endereco;
        DateTime dataNasc;
        int senha;    

        public String Login
        {
            get { return login; }
            set { login = value; }
        }

        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }        

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }       

        public int Senha
        {
            get { return senha; }
            set { senha = value; }
        }
        
    }
}