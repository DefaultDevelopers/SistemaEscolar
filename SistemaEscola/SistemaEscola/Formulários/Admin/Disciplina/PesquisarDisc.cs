using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.DAO;

namespace SistemaEscola.Formulários.Admin.Disciplina
{
    public partial class PesquisarDisc : Form
    {
        public PesquisarDisc()
        {
            InitializeComponent();
        }

        DisciplinaDAO discDAO = new DisciplinaDAO();

        private void PesquisarDisc_Load(object sender, EventArgs e)
        {
            discDAO.pesqDisc(dgvDados);
        }
    }
}
