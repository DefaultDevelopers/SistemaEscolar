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
using SistemaEscola.Entidades;
using SistemaEscola.Classe;

namespace SistemaEscola.Formulários.Admin.Professor
{
    public partial class VincularProfTurma : Form
    {
        public VincularProfTurma()
        {
            InitializeComponent();
        }

        Prof_TurmaDAO profTurmaDAO = new Prof_TurmaDAO();
        ProfTurmaEnt profTurmaEnt = new ProfTurmaEnt();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String profCod, idTurma;

            profCod = txtCodProf.Text;
            idTurma = Convert.ToString(cmbCodTurma.SelectedValue);

            profTurmaEnt.ProfCod = profCod;
            profTurmaEnt.IdTurma = idTurma;

            profTurmaDAO.salvar(profTurmaEnt);
        }

        private void linklblCodProf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void VincularProfTurma_Load(object sender, EventArgs e)
        {
            ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
            cmbBoxDAO.comboTurma(cmbCodTurma);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos limpa = new LimparCampos();
            limpa.limpaCampos(this);
        }
    }
}
