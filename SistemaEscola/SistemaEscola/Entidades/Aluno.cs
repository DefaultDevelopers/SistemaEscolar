using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Aluno
    {
        String  login, nome, senha, telefone, email, cpf;
        DateTime nascimento;

        public string Login
        {
            get
            {
                return login;
            }
            set
            {
                login = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }
            set
            {
                senha = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }
            set
            {
                nome = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }
            set
            {
                telefone = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        public string CPF
        {
            get
            {
                return cpf;
            }
            set
            {
                cpf = value;
            }
        }

        public DateTime Nascimento
        {
            get
            {
                return nascimento;
            }
            set
            {
                nascimento = value;
            }
        }
    }
}
