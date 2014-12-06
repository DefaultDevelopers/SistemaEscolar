using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Login
    {
        private String login, crip;
        private int senha, user;

        public String Log
        {
            get { return login; }
            set { login = value; }
        }

        public String Crip
        {
            get { return crip; }
            set { crip = value; }
        }

        public int Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public int User
        {
            get { return user; }
            set { user = value; }
        }  
    }
}
