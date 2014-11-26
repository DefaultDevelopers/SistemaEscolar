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
namespace SistemaEscola.Formulários.Admin.Curso
{
    public partial class CadastrarCurso : Form
    {
        public CadastrarCurso()
        {
            InitializeComponent();
        }

        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
        CursoDAO cursoDAO = new CursoDAO();
        SistemaEscola.Entidades.Curso cursoEnt = new Entidades.Curso();

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome, descricao;
            int idCurso;

            nome = txtNome.Text;
            descricao = txtDescricao.Text;
            idCurso = Convert.ToInt32(txtCodCurso.Text);

            cursoEnt.Nome = nome;
            cursoEnt.Descricao = descricao;
            cursoEnt.IdCurso = idCurso;
            
            cursoDAO.salvarCurso(cursoEnt);
        }
    }
}
