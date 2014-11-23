using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SistemaEscola.DAO
{
    class DisciplinaDAO
    {

        private MySqlConnection con;
        private MySqlCommand cmd;
        
        public DisciplinaDAO()
        {
            string conexao = "server=localhost;userid=root;password=1124;database=sistemaescolar";
            con = new MySqlConnection(conexao);
        }


    }
}
