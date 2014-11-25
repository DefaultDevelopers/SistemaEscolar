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

namespace SistemaEscola.Formulários.Admin.Disciplina
{
    public partial class CadastrarDisc : Form
    {
        public CadastrarDisc()
        {
            InitializeComponent();
        }

        DisciplinaDAO discDAO = new DisciplinaDAO();
        SistemaEscola.Entidades.Disciplina discEnt = new Entidades.Disciplina();

        private void btnDiscSalvar_Click(object sender, EventArgs e)
        {
            String nome, descricao;
            int cargaHor, idDisc;

            idDisc = Convert.ToInt32(txtCodDisc.Text);
            nome = txtDiscNome.Text;
            cargaHor = Convert.ToInt32(txtDiscCargaHor.Text);
            descricao = txtDescricao.Text;

            discEnt.Nome = nome;
            discEnt.IdDisciplina = idDisc;
            discEnt.Carga_Hor = cargaHor;
            discEnt.Descricao = descricao;
            
            discDAO.salvarDisc(discEnt);
        }
    }
}
