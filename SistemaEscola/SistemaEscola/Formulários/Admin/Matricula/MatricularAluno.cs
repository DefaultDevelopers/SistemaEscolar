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

namespace SistemaEscola.Formulários.Admin.Matricula
{
    public partial class MatricularAluno : Form
    {
        public MatricularAluno()
        {
            InitializeComponent();
        }

        MatriculaDAO matrDAO = new MatriculaDAO();
        String nome, telefone, email, cpf, endereco, turno, curso, login;
        DateTime dataNasc;
        int turma, senha, idTurno = 0, tipo;

        private void btnSalvar_Click(object sender, EventArgs e)
        {            
            SistemaEscola.Entidades.Aluno aluno = new SistemaEscola.Entidades.Aluno();
            SistemaEscola.Entidades.Matricula matr = new SistemaEscola.Entidades.Matricula();       

            //Aluno
            nome = txtNome.Text;
            telefone = txtTelefone.Text;
            email = txtEmail.Text;
            cpf = txtCPF.Text;
            endereco = "Rua: " + txtRua.Text + ", " + txtNum.Text + ", Bairro: " + txtBairro.Text + "Estado: " + txtEstado.Text + "Cidade: " + txtCidade.Text + "CEP: " + txtCEP.Text;
            dataNasc = Convert.ToDateTime(dtpDataNasc.Text);

            //Matricula
            turma = Convert.ToInt32(cmbTurma.Text);
            
            //Pesquisa no formulário
            turno = Turno();
            idTurno = IdTurno(turno, idTurno);
            tipo = Convert.ToInt32(cmbTipo.Text);
            curso = cmbCurso.Text; 
            
            //Login
            login = txtLoginAno.Text + txtLoginCurso.Text + txtLoginNumId.Text;
            senha = Convert.ToInt32(txtSenha.Text);

            //Aluno
            aluno.Nome = nome;
            aluno.Telefone = telefone;
            aluno.Email = email;
            aluno.CPF = cpf;
            aluno.Endereco = endereco;
            aluno.DataNasc = dataNasc;        
            aluno.Senha = senha;

            //Matricula
            matr.Login = aluno.Login = login;
            matr.IdTurma = turma;            
        }

        private void MatricularAluno_Load(object sender, EventArgs e)
        {
            txtLoginAno.Text = Convert.ToString(DateTime.Now.Year);
            matrDAO.comboTipo(cmbTipo, Turno());
            matrDAO.comboCurso(cmbCurso);            
        }

        private static int IdTurno(String turno, int idTurno)
        {
            if (turno.Equals("Matutino"))
            {
                idTurno = 1;
            }
            else if (turno.Equals("Vespertino"))
            {
                idTurno = 2;
            }
            else
            {
                idTurno = 3;
            }
            return idTurno;
        }

        private string Turno()
        {
            //String turno;
            if (rbMatutino.Checked)
            {
                turno = rbMatutino.Text;
            }
            else if (rbVespertino.Checked)
            {
                turno = rbVespertino.Text;
            }
            else
            {
                turno = rbNoturno.Text;
            }
            return turno;
        }
    }
}
