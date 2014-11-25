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

        private void CadastrarCurso_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboTurno(cmbTurno);
            cmbBoxDAO.comboTipo(cmbTipo);
        }
    }
}
