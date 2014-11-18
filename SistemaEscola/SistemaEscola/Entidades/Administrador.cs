using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Administrador
    {
        String login;
        int senha;

        public String Login
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

        public int Senha
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
    }
}
