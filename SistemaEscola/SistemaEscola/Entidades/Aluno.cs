using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Aluno
    {
        String  nome, telefone, email, cpf;
        DateTime DataNasc;

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
                return DataNasc;
            }
            set
            {
                DataNasc = value;
            }
        }
    }
}