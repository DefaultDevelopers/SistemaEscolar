using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Professor
    {
        private String login, nome, email, cpf, telefone, grau_form, form, endereco;
        private DateTime dataNasc;        

        public String Login
        {
            get { return login; }
            set { login = value; }
        }
        

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        public String CPF
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }

        public String Grau_Form
        {
            get { return grau_form; }
            set { grau_form = value; }
        }

        public String Form
        {
            get { return form; }
            set { form = value; }
        }
        public String Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
    }
}
