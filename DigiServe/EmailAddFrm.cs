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
            messageBody = " Email Verified! \n Verification Code : " + randomCode + " .";
            email = EmailAdd_txtbx.Text;
            emailCheck = "select shit from email = '"+email+"' ";
            SqlCommand cmd = new SqlCommand(emailCheck, con);
            SqlDataReader checkedEmail = cmd.ExecuteReader();
            checkedEmail.Read();

            if (checkedEmail["EMAIL_TABLE_NAME"].ToString() == email)
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
