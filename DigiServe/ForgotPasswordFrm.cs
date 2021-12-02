using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigiServe
{
    public partial class Forgot_password_frm : Form
    {
        private string password,newPassword;
        
        public Forgot_password_frm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (CurrentPass_txtbx.UseSystemPasswordChar == true) 
            { 
                CurrentPass_txtbx.UseSystemPasswordChar = false;
                NewPass_txtbox.UseSystemPasswordChar = false;
            }
           else
            {
                CurrentPass_txtbx.UseSystemPasswordChar = true;
                NewPass_txtbox.UseSystemPasswordChar = true;
            }

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            //Pang testing lang to 
            String testpass = "password1234";
            password = CurrentPass_txtbx.Text;
            newPassword = NewPass_txtbox.Text;


            if (testpass == password)
            {

                MessageBox.Show("Your password had been sucessfully changed");
                Dispose();
                
            }
            else if (password == "" )
            {
                MessageBox.Show("Current password is empty");
            }
            else if (newPassword == "")
            {
                MessageBox.Show("New password is empty");
            }
            else 
            {
                MessageBox.Show("Current password does not match");
                
            }

        }
    }
}
