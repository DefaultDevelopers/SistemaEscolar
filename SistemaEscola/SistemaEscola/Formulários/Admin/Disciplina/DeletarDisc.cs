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
    public partial class DeletarDisc : Form
    {
        public DeletarDisc()
        {
            InitializeComponent();
        }

        DisciplinaDAO discDAO = new DisciplinaDAO();

        private void DeletarDisc_Load(object sender, EventArgs e)
        {
            discDAO.pesqDisc(dgvDados);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            discDAO.deletaDisc(txtCodDel);
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DeletarDisc_Load(sender, e);
        }
    }
}
