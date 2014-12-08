using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Frequencia
    {
        String idProf, idAluno, idDisciplina, idTurma;
        int falta;
        DateTime dataCriado, dataAula;

        public String IdProf
        {
            get { return idProf; }
            set { idProf = value; }
        }   

        public String IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }        

        public String IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }

        public String IdTurma
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
