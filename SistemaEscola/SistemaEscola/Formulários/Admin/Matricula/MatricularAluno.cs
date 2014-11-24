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
        String nome, telefone, email, cpf, endereco, login;
        DateTime dataNasc;
        int turma, senha, turno, user = 3;


        //Pesquisa no Formulário (Comboboxes)
        private void MatricularAluno_Load(object sender, EventArgs e)
        {
            txtLoginAno.Text = Convert.ToString(DateTime.Now.Year);
            matrDAO.comboTipo(cmbTipo);
            numRandomLogin();
        }

        private void numRandomLogin()
        {
            Random txtLoginNum = new Random();
            txtLoginNumAleat.Text = Convert.ToString(txtLoginNum.Next(1000, 9999));
        }

        private void cmbTipo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbTipo.SelectedValue.Equals(1))
            {
                matrDAO.comboCurso(cmbCurso, 1, Turno());
            }
            else if (cmbTipo.SelectedValue.Equals(2))
            {
                matrDAO.comboCurso(cmbCurso, 2, Turno());
            }
            else
            {
                matrDAO.comboCurso(cmbCurso, 3, Turno());
            }
        }

        private int Turno()
        {
            if (rbMatutino.Checked)
            {
                turno = 1;
            }
            else if (rbVespertino.Checked)
            {
                turno = 2;
            }
            else
            {
                turno = 3;
            }
            return turno;
        }

        private void cmbCurso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int curso = Convert.ToInt32(cmbCurso.SelectedValue);
            matrDAO.comboTurma(cmbTurma, curso);
        }

        //Classe para salvar no banco
        private void btnAvancarLogin_Click(object sender, EventArgs e)
        {
            //Login
            Login loginTable = new Login();
            login = txtLoginAno.Text + txtLoginNumAleat.Text + txtLoginNumId.Text;
            senha = Convert.ToInt32(txtSenha.Text);

            loginTable.Log = login;
            loginTable.Senha = senha;
            loginTable.User = user;

            loginDAO.salvarLogin(loginTable);
            
            grpbDadosAluno.Enabled = true;
        }

        private void btnAvancarDados_Click(object sender, EventArgs e)
        {
            //Aluno
            nome = txtNome.Text;
            telefone = txtTelefone.Text;
            email = txtEmail.Text;
            cpf = txtCPF.Text;
            endereco = "Rua: " + txtRua.Text + ", " + txtNum.Text + ", Bairro: " + txtBairro.Text + ", Estado: " + txtEstado.Text + ", Cidade: " + txtCidade.Text + ", CEP: " + txtCEP.Text;
            dataNasc = Convert.ToDateTime(dtpDataNasc.Text);
            login = txtLoginAno.Text + txtLoginNumAleat.Text + txtLoginNumId.Text;

            SistemaEscola.Entidades.Aluno alunoEnt = new SistemaEscola.Entidades.Aluno();

            //Aluno
            alunoEnt.Nome = nome;
            alunoEnt.Telefone = telefone;
            alunoEnt.Email = email;
            alunoEnt.CPF = cpf;
            alunoEnt.Endereco = endereco;
            alunoEnt.DataNasc = dataNasc;
            alunoEnt.Login = login;

            alunoDAO.salvarAluno(alunoEnt);

            grpbDadosCurso.Enabled = true;            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SistemaEscola.Entidades.Matricula matrEnt = new SistemaEscola.Entidades.Matricula();

            login = txtLoginAno.Text + txtLoginNumAleat.Text + txtLoginNumId.Text;
            turma = Convert.ToInt32(cmbTurma.SelectedValue);

            //Matricula            
            matrEnt.Login = login;
            matrEnt.IdTurma = turma;

            matrDAO.salvarMatricula(matrEnt);
        }

        private void grpbTurno_SelectionChangedCommitted(object sender, EventArgs e)
        {
            cmbTipo.Text = "Escolha o tipo";
            cmbCurso.Text = "Escolha o curso";
            cmbTurma.Text = "Escolha a turma";
        }
    }
}
