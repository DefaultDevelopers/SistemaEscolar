using SistemaEscola.Classe;
using SistemaEscola.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin.Turma
{
    public partial class AlterarTurma : Form
    {
        public AlterarTurma()
        {
            InitializeComponent();
        }

        TurmaDAO turmaDAO = new TurmaDAO();
        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();

        private void btnDuvida_Click(object sender, EventArgs e)
        {
            PesquisarTurma pesqTurma = new PesquisarTurma();
            pesqTurma.ShowDialog();
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            //Estes métodos estão aqui para mostrar ao adm as opções nas comboboxes
            cmbBoxDAO.comboCurso(cmbCodCurso);
            cmbBoxDAO.comboTipo(cmbTipo);
            cmbBoxDAO.comboTurno(cmbTurno);
            //Este método que vai resgatar os dados
            turmaDAO.retornaTurma(txtCodTurma, cmbCodCurso, cmbTurno, cmbTipo, txtSala);            
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            SistemaEscola.Entidades.TurmaEnt turmaEnt = new Entidades.TurmaEnt();
            String sala;
            int idCurso, idTurma, turno, tipo;

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

            turmaDAO.alteraTurma(turmaEnt);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos limpa = new LimparCampos();
            limpa.limpaCampos(this);
        }
    }
}
