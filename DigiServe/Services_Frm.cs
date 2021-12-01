using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DigiServe
{
    public partial class Services_Frm : Form
    {
        
        public Services_Frm()
        {
            InitializeComponent();
        }

        private void no_btn_MouseHover(object sender, EventArgs e)
        {
            no_btn.ForeColor = Color.Gold;
        }

        private void no_btn_MouseLeave(object sender, EventArgs e)
        {
            no_btn.ForeColor = Color.White;
        }

        private void no_btn_Click(object sender, EventArgs e)
        {
            Dispose();
        }


        private void Yes_btn_MouseHover(object sender, EventArgs e)
        {
            Yes_btn.ForeColor = Color.Gold;
        }

        private void Yes_btn_MouseLeave(object sender, EventArgs e)
        {
            Yes_btn.ForeColor = Color.White;
        }

        private void Yes_btn_Click(object sender, EventArgs e)
        {
            // Log out of Applyfrm then going back to Login
            Dispose();
            ApplyFrm logout;
            logout = new ApplyFrm();
            logout.Dispose();
            DigiServeFrm Login;
            Login = new DigiServeFrm();
            Login.ShowDialog();

        }
    }
}
