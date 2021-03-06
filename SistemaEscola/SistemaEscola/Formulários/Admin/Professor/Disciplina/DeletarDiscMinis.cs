﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.DAO;

namespace SistemaEscola.Formulários.Admin.Professor
{
    public partial class DeletarDiscMinis : Form
    {
        public DeletarDiscMinis()
        {
            InitializeComponent();
        }

        Prof_DiscDAO profDiscDAO = new Prof_DiscDAO();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            profDiscDAO.pesquisaProfDisc(dgvDadosDisc, txtCod);
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            profDiscDAO.deletaProfDisc(txtDiscADeletar);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PesquisaUsuário pesqUser = new PesquisaUsuário();
            pesqUser.Show();
        }
    }
}
