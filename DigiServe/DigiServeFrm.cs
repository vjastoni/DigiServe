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



        private void label6_Click(object sender, EventArgs e)
        {
            CreateAccFrm cr8AcctFrm = new CreateAccFrm();
            cr8AcctFrm.Show();
            this.Hide();
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
                CreateAccFrm tryFrame = new CreateAccFrm();
                this.Hide();
                tryFrame.Show();
            }
            else 
            {
                MessageBox.Show("Incorrect username or password!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
