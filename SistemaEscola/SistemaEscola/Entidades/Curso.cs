using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Curso
    {
        String tipo, turno, curso, descricao;        

        public String Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        public String Turno
        {
            get { return turno; }
            set { turno = value; }
        }        

        public String Cursos
        {
            get { return curso; }
            set { curso = value; }
        }

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }       
    }
}
