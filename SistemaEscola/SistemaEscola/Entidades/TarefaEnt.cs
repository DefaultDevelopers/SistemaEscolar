using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class TarefaEnt
    {
        DateTime dataCriada, dataFim;
        String assunto, descricao, login;

        public String Login
        {
            get { return login; }
            set { login = value; }
        }   

        public String Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }        

        public String Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }        

        public DateTime DataCriada
        {
            get { return dataCriada; }
            set { dataCriada = value; }
        }        

        public DateTime DataFim
        {
            get { return dataFim; }
            set { dataFim = value; }
        }
        
        
        
    }
}
