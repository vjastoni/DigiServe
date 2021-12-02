using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigiServe
{
    public partial class EmailAddFrm : Form
    {
        string email,emailtest;
        public EmailAddFrm()
        {
            InitializeComponent();
        }

        private void Subtmitbtn_Click(object sender, EventArgs e)
        {
            // testing 
            emailtest = "testemail@gmail.com"; 
            email = EmailAdd_txtbx.Text;

            Forgot_password_frm forgot = new Forgot_password_frm();
            
            if ( emailtest == email) 
            {

                Dispose();
                forgot.ShowDialog();
            }
            else if (email == "") 
            {
                MessageBox.Show("Email address is empty");
            }
            else 
            {
                MessageBox.Show("This email address is not registered");
            }
        }
    }
}
