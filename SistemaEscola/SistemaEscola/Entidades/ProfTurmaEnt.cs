using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class ProfTurmaEnt
    {
        String idTurma, profCod;

        public String IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }

        public String ProfCod
        {
            get { return profCod; }
            set { profCod = value; }
        }        
    }
}
