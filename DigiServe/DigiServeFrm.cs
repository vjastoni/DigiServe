﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            CreateAccFrm cr8Acct = new CreateAccFrm();
            cr8Acct.Show();
            this.Hide();
        }
    }
}
