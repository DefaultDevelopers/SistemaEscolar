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

        public void getUserObj(DadosUsuarioEnt userData)
        {
            ent = userData;
        }

        private void InserirFrequencia_Load(object sender, EventArgs e)
        {

        }
    }
}
