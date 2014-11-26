using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Curso
    {
        String nome, descricao;
        int idCurso;

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

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }       
    }
}
