using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data;
using System.Data.SqlClient;

namespace DigiServe
{
    public partial class EmailAddFrm : Form
    {

        private string conString = "Data source shit";
        string randomCode;

        public EmailAddFrm()
        {
            InitializeComponent();
        }

        private void Subtmitbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(conString);
            string email, emailCheck, messageBody;
            Random rdm = new Random();
            randomCode = (rdm.Next(999999)).ToString();
            MailMessage message = new MailMessage();
            email = (EmailAdd_txtbx.Text).ToString();
            from = "email galing sa sql so may code shit";// lagay mo dito ung sa SQL na email;
            pass = "pass galing sa sql again :)";// lagay mo dito ung sa sql na password;

            messageBody = " your reset code is : " + randomCode;
            message.To.Add(email);
            message.From = new MailAddress(from);
            message.Body = messageBody;
            message.Subject = "Password resseting code";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                MessageBox.Show(messageBody);
            }
            else
            {
                MessageBox.Show("Email not recognized!!");
            }
            
   
            
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtVerCode.Text).ToString())
            {
                Forgot_password_frm fgot = new Forgot_password_frm();
                this.Hide();
                fgot.Show();
            }

            else
            {
                MessageBox.Show("Wrong code :( so sad ");
            }
        }
    }
}
