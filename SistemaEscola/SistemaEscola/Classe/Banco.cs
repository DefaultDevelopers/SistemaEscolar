using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Classe de conexão do banco
namespace SistemaEscola.Classe
{
    class Banco
    {
        private static String conexao = "server=localhost;userid=root;password=;database=sistemaescolar";

        public String Conex()
        {
            return conexao;
        }
    }
}
