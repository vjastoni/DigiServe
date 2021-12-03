using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DigiServe
{
    public partial class Forgot_password_frm : Form
    {
        string email = EmailAddFrm.email;

        private void Forgot_password_frm_Load(object sender, EventArgs e)
        {
          
        }

        public Forgot_password_frm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

           if (newPass_txtbx.UseSystemPasswordChar == true) 
            { 
                newPass_txtbx.UseSystemPasswordChar = false;
                verifyNewPass_txtbox.UseSystemPasswordChar = false;
            }

           else
            {
                newPass_txtbx.UseSystemPasswordChar = true;
                verifyNewPass_txtbox.UseSystemPasswordChar = true;
            }

        }

        private void Submit_btn_Click(object sender, EventArgs e)
        {
            if (newPass_txtbx.Text == verifyNewPass_txtbox.Text)
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HAO55D\SQLEXPRESS;Initial Catalog=DB_Reserve;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("Update Register set password =  '" + newPass_txtbx.Text + "' where email = '" + email + "' ", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Your password had been sucessfully changed");
                Dispose();

            }
            else
            {
                MessageBox.Show("Current password does not match");

            }

        }
    }
}
