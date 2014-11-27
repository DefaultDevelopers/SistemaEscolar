using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using SistemaEscola.Classe;
using System.Collections;
using SistemaEscola.Entidades;
using SistemaEscola.DAO;

namespace SistemaEscola.Formulários.Admin.Curso
{
    public partial class AlterarCurso : Form
    {
        public AlterarCurso()
        {
            InitializeComponent();
        }

        Banco b = new Banco();
        CursoDAO cursoDAO = new CursoDAO();
        SistemaEscola.Entidades.Curso cursoEnt = new Entidades.Curso();
        LimparCampos limpar = new LimparCampos();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            cursoDAO.retornaCurso(txtCodCurso, txtNome, txtDescricao);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            String nome, descricao;

            nome = txtNome.Text;
            descricao = txtDescricao.Text;

            cursoEnt.Nome = nome;
            cursoEnt.Descricao = descricao;

            cursoDAO.alteraCurso(cursoEnt, txtCodCurso);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar.limpaCampos(this);
        }
    }
}
