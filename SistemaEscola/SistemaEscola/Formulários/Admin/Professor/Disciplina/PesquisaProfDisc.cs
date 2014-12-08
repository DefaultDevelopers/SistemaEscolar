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

namespace SistemaEscola.Formulários.Admin.Professor.Disciplina
{
    public partial class PesquisaProfDisc : Form
    {
        public PesquisaProfDisc()
        {
            InitializeComponent();
        }

        Prof_DiscDAO profDiscDAO = new Prof_DiscDAO();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            profDiscDAO.pesquisaProfDisc(dgvDados, txtCod);
        }

        private void linkLblCod_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PesquisaUsuário pesqUser = new PesquisaUsuário();
            pesqUser.Show();
        }

        private void txtCod_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dgvDados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
