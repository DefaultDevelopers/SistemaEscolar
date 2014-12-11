using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class TurmaEnt
    {
        int idTurma, idCurso, turno, tipo;
        String sala;


        public int Turno
        {
            get { return turno; }
            set { turno = value; }
        }

        public int Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }        

        public int IdCurso
        {
            get { return idCurso; }
            set { idCurso = value; }
        }

        public String Sala
        {
            get { return sala; }
            set { sala = value; }
        }        
    }
}
