using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin
{
    public partial class PesquisaUsuário : Form
    {
        public PesquisaUsuário()
        {
            InitializeComponent();
        }

        private void PesquisaUsuário_Load(object sender, EventArgs e)
        {
            txtDado.MaxLength = 10;
        }
    }
}
