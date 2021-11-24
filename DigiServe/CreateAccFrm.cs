using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

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
    }
}
