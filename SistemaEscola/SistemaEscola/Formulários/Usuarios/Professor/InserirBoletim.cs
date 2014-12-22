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
    public partial class InserirBoletim : Form
    {
        public InserirBoletim()
        {
            InitializeComponent();
        }

        BoletimEnt boletimEnt = new BoletimEnt();
        BoletimDAO boletimDAO = new BoletimDAO();
        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
        TurmaDAO turmaDAO = new TurmaDAO();
        TurmaEnt turmaEnt = new TurmaEnt();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int turma = Convert.ToInt32(cmbTurma.SelectedValue);
            
            boletimEnt.IdTurma = turma;

            boletimDAO.pesqCodigo(dgvCod, boletimEnt);

            cmbDisc.Enabled = true;
            btnDisc.Enabled = true;
            dgvBoletim.Enabled = true;
        }

        private void Boletim_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboTurma(cmbTurma);
            cmbBoxDAO.comboDisc(cmbDisc);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            int idDisc, idTurma;
            idDisc = Convert.ToInt32(cmbDisc.SelectedValue);
            idTurma = Convert.ToInt32(cmbTurma.SelectedValue);

            boletimEnt.IdDisc = idDisc;
            boletimEnt.IdTurma = idTurma;

            boletimDAO.salvarBoletim(dgvCod, dgvBoletim, boletimEnt, this);
        }

        private void btnDisc_Click(object sender, EventArgs e)
        {
            int idDisc, idTurma;
            
            idDisc = Convert.ToInt32(cmbDisc.SelectedValue);
            idTurma = Convert.ToInt32(cmbTurma.SelectedValue);

            boletimEnt.IdDisc = idDisc;
            boletimEnt.IdTurma = idTurma;

            boletimDAO.iniciarBoletim(dgvCod, boletimEnt);

            boletimDAO.pesquisaBoletim(dgvBoletim, boletimEnt);
        }
    }
}