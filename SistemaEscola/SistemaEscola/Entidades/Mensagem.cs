using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Mensagem
    {
        String assunto, mens;
        DateTime dataCriada;       

        public String Assunto
        {
            get { return assunto; }
            set { assunto = value; }
        }        

        public String Mens
        {
            get { return mens; }
            set { mens = value; }
        }        

        public DateTime DataCriada
        {
            get { return dataCriada; }
            set { dataCriada = value; }
        }       
    }
}
