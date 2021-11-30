using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DigiServe
{
    public partial class DigiServeFrm : Form
    {
        public DigiServeFrm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HAO55D\SQLEXPRESS;Initial Catalog=DB_Reserve;Integrated Security=True");
            string query = "Select * from Register Where username = '" + txtUsername.Text.Trim() + "' and password = '" + txtPassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                ApplyFrm tryFrame = new ApplyFrm();
                this.Hide();
                tryFrame.Show();
            }
            else 
            {
                MessageBox.Show("Incorrect username or password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void lblSignUp_MouseHover(object sender, EventArgs e)
        {
            // put underline in sign up
            lblSignUp.Font = new Font(lblSignUp.Font.Name, lblSignUp.Font.SizeInPoints, FontStyle.Underline);
            lblSignUp.ForeColor = Color.Gold;
        }

        private void lblSignUp_MouseLeave(object sender, EventArgs e)
        {
            // changes the font to its default font 
            lblSignUp.Font = new Font("Arial Rounded MT", lblSignUp.Font.Size);
            lblSignUp.ForeColor = SystemColors.ControlLightLight;
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            CreateAccFrm crtacc = new CreateAccFrm();
            crtacc.Show();
            this.Hide();
        }
    }
}
