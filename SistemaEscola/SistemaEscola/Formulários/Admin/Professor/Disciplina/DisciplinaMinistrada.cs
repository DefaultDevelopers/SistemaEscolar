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
    public partial class DisciplinaMinistrada : Form
    {
        public DisciplinaMinistrada()
        {
            InitializeComponent();
        }

        Prof_DiscDAO profDiscDAO = new Prof_DiscDAO();
        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
        ProfDiscEnt profDiscEnt = new ProfDiscEnt();
        LimparCampos limpar = new LimparCampos();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String profCod, idDisc;

            profCod = txtCod.Text;
            idDisc = Convert.ToString(cmbEscDisc.SelectedValue);

            profDiscEnt.ProfCod = profCod;
            profDiscEnt.IdDisc = idDisc;

            profDiscDAO.salvar(profDiscEnt);
        }

        private void DisciplinaMinistrada_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboDisc(cmbEscDisc);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar.limpaCampos(this);
        }

        private void linklblCodProf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PesquisaUsuário pesqUser = new PesquisaUsuário();
            pesqUser.Show();
        }
    }
}
