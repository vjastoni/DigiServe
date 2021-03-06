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
    public partial class CreateAccFrm : Form
    {
        public CreateAccFrm()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            DigiServeFrm loginFrm = new DigiServeFrm();
            loginFrm.Show();
            this.Hide();
        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HAO55D\SQLEXPRESS;Initial Catalog=DB_Reserve;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Register]
           ([firstname]
           ,[lastname]
           ,[email]
           ,[mobileNo]
           ,[Gender]
           ,[username]
           ,[password])
     VALUES
           ('"+txtFirstName.Text+"', '"+txtLastName.Text+"','"+txtEmail_.Text+"', '"+txtMobileNo.Text+ "', '" + cmbGender.SelectedItem.ToString() + "','" + txtUname.Text+"', '"+txtPass.Text+"')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Register Successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label10_MouseHover(object sender, EventArgs e)
        {
            // put underline in sign up
            label10.Font = new Font(label10.Font.Name, label10.Font.SizeInPoints, FontStyle.Underline);
            label10.ForeColor = Color.Gold;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            // changes the font to its default font 
            label10.Font = new Font(label10.Font.Name, label10.Font.SizeInPoints, FontStyle.Bold);
            label10.ForeColor = SystemColors.ControlLightLight;
        }
    }
}
