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
    public partial class InserirFrequencia : Form
    {
        public InserirFrequencia()
        {
            InitializeComponent();
        }

        DadosUsuarioEnt ent = new DadosUsuarioEnt();
        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
        FrequenciaDAO frequenciaDAO = new FrequenciaDAO();
        FrequenciaEnt frequenciaEnt = new FrequenciaEnt();

        private void InserirFrequencia_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboTurma(cmbTurma);
            cmbBoxDAO.comboDisc(cmbDisc);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            int turma = Convert.ToInt32(cmbTurma.SelectedValue);
            frequenciaEnt.IdTurma = turma;
            frequenciaDAO.pesqCodigo(dgvCod, frequenciaEnt);

            int disc = Convert.ToInt32(cmbDisc.SelectedValue);

            frequenciaEnt.IdDisciplina = disc;

            frequenciaDAO.iniciarFrequencia(dgvCod, frequenciaEnt);

            frequenciaDAO.pesquisaFrequencia(dgvFrequencia, frequenciaEnt);
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            DateTime data_aula = dtpAula.Value.Date;
            DateTime data_criado = DateTime.Now.Date;
            int disc = Convert.ToInt32(cmbDisc.SelectedValue);
            int turma = Convert.ToInt32(cmbTurma.SelectedValue);

            frequenciaEnt.DataAula = data_aula;
            frequenciaEnt.DataCriado = data_criado;
            frequenciaEnt.IdDisciplina = disc;
            frequenciaEnt.IdTurma = turma;

            frequenciaDAO.inserirFrequencia(dgvCod, dgvFrequencia, frequenciaEnt, this);
        }
    }
}
