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

namespace SistemaEscola.Formulários.Admin.Professor
{
    public partial class AlterarDiscMinis : Form
    {
        public AlterarDiscMinis()
        {
            InitializeComponent();
        }

        Prof_DiscDAO profDiscDAO = new Prof_DiscDAO();
        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            profDiscDAO.pesquisaProfDisc(dgvDadosDisc, txtCod);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            profDiscDAO.alteraProfDisc(cmbDisc, txtDiscAAlterar);
        }

        private void AlterarDiscMinis_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboDisc(cmbDisc);
        }
    }
}
