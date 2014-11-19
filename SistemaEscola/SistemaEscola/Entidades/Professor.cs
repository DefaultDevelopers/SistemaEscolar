using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Professor
    {
        private String nome, email, cpf, telefone, grau_form, form;
        private DateTime dataNasc;

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

        public String Cpf
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

        public DateTime DataNasc
        {
            get { return dataNasc; }
            set { dataNasc = value; }
        }
    }
}
