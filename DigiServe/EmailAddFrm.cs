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

        public static string email; // make email identifier usable in ForgotPasswordFrm
        string randomCode;

        public EmailAddFrm()
        {
            InitializeComponent();
        }

        private void Subtmitbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HAO55D\SQLEXPRESS;Initial Catalog=DB_Appointment;Integrated Security=True");

            string from, pass, messageBody;
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
                smtp.Send(message);
                MessageBox.Show("Code send successfully \n Check your email :) ");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            if(randomCode == (txtVerCode.Text).ToString())
            {
                email = EmailAdd_txtbx.Text;
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
