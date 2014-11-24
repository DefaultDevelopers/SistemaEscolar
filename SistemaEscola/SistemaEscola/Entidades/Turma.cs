using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Turma
    {
        int idTurma, idCurso;
        String nome;

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

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }        
    }
}
