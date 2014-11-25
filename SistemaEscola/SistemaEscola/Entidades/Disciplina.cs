using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Disciplina
    {
        int idDisciplina, carga_hor;
        String nome, descricao;       

        public int IdDisciplina
        {
            get { return idDisciplina; }
            set { idDisciplina = value; }
        }         

        public int Carga_Hor
        {
            get { return carga_hor; }
            set { carga_hor = value; }
        }        

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }        

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }        
    }
}
