using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Classe
{
    class Banco
    {
        private String conexao = "server=localhost;userid=root;password=1124;database=sistemaescolar";

        public String Conex()
        {
            return conexao;
        }
    }
}
