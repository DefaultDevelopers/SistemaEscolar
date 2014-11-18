using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Professor
{
    public partial class CadastrarProf : Form
    {
        public CadastrarProf()
        {
            InitializeComponent();
        }

        private void CadastrarProf_Load(object sender, EventArgs e)
        {
            int ano = DateTime.Now.Year;
            txtLoginAno.Text = Convert.ToString(ano);
        }
    }
}
