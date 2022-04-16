using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace MyCalculator
{
    public partial class FormReport : Form
    {
        static public int reportFormCount = 0;
        public FormReport()
        {
            InitializeComponent();
            reportFormCount++;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.txtEmail.Text != "" && this.txtPassword.Text != "" && this.txtBody.Text != "")
            {
                try
                {
                    MailMessage mail = new MailMessage();
                    SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                    mail.From = new MailAddress(this.txtEmail.Text);
                    mail.To.Add("bitf19m017@pucit.edu.pk");
                    mail.Subject = this.txtSubject.Text;
                    mail.Body = this.txtBody.Text;

                    SmtpServer.Port = 587;
                    SmtpServer.Credentials = new System.Net.NetworkCredential(this.txtEmail.Text, this.txtPassword.Text);
                    SmtpServer.EnableSsl = true;

                    SmtpServer.Send(mail);
                    MessageBox.Show("mail Send");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please provide realtive information....");
            }
        }

        private void FormReport_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormReport.reportFormCount--;
        }
    }
}
