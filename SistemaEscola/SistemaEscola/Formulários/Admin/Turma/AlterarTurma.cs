using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Turma
{
    public partial class AlterarTurma : Form
    {
        public AlterarTurma()
        {
            InitializeComponent();
        }

        private void btnDuvida_Click(object sender, EventArgs e)
        {
            PesquisarTurma pesqTurma = new PesquisarTurma();
            pesqTurma.ShowDialog();
        }
    }
}
