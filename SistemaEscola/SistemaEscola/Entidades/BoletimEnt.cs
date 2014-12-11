using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEscola.Entidades
{
    class BoletimEnt
    {
        String alunoLogin, profLogin;
        int idTurma, idDisc, ano;
        Double nota1, nota2, nota3, nota4, media;

        public String AlunoLogin
        {
            get { return alunoLogin; }
            set { alunoLogin = value; }
        }

        public String ProfLogin
        {
            get { return profLogin; }
            set { profLogin = value; }
        }

        public int IdTurma
        {
            get { return idTurma; }
            set { idTurma = value; }
        }
        
        public int IdDisc
        {
            get { return idDisc; }
            set { idDisc = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public Double Nota1
        {
            get { return nota1; }
            set { nota1 = value; }
        }

        public Double Nota2
        {
            get { return nota2; }
            set { nota2 = value; }
        }

        public Double Nota3
        {
            get { return nota3; }
            set { nota3 = value; }
        }

        public Double Nota4
        {
            get { return nota4; }
            set { nota4 = value; }
        }

        public Double Media
        {
            get { return media; }
            set { media = value; }
        }
    }
}
