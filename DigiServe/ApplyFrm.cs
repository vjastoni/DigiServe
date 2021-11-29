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
    public partial class ApplyFrm : Form
    {
        public ApplyFrm()
        {
            InitializeComponent();
        }

        private void lblAboutDigi_Click(object sender, EventArgs e)
        {
            // AboutDigi pop up effect
            float UpSize;
            UpSize = lblAboutDigi.Font.Size;
            UpSize = 16.0F;
            lblAboutDigi.Font = new Font(lblAboutDigi.Font.Name, UpSize, lblAboutDigi.Font.Style, lblAboutDigi.Font.Unit);
            lblAboutDigi.ForeColor = Color.Gold;
            // Services Default format
            float downSizeS;
            downSizeS = lblServices.Font.Size;
            downSizeS = 14.25F;
            lblServices.Font = new Font(lblServices.Font.Name, downSizeS, lblServices.Font.Style, lblServices.Font.Unit);
            lblServices.ForeColor = Color.White;
            // Reservation Default format
            float downSizeR;
            downSizeR = lblReservation.Font.Size;
            downSizeR = 14.25F;
            lblReservation.Font = new Font(lblReservation.Font.Name, downSizeR, lblReservation.Font.Style, lblReservation.Font.Unit);
            lblReservation.ForeColor = Color.White;
            // Scholarship Default format
            float downSizeSc;
            downSizeSc = lblScholar.Font.Size;
            downSizeSc = 14.25F;
            lblScholar.Font = new Font(lblScholar.Font.Name, downSizeSc, lblScholar.Font.Style, lblScholar.Font.Unit);
            lblScholar.ForeColor = Color.White;

        }

        private void lblServices_Click(object sender, EventArgs e)
        {
            // Services pop up effect
            float UpSize;
            UpSize = lblServices.Font.Size;
            UpSize = 16.0F;
            lblServices.Font = new Font(lblServices.Font.Name, UpSize, lblServices.Font.Style, lblServices.Font.Unit);
            lblServices.ForeColor = Color.Gold;
            // About Digi Default format
            float downSizeA;
            downSizeA = lblAboutDigi.Font.Size;
            downSizeA = 14.25F;
            lblAboutDigi.Font = new Font(lblAboutDigi.Font.Name, downSizeA, lblAboutDigi.Font.Style, lblAboutDigi.Font.Unit);
            lblAboutDigi.ForeColor = SystemColors.ControlLightLight;
            // Reservation Default format
            float downSizeR;
            downSizeR = lblReservation.Font.Size;
            downSizeR = 14.25F;
            lblReservation.Font = new Font(lblReservation.Font.Name, downSizeR, lblReservation.Font.Style, lblReservation.Font.Unit);
            lblReservation.ForeColor = SystemColors.ControlLightLight;
            // Scholarship Default format
            float downSizeSc;
            downSizeSc = lblScholar.Font.Size;
            downSizeSc = 14.25F;
            lblScholar.Font = new Font(lblScholar.Font.Name, downSizeSc, lblScholar.Font.Style, lblScholar.Font.Unit);
            lblScholar.ForeColor = SystemColors.ControlLightLight;
        }

        private void lblReservation_Click(object sender, EventArgs e)
        {
            // Reservation pop up effect
            float UpSize;
            UpSize = lblReservation.Font.Size;
            UpSize = 16.0F;
            lblReservation.Font = new Font(lblReservation.Font.Name, UpSize, lblReservation.Font.Style, lblReservation.Font.Unit);
            lblReservation.ForeColor = Color.Gold;
            // About Digi Default format
            float downSizeA;
            downSizeA = lblAboutDigi.Font.Size;
            downSizeA = 14.25F;
            lblAboutDigi.Font = new Font(lblAboutDigi.Font.Name, downSizeA, lblAboutDigi.Font.Style, lblAboutDigi.Font.Unit);
            lblAboutDigi.ForeColor = SystemColors.ControlLightLight;
            // Services Default format
            float downSizeS;
            downSizeS = lblServices.Font.Size;
            downSizeS = 14.25F;
            lblServices.Font = new Font(lblServices.Font.Name, downSizeS, lblServices.Font.Style, lblServices.Font.Unit);
            lblServices.ForeColor = SystemColors.ControlLightLight;
            // Scholarship Default format
            float downSizeSc;
            downSizeSc = lblScholar.Font.Size;
            downSizeSc = 14.25F;
            lblScholar.Font = new Font(lblScholar.Font.Name, downSizeSc, lblScholar.Font.Style, lblScholar.Font.Unit);
            lblScholar.ForeColor = SystemColors.ControlLightLight;
        }

        private void lblScholar_Click(object sender, EventArgs e)
        {
            // Scholar pop up effect
            float UpSize;
            UpSize = lblScholar.Font.Size;
            UpSize = 16.0F;
            lblScholar.Font = new Font(lblScholar.Font.Name, UpSize, lblScholar.Font.Style, lblScholar.Font.Unit);
            lblScholar.ForeColor = Color.Gold;
            // About Digi Default format
            float downSizeA;
            downSizeA = lblAboutDigi.Font.Size;
            downSizeA = 14.25F;
            lblAboutDigi.Font = new Font(lblAboutDigi.Font.Name, downSizeA, lblAboutDigi.Font.Style, lblAboutDigi.Font.Unit);
            lblAboutDigi.ForeColor = SystemColors.ControlLightLight;
            // Services Default format
            float downSizeS;
            downSizeS = lblServices.Font.Size;
            downSizeS = 14.25F;
            lblServices.Font = new Font(lblServices.Font.Name, downSizeS, lblServices.Font.Style, lblServices.Font.Unit);
            lblServices.ForeColor = SystemColors.ControlLightLight;
            // Reservation Default format
            float downSizeR;
            downSizeR = lblReservation.Font.Size;
            downSizeR = 14.25F;
            lblReservation.Font = new Font(lblReservation.Font.Name, downSizeR, lblReservation.Font.Style, lblReservation.Font.Unit);
            lblReservation.ForeColor = SystemColors.ControlLightLight;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8HAO55D\SQLEXPRESS;Initial Catalog=DB_Reservation;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Reservation]
           ([firstname]
           ,[lastname]
           ,[email]
           ,[mobileNo]
           ,[Gender]
           ,[Request]
           ,[Sched/Pickup]
           ,[Date])
     VALUES
           ('"+txtFname.Text+"', '"+txtLname.Text+"', '"+txtEmail.Text+"', '"+txtMobileNumber.Text+"', '"+cmbGender.SelectedItem.ToString()+"', '"+txtRequest.Text+"', '"+txtSched.Text+"', '"+txtDateTime.Text+"')");
        }
    }
}
