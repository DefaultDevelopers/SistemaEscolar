using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Tarefas
{
    public partial class AlterarTarefas : Form
    {
        public AlterarTarefas()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //A data em que a tarefa é criada é recuperada automaticamente
            //pela linha a seguir. Também vai ao banco.
            DateTime dataCriada = DateTime.Now.Date;
        }
    }
}
