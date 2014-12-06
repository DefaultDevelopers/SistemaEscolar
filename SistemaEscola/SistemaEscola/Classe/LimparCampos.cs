using SistemaEscola.Formulários.Admin.Curso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Classe responsável pela limpeza dos campos do formulário
namespace SistemaEscola.Classe
{
    class LimparCampos
    {
        public void limpaCampos(Form Cont)
        {
            foreach (Control b in Cont.Controls)
            {
                if (b is TextBox)
                {
                    (b as TextBox).Clear();
                }
            }

            foreach (Control b in Cont.Controls)
            {
                if (b is MaskedTextBox)
                {
                    (b as MaskedTextBox).Clear();
                }
            }

            foreach (Control b in Cont.Controls)
            {
                if (b is ComboBox)
                {
                    (b as ComboBox).Text = "";
                }
            }
        }
    }
}
