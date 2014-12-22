using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    public class DadosUsuarioEnt
    {
        private String nome, email, telefone, login;
        private int idTurma;

        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        } 

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

        public String Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
