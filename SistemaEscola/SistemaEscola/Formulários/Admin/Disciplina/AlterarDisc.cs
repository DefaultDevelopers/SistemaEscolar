using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Classe;
using SistemaEscola.DAO;

namespace SistemaEscola.Formulários.Admin.Disciplina
{
    public partial class AlterarDisc : Form
    {
        public AlterarDisc()
        {
            InitializeComponent();
        }

        LimparCampos limpa = new LimparCampos();
        DisciplinaDAO discDAO = new DisciplinaDAO();
        SistemaEscola.Entidades.Disciplina discEnt = new Entidades.Disciplina();

        private void btnAltDiscLimpar_Click(object sender, EventArgs e)
        {
            limpa.limpaCampos(this);
        }

        private void btnPesqDisc_Click(object sender, EventArgs e)
        {
            discDAO.retornaDisc(txtAltDiscCod, txtAltDiscNome, txtAltDiscDescricao, txtAltDiscCargHor);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            String nome, descricao;
            int cargaHor;

            nome = txtAltDiscNome.Text;
            descricao = txtAltDiscDescricao.Text;
            cargaHor = Convert.ToInt32(txtAltDiscCargHor.Text);

            discEnt.Nome = nome;
            discEnt.Descricao = descricao;
            discEnt.Carga_Hor = cargaHor;
            
            discDAO.alteraCurso(discEnt, txtAltDiscCod);
        }
    }
}
