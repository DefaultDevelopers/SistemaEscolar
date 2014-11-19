using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class Endereco
    {
        String rua, bairro, num, estado, cidade, cep;

        public String Rua 
        { 
            get {return rua;} 
            set {rua = value;} 
        }

        public String Bairro
        {
            get { return bairro; }
            set { bairro = value; }
        }

        public String Num
        {
            get { return num; }
            set { num = value; }
        }

        public String Estado
        {
            get { return estado; }
            set { estado = value; }
        }

        public String Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public String Rua
        {
            get { return cep; }
            set { cep = value; }
        }
    }
}
