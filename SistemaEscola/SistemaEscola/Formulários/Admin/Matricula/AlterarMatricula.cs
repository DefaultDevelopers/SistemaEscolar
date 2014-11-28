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
using SistemaEscola.Classe;
using MySql.Data.MySqlClient;

namespace SistemaEscola.Formulários.Admin.Matricula
{
    public partial class AlterarMatricula : Form
    {
        public AlterarMatricula()
        {
            InitializeComponent();
        }

        AlunoDAO alunoDAO = new AlunoDAO();
        EnderecoDAO endDAO = new EnderecoDAO();
        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
        MatriculaDAO matrDAO = new MatriculaDAO();
        Aluno alunoEnt = new Aluno();
        Endereco endEnt = new Endereco();
        SistemaEscola.Entidades.Matricula matrEnt = new Entidades.Matricula();
        LimparCampos limpa = new LimparCampos();

        String tipo, curso;
        int turno;

        private void AlterarMatricula_Load(object sender, EventArgs e)
        {
            cmbBoxDAO.comboTipo(cmbTipo);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                alunoDAO.retornaAluno(txtCodAluno, txtNome, txtTelefone, txtEmail, dtpDataNasc, txtCPF);
                endDAO.retornaEnd(txtCodAluno, txtRua, txtBairro, txtNum, txtEstado, txtCidade, txtCEP);
            }
            catch (MySqlException)
            {
                MessageBox.Show("Você não digitou um código!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            //ALUNO
            String nome, telefone, email, cpf;
            DateTime dataNasc;

            nome = txtNome.Text;
            telefone = txtTelefone.Text;
            email = txtEmail.Text;
            cpf = txtCPF.Text;
            dataNasc = dtpDataNasc.Value;

            alunoEnt.Nome = nome;
            alunoEnt.Telefone = telefone;
            alunoEnt.Email = email;
            alunoEnt.CPF = cpf;
            alunoEnt.DataNasc = dataNasc;

            alunoDAO.alteraAluno(alunoEnt, txtCodAluno);

            //ENDEREÇO
            String rua, bairro, num, estado, cidade, cep;

            rua = txtRua.Text;
            bairro = txtBairro.Text;
            num = txtNome.Text;
            estado = txtEstado.Text;
            cidade = txtCidade.Text;
            cep = txtCEP.Text;

            endEnt.Rua = rua;
            endEnt.Bairro = bairro;
            endEnt.Num = num;
            endEnt.Estado = estado;
            endEnt.Cidade = cidade;
            endEnt.CEP = cep;

            endDAO.alteraEnd(endEnt, txtCodAluno);

            //MATRÍCULA
            String idTurma;

            idTurma = Convert.ToString(cmbTurma.SelectedValue);

            matrEnt.IdTurma = Convert.ToInt32(idTurma);

            matrDAO.alteraMatricula(txtCodAluno, matrEnt);
        }

        private void cmbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tipo = Convert.ToString(cmbTipo.SelectedValue);
            cmbBoxDAO.comboTurno(cmbTurno, tipo);
        }

        private void cmbTurno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            turno = Convert.ToInt32(cmbTurno.SelectedValue);
            cmbBoxDAO.comboCurso(cmbCurso, turno);
        }

        private void cmbCurso_SelectionChangeCommitted(object sender, EventArgs e)
        {
            curso = Convert.ToString(cmbCurso.SelectedValue);
            cmbBoxDAO.comboTurma(cmbTurma, curso);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpa.limpaCampos(this);
        }
    }
}
