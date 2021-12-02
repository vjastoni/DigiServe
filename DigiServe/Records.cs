using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DigiServe
{
    public partial class Records : Form
    {
        string conString = @"Data Source=DESKTOP-8HAO55D\SQLEXPRESS;Initial Catalog=DB_Appointment;Integrated Security=True";
        public Records()
        {
            InitializeComponent();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(conString))
            {              

                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from Appointment", sqlCon);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                dataGridViewRecords.DataSource = dataTable;
            }
        }
    }
}
