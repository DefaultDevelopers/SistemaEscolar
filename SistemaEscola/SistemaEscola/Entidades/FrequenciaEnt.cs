using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    public class FrequenciaEnt
    {
        private String idAluno;
        private int falta, idTurma, idDisciplina;
        private DateTime dataCriado, dataAula;

        public String IdAluno
        {
            get { return idAluno; }
            set { idAluno = value; }
        }        

        public int IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
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
