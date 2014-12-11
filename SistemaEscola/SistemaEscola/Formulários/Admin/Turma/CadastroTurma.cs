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

namespace SistemaEscola.Formulários.Admin.Turma
{
    public partial class CadastroTurma : Form
    {
        public CadastroTurma()
        {
            InitializeComponent();
        }

        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
        TurmaDAO turmaDAO = new TurmaDAO();
        SistemaEscola.Entidades.TurmaEnt turmaEnt = new Entidades.TurmaEnt();

        private void CadastroTurma_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboCurso(cmbCodCurso);
            cmbBoxDAO.comboTurno(cmbTurno);
            cmbBoxDAO.comboTipo(cmbTipo);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            int idTurma, idCurso, turno, tipo;
            String sala;

            idTurma = Convert.ToInt32(txtCodTurma.Text);
            idCurso = Convert.ToInt32(cmbCodCurso.SelectedValue);
            turno = Convert.ToInt32(cmbTurno.SelectedValue);
            tipo = Convert.ToInt32(cmbTipo.SelectedValue);
            sala = txtSala.Text;

            turmaEnt.IdTurma = idTurma;
            turmaEnt.IdCurso = idCurso;
            turmaEnt.Turno = turno;
            turmaEnt.Tipo = tipo;
            turmaEnt.Sala = sala;

            turmaDAO.salvarTurma(turmaEnt);
        }
    }
}
