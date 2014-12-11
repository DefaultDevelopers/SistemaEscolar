using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class MatriculaEnt
    {
        private int idTurma;
        private String login;       

        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma= value; }
        }

        public String Login
        {
            get { return login; }
            set { login = value; }
        }        
    }
}
