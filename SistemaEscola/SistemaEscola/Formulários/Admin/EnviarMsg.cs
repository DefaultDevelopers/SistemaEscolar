using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscola.Formulários.Admin
{
    public partial class EnviarMsg : Form
    {
        public EnviarMsg()
        {
            InitializeComponent();
        }

        //Mensagem
        MailMessage message = new MailMessage();
        String anexo;

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            SendEmail();
        }

        private void SendEmail()
        {
            

            String para = txtPara.Text;
            String assunto = txtAssunto.Text;
            String mens = txtMensagem.Text;            

            //Estes 2 campos corresponde a quem está enviando o e-mail
            message.Sender = new MailAddress("noreplyacademico@gmail.com", "Sistema Acadêmico");
            message.From = new MailAddress("noreplyacademico@gmail.com", "Sistema Acadêmico");

            anexo = txtAnexo.Text;

            if (!string.IsNullOrEmpty(anexo)) {
                message.Attachments.Add(new Attachment(anexo));
            }

            //Aqui você coloca para quem você quer enviar o e-mail
            message.To.Add(new MailAddress(para));

            //Aqui você coloca o assunto
            message.Subject = assunto;

            //E aqui você coloca o corpo do e-mail
            message.Body = mens;

            //Se o corpo do e-mail for HTML, coloque o IsBodyHtml = true, caso contrário, = false
            message.IsBodyHtml = false;

            //Smtp
            SmtpClient smtp = new SmtpClient();

            //Aqui você coloca seu usuário e senha
            smtp.Credentials = new NetworkCredential("noreplyacademico@gmail.com", "sistemaacademico");

            //Caso o servidor tenha SSL, habilite utilizando true (gmail usa ssl e meu teste foi com gmail)
            smtp.EnableSsl = true;

            //Aqui é o endereço do SMTP
            smtp.Host = "smtp.gmail.com";

            //E a porta utilizada para conexão
            smtp.Port = 587;            

            //Firula só pra saber que enviamos
            try
            {
                //Envia o e-mail :)
                smtp.Send(message);
                MessageBox.Show("E-mail enviado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ep)
            {
                MessageBox.Show("Erro" + ep.Message);
            }
            
        }

        private void btnProcurarAnexo_Click(object sender, EventArgs e)
        {           
            openFileAnexo.ShowDialog();
            txtAnexo.Text = openFileAnexo.FileName;
        }
    }
}
