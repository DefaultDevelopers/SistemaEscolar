using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Mensagem
    {
        String assunto, mensagem;
        DateTime dataCriada;       

        public String Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }        

        public String Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }        

        public DateTime DataCriada
        {
            get { return dataCriada; }
            set { dataCriada = value; }
        }       
    }
}
