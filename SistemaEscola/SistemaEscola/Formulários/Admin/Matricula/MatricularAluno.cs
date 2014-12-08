using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscola.Entidades;
using SistemaEscola.DAO;
using SistemaEscola.Classe;

namespace SistemaEscola.Formulários.Admin.Matricula
{
    public partial class MatricularAluno : Form
    {
        public MatricularAluno()
        {
            InitializeComponent();            
        }

        MatriculaDAO matrDAO = new MatriculaDAO();
        AlunoDAO alunoDAO = new AlunoDAO();
        LoginDAO loginDAO = new LoginDAO();
        ComboBoxDAO cmbBoxDAO = new ComboBoxDAO();
        EnderecoDAO endDAO = new EnderecoDAO();
        String nome, telefone, email, cpf, login, curso, tipo, senhacript, dataNasc;
        int turma, senha, turno, user = 3;

        private void MatricularAluno_Load(object sender, EventArgs e)
        {
            //Métodos necessários no load do form
            txtLoginAno.Text = Convert.ToString(DateTime.Now.Year);
            cmbBoxDAO.comboTipo(cmbTipo);
            numRandomLogin();
        }

        //Método para criar número aleatório
        private void numRandomLogin()
        {
            Random txtLoginNum = new Random();
            txtLoginNumAleat.Text = Convert.ToString(txtLoginNum.Next(1000, 9999));
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //LOGIN
            CriptMD5 cmd5 = new CriptMD5();
            Login loginEnt = new Login();
            login = txtLoginAno.Text + txtLoginNumAleat.Text + txtLoginNumId.Text;
            senha = Convert.ToInt32(txtSenha.Text);
            senhacript = cmd5.getMD5Hash(txtSenha.Text);

            loginEnt.Log = login;
            loginEnt.Senha = senha;
            loginEnt.User = user;

            loginDAO.salvarLogin(loginEnt);

            //ALUNO
            SistemaEscola.Entidades.Aluno alunoEnt = new SistemaEscola.Entidades.Aluno();

            nome = txtNome.Text;
            telefone = txtTelefone.Text;
            email = txtEmail.Text;
            cpf = txtCPF.Text;
            dataNasc = txtDataNasc.Text;
            login = txtLoginAno.Text + txtLoginNumAleat.Text + txtLoginNumId.Text;

            alunoEnt.Nome = nome;
            alunoEnt.Telefone = telefone;
            alunoEnt.Email = email;
            alunoEnt.CPF = cpf;
            alunoEnt.DataNasc = dataNasc;
            alunoEnt.Login = login;

            alunoDAO.salvarAluno(alunoEnt);

            //ENDEREÇO
            SistemaEscola.Entidades.Endereco endEnt = new Endereco();

            endEnt.Login = login;
            endEnt.Rua = txtRua.Text;
            endEnt.Bairro = txtBairro.Text;
            endEnt.Num = txtNum.Text;
            endEnt.Estado = txtEstado.Text;
            endEnt.Cidade = txtCidade.Text;
            endEnt.CEP = txtCEP.Text;

            endDAO.salvarEnd(endEnt);

            SistemaEscola.Entidades.Matricula matrEnt = new SistemaEscola.Entidades.Matricula();

            login = txtLoginAno.Text + txtLoginNumAleat.Text + txtLoginNumId.Text;
            turma = Convert.ToInt32(cmbTurma.SelectedValue);

            //MATRÍCULA        
            matrEnt.Login = login;
            matrEnt.IdTurma = turma;

            matrDAO.salvarMatricula(matrEnt, login, senha);
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
    }
}
