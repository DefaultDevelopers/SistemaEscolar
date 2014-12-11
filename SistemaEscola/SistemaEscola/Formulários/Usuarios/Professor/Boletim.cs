using SistemaEscola.DAO;
using SistemaEscola.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Usuarios.Professor
{
    public partial class Boletim : Form
    {
        public Boletim()
        {
            InitializeComponent();
        }

        BoletimEnt boletimEnt = new BoletimEnt();
        BoletimDAO boletimDAO = new BoletimDAO();
        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            boletimEnt.IdTurma = Convert.ToInt32(cmbTurma.SelectedValue);
            boletimEnt.IdDisc = Convert.ToInt32(cmbDisc.SelectedValue);

            boletimDAO.pesquisaBoletim(dgvBoletim, boletimEnt);
        }

        private void Boletim_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboTurma(cmbTurma);
            cmbBoxDAO.comboDisc(cmbDisc);
        }
    }
}
