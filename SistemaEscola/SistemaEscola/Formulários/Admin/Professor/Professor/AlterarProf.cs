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

namespace SistemaEscola.Formulários.Admin.Professor
{
    public partial class AlterarProf : Form
    {
        public AlterarProf()
        {
            InitializeComponent();
        }

        ProfessorDAO profDAO = new ProfessorDAO();
        EnderecoDAO endDAO = new EnderecoDAO();

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            profDAO.retornaProf(txtCod, txtNome, txtEmail, txtCPF, txtTelefone, txtFormacao, cmbGrauFormacao, txtDataNasc);
            endDAO.retornaEnd(txtCod, txtRua, txtBairro, txtNum, txtEstado, txtCidade, txtCEP);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //PROFESSOR
            SistemaEscola.Entidades.Professor profEnt = new Entidades.Professor();
            String nome, telefone, email, cpf, grauForm, form, dataNasc;

            nome = txtNome.Text;
            telefone = txtTelefone.Text;
            email = txtEmail.Text;
            cpf = txtCPF.Text;
            grauForm = cmbGrauFormacao.Text;
            form = txtFormacao.Text;
            dataNasc = txtDataNasc.Text;

            profEnt.Nome = nome;
            profEnt.Telefone = telefone;
            profEnt.Email = email;
            profEnt.CPF = cpf;
            profEnt.Grau_Form = grauForm;
            profEnt.Form = form;
            profEnt.DataNasc = dataNasc;

            profDAO.alteraProf(profEnt, txtCod);

            //ENDEREÇO
            String rua, bairro, num, estado, cidade, cep;
            Endereco endEnt = new Endereco();

            rua = txtRua.Text;
            bairro = txtBairro.Text;
            num = txtNum.Text;
            estado = txtEstado.Text;
            cidade = txtCidade.Text;
            cep = txtCEP.Text;
            
            endEnt.Rua = rua;
            endEnt.Bairro = bairro;
            endEnt.Num = num;
            endEnt.Estado = estado;
            endEnt.Cidade = cidade;
            endEnt.CEP = cep;

            endDAO.alteraEnd(endEnt, txtCod);
        }
    }
}
