using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Frequencia
    {
        int idAluno, idProfessor_Disciplina, idTurma, falta;
        DateTime dataCriado, dataAula;

        public int IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }        

        public int IdProfessor_Discpina
        {
            get { return idProfessor_Disciplina; }
            set { idProfessor_Disciplina = value; }
        }

        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }        

        public int Falta
        {
            get { return falta; }
            set { falta = value; }
        }        

        public DateTime DataCriado
        {
            get { return dataCriado; }
            set { dataCriado = value; }
        }        

        public DateTime DataAula
        {
            get { return dataAula; }
            set { dataAula = value; }
        }       
    }
}
